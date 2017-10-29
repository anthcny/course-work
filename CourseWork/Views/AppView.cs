using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Views
{
    using Services;
    using Dal;
    using System.Data.Entity;

    public partial class AppView : UserControl
    {
        CourseWorkDbContext db;
        public AppView()
        {
            InitializeComponent();

            //this.db = new CourseWorkDbContext();
            db = MainFormService.Db;
            this.loginName.Text = MainFormService.AppUser.Login;
            this.btnLogout.Click += (sender, e) =>
            {
                MainFormService.LogoutUser();
                MainFormService.ShowLoginView();
            };
            this.Disposed += (sender, args) => db.Dispose();

            this.tabControlAirplanes.Selected += async (sender, args) => await ShowTab(args.TabPage);
            this.btnDeleteTraffic.Click += async (s, a) => await DeleteTraffic();

            this.Load += async (s, a) =>
            {
                await ShowTab(this.tabControlAirplanes.SelectedTab);
            };
        }

        async Task ShowTab(TabPage tab)
        {
            if (this.tabAirplane == tab)
                await ShowAirplanesDataGrid();
            else if (this.tabCargos == tab)
                await ShowCargosDataGrid();
            else if (this.tabAirports == tab)
                await ShowAirportsDataGrid();
            else if (this.tabTraffic == tab)
                await ShowTraffic();
        }

        //AirplaneService airplaneService { get { return AirplaneService.Get(); } } 

        //--------------------------------------------
        //------           AIRPLANES           -----
        //--------------------------------------------

        private async Task ShowAirplanesDataGrid()
        {
            await db.Airplanes.LoadAsync();

            dataGridAirplanes.DataSource = db.Airplanes.Local.ToBindingList();
        }

        private void ChangeAirplaneData()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNameAir.Text)
                    && string.IsNullOrEmpty(textBoxMaxDistance.Text)
                    && string.IsNullOrEmpty(textBoxCarrying.Text))
                    return;

                var airplane = GetSelectedAirplane();

                if (airplane == null)
                    return;

                var newAirplane = new Airplane();

                if (!string.IsNullOrEmpty(textBoxNameAir.Text))
                    newAirplane.Name = textBoxNameAir.Text;
                else
                    newAirplane.Name = airplane.Name;

                if (!string.IsNullOrEmpty(textBoxMaxDistance.Text))
                    newAirplane.MaxDistance = Int32.Parse(textBoxMaxDistance.Text);
                else
                    newAirplane.MaxDistance = airplane.MaxDistance;

                if (!string.IsNullOrEmpty(textBoxCarrying.Text))
                    newAirplane.Carrying = Int32.Parse(textBoxCarrying.Text);
                else
                    newAirplane.Carrying = airplane.Carrying;

                if (airplane.Equals(newAirplane))
                    return;

                airplane.Name = newAirplane.Name;
                airplane.MaxDistance = newAirplane.MaxDistance;
                airplane.Carrying = newAirplane.Carrying;

                ClearFieldsInput();

                db.Entry(airplane).State = EntityState.Modified;
                db.SaveChanges();
                dataGridAirplanes.Refresh();
                ShowInfo("Объект изменен!");
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void AddAirplaneData()
        {
            try
            {
                if (textBoxNameAir.Text != "" && textBoxMaxDistance.Text != "" && textBoxCarrying.Text != "")
                {
                    Airplane airplane = new Airplane
                    {
                        Name = textBoxNameAir.Text,
                        MaxDistance = Int32.Parse(textBoxMaxDistance.Text),
                        Carrying = Int32.Parse(textBoxCarrying.Text)
                    };

                    db.Airplanes.Add(airplane);
                    db.SaveChanges();
                    dataGridAirplanes.Refresh();
                    ClearFieldsInput();
                    ShowInfo("Новый объект добавлен!");

                }
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }

        }

        void ClearFieldsInput()
        {
            textBoxNameAir.Clear();
            textBoxMaxDistance.Clear();
            textBoxCarrying.Clear();
        }

        private void DeleteAirplaneData()
        {
            try
            {
                var airplane = GetSelectedAirplane();
                if (airplane == null)
                    return;

                db.Airplanes.Remove(airplane);
                db.SaveChanges();
                ShowInfo("Объект удален!");
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }

        }

        void ShowInfo(string text = "")
        {
            labelinfo.Text = text;
        }

        Airplane GetSelectedAirplane()
        {
            if (dataGridAirplanes.SelectedRows.Count == 0)
                return null;

            return dataGridAirplanes.SelectedRows[0].DataBoundItem as Airplane;
        }

        private void btnChangeAirplane_Click(object sender, EventArgs e)
        {
            ShowInfo();
            ChangeAirplaneData();
        }

        private void btnAddAirplane_Click(object sender, EventArgs e)
        {
            ShowInfo();
            AddAirplaneData();
        }

        private void btnDeleteAirplane_Click(object sender, EventArgs e)
        {
            ShowInfo();
            DeleteAirplaneData();
        }

        private void textBoxMaxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBoxCarrying_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //--------------------------------------------
        //------             CARGOS              -----
        //--------------------------------------------

        private async Task ShowCargosDataGrid()
        {
            await db.Cargoes.LoadAsync();
            dataGridaCargos.DataSource = db.Cargoes.Local.ToBindingList();
        }

        void ShowInfoCargo(string text = "")
        {
            labelCargoInfo.Text = text;
        }

        void ClearFieldsInputCargo()
        {
            textBoxNameCargo.Clear();
            textBoxQuantityCargo.Clear();
            textBoxWeightCargo.Clear();
        }

        Cargo GetSelectedCargo()
        {
            if (dataGridaCargos.SelectedRows.Count == 0)
                return null;
            return dataGridaCargos.SelectedRows[0].DataBoundItem as Cargo;
        }

        private void DeleteCargoData()
        {
            try
            {
                var cargo = GetSelectedCargo();
                if (cargo == null)
                    return;

                db.Cargoes.Remove(cargo);
                db.SaveChanges();
                ShowInfoCargo("Объект удален!");
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void AddCargoData()
        {
            try
            {
                if (textBoxNameCargo.Text != "" && textBoxWeightCargo.Text != "" && textBoxQuantityCargo.Text != "")
                {
                    Cargo cargo = new Cargo
                    {
                        Name = textBoxNameCargo.Text,
                        Weight = Single.Parse(textBoxWeightCargo.Text),
                        Quantity = Int32.Parse(textBoxQuantityCargo.Text)
                    };

                    db.Cargoes.Add(cargo);
                    db.SaveChanges();
                    dataGridAirplanes.Refresh();
                    ClearFieldsInputCargo();
                    ShowInfoCargo("Новый объект добавлен!");

                }
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void ChangeCargoData()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNameCargo.Text)
                    && string.IsNullOrEmpty(textBoxWeightCargo.Text)
                    && string.IsNullOrEmpty(textBoxQuantityCargo.Text))
                    return;

                var cargo = GetSelectedCargo();

                if (cargo == null)
                    return;

                var newCargo = new Cargo();

                if (!string.IsNullOrEmpty(textBoxNameCargo.Text))
                    newCargo.Name = textBoxNameCargo.Text;
                else
                    newCargo.Name = cargo.Name;

                if (!string.IsNullOrEmpty(textBoxWeightCargo.Text))
                    newCargo.Weight = Single.Parse(textBoxWeightCargo.Text);
                else
                    newCargo.Weight = cargo.Weight;

                if (!string.IsNullOrEmpty(textBoxQuantityCargo.Text))
                    newCargo.Quantity = Int32.Parse(textBoxQuantityCargo.Text);
                else
                    newCargo.Quantity = cargo.Quantity;

                if (cargo.Equals(newCargo))
                    return;

                cargo.Name = newCargo.Name;
                cargo.Weight = newCargo.Weight;
                cargo.Quantity = newCargo.Quantity;

                ClearFieldsInput();

                db.Entry(cargo).State = EntityState.Modified;
                db.SaveChanges();
                dataGridaCargos.Refresh();
                ShowInfoCargo("Объект изменен!");
                ClearFieldsInputCargo();
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            ShowInfoCargo();
            AddCargoData();
        }

        private void btnChangeCargo_Click(object sender, EventArgs e)
        {
            ShowInfoCargo();
            ChangeCargoData();
        }

        private void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            ShowInfoCargo();
            DeleteCargoData();
        }

        private void textBoxWeightCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }

        }

        private void textBoxQuantityCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }


        //--------------------------------------------
        //------          AIRPORTS             -----
        //--------------------------------------------
        private async Task ShowAirportsDataGrid()
        {
            await db.Airports.LoadAsync();
            dataGridAirports.DataSource = db.Airports.Local.ToBindingList();
        }

        void ShowInfoAirport(string text = "")
        {
            labelAirportInfo.Text = text;
        }

        void ClearFieldsInputAirport()
        {
            textBoxCityAirport.Clear();
        }

        Airport GetSelectedAirport()
        {
            if (dataGridAirports.SelectedRows.Count == 0)
                return null;
            return dataGridAirports.SelectedRows[0].DataBoundItem as Airport;
        }

        private void DeleteAirportData()
        {
            try
            {
                var airport = GetSelectedAirport();
                if (airport == null)
                    return;

                db.Airports.Remove(airport);
                db.SaveChanges();
                ShowInfoAirport("Объект удален!");
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void AddAirportData()
        {
            try
            {
                if (textBoxCityAirport.Text != "")
                {
                    Airport airport = new Airport
                    {
                        City = textBoxCityAirport.Text
                    };

                    db.Airports.Add(airport);
                    db.SaveChanges();
                    dataGridAirports.Refresh();
                    ClearFieldsInputAirport();
                    ShowInfoAirport("Новый объект добавлен!");

                }
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void ChangeAirportData()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCityAirport.Text))
                    return;

                var airport = GetSelectedAirport();

                if (airport == null)
                    return;

                var newAirport = new Airport();

                if (!string.IsNullOrEmpty(textBoxCityAirport.Text))
                    newAirport.City = textBoxCityAirport.Text;
                else
                    newAirport.City = airport.City;

                

                if (airport.Equals(newAirport))
                    return;

                airport.City = newAirport.City;

                ClearFieldsInputAirport();

                db.Entry(airport).State = EntityState.Modified;
                db.SaveChanges();
                dataGridAirports.Refresh();
                ShowInfoAirport("Объект изменен!");
                ClearFieldsInputAirport();
            }
            catch (Exception ex)
            {
                MainFormService.ShowError(ex.Message);
            }
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            ShowInfoAirport();
            AddAirportData();
        }

        private void btnChangeAirport_Click(object sender, EventArgs e)
        {
            ShowInfoAirport();
            ChangeAirportData();
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            ShowInfoAirport();
            DeleteAirportData();
        }

        //--------------------------------------------
        //------          TRAFFICS             -----
        //--------------------------------------------

        
        async Task ShowTraffic()
        {
            await UpdateTrafficTree();

        }

        async Task UpdateTrafficTree()
        {
            var traffics = await db.Traffics
                .Include(t => t.Cargos)
                .ToListAsync();

            this.trafficTree.Nodes.Clear();

            traffics.ForEach(traffic =>
            {
                var from = db.Airports.FirstOrDefault(a => a.Id == traffic.IdAirportFrom);
                var to = db.Airports.FirstOrDefault(a => a.Id == traffic.IdAirportTo);
                var airplane = db.Airplanes.FirstOrDefault(a => a.Id == traffic.IdAirplane);
                var listCargos = traffic.Cargos.Select(c => c.Quantity * c.Weight).ToList();
                float sumCargos = 0;
                listCargos.ForEach(c => sumCargos += c);
                var node = new TreeNode($"{from.City} -> {to}, Самолет {airplane.Name}, Груз  {sumCargos} (кг)")
                {
                    Tag = traffic
                };
                var childNodes = traffic.Cargos.Select(carg => 
                    new TreeNode($"{carg.Name} - {carg.Quantity} шт. ({carg.Quantity * carg.Weight} кг)") {
                        Tag = carg
                    }).ToArray();
                node.Nodes.AddRange(childNodes);
                this.trafficTree.Nodes.Add(node);
            });
        }

        private void btnAddTraffic_Click(object sender, EventArgs e)
        {
            TrafficAddForm formTAdd = new TrafficAddForm();
            formTAdd.Show();
            formTAdd.FormClosed += async (s, a) => await this.UpdateTrafficTree();
        }

        private async Task DeleteTraffic()
        {
            var selected = this.trafficTree.SelectedNode;
            if (selected == null)
                return;
            var traffic = selected.Tag as Traffic;
            if (traffic == null)
                return;

            var trafficDb = db.Traffics.FirstOrDefault(t => t.Id == traffic.Id);
            db.Traffics.Remove(trafficDb);
            db.SaveChanges();

            await UpdateTrafficTree();
        }
    }
}
