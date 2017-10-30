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

            this.Load += (s, a) => CbxQueriesFill();
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
            dataGridaCargos.Columns[dataGridaCargos.Columns.Count-1].Visible = false;
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

        //--------------------------------------------
        //------          ЗАПРОСЫ             -----
        //--------------------------------------------
        private void AddQuery(string text)
        {
            cbxQueries.Items.Add(text);
        }

        private void CbxQueriesFill()
        {
            AddQuery("Вывести грузы, которые перевозили все самолеты.");
            AddQuery("Вывести самолеты, которые не перевозили грузы в указанный аэропорт.");
            AddQuery("Вывести грузы, которые перевозили в указанный аэропорт заданные самолеты.");
            AddQuery("Вывести самолеты, которые могут перевезти указанный груз.");
            AddQuery("Вывести количество указанного груза, который может перевезти указанный самолет.");
        }

        private void ShowQuantityCargoForAirplane()
        {
            var airplane = cbx1.Items[cbx1.SelectedIndex] as Airplane;
            var cargo = cbx2.Items[cbx2.SelectedIndex] as Cargo;

            var count = Math.Floor(airplane.Carrying/(cargo.Weight*cargo.Quantity));

            listBox1.Items.Add("Самолет может вместить " +count+ " шт. указанного груза.");
        }

        List<int> addedCargoes = new List<int>();

        private void ShowPlanesAccessCargo()
        {
            if (addedCargoes.Count == 0) return;
            var cargoes = db.Cargoes
                .Where(c => addedCargoes.Contains(c.Id))
                .Select(c => c.Weight*c.Quantity)
                .ToList();
            float sum=0;
            cargoes.ForEach(c => sum += c);

            var airplanes = db.Airplanes
                .Where(c => c.Carrying >= sum)
                .ToList();

            airplanes.ForEach(c => listBox1.Items.Add(c));
            if (listBox1.Items.Count == 0)
                listBox1.Items.Add("Пусто.");
            listBox1.Refresh();
        }

        private void AddCargosToList()
        {
            var cargo = cbx2.Items[cbx2.SelectedIndex] as Cargo;
            if (!listBox2.Items.Contains(cargo))
            {
                addedCargoes.Add(cargo.Id);
                listBox2.Items.Add(cargo);
            }
        }

        List<int> addedPlanes = new List<int>();

        private void CargosTransportedToAirportOnAirplanes()
        {
            var airport = cbx1.Items[cbx1.SelectedIndex] as Airport;
            if (addedPlanes.Count == 0) return;
            var traffics = db.Traffics
                .Where(c => c.IdAirportTo == airport.Id && addedPlanes.Contains(c.IdAirplane))
                .ToList();

            foreach(var x in traffics)
            {
                foreach(var a in x.Cargos)
                {
                    listBox1.Items.Add(a);
                }
            }
            if (listBox1.Items.Count == 0)
                listBox1.Items.Add("Пусто.");

            listBox1.Refresh();
        }

        void ShowPlanesElements(bool a=false)
        {
            cbx2.Visible = a;
            lbl2.Visible = a;
            label3.Visible = a;
            listBox2.Visible = a;
            btnAddPlane.Visible = a;
            btnDeleteFromListBox2.Visible = a;
        }

        
        private void AddPlaneToListBox()
        {
            var airplane = cbx2.Items[cbx2.SelectedIndex] as Airplane;
            if (!listBox2.Items.Contains(airplane))
            {
                addedPlanes.Add(airplane.Id);
                listBox2.Items.Add(airplane);
            }
            
        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            if(cbxQueries.SelectedIndex == 2) AddPlaneToListBox();
            else if (cbxQueries.SelectedIndex == 3) AddCargosToList();
        }

        private void TransportedCargos()
        {
            var cargos = db.Cargoes
                .Where(c => c.Traffics.Count != 0 )
                .ToList();

            cargos.ForEach(c => listBox1.Items.Add(c.ToString()));
        }

        private void AirplanesDidntTransportToThisAirport()
        {
            var airport = cbx1.Items[cbx1.SelectedIndex] as Airport;

            var ids = db.Traffics
                .Where(c => c.IdAirportTo == airport.Id)
                .Select(c => c.IdAirplane)
                .Distinct()
                .ToArray();

            var airplanes = db.Airplanes
                .Where(c => !ids.Contains(c.Id))
                .Distinct()
                .ToList();

            airplanes.ForEach(c => listBox1.Items.Add(c));
        }

        private void Lbl1ShowInfo(string text="")
        {
            lbl1.Text = text;
        }

        void Lbl2ShowInfo(string text="")
        {
            lbl2.Text = text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (cbxQueries.SelectedIndex == 0)
                TransportedCargos();
            else if (cbxQueries.SelectedIndex == 1)
            {
                AirplanesDidntTransportToThisAirport();
            }
            else if (cbxQueries.SelectedIndex == 2)
            {
                CargosTransportedToAirportOnAirplanes();
            }
            else if (cbxQueries.SelectedIndex == 3)
            {
                ShowPlanesAccessCargo();
            }
            else if (cbxQueries.SelectedIndex == 4)
            {
                ShowQuantityCargoForAirplane();
            }

        }

        private void cbxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQueries.SelectedIndex == 0)
            {
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                Lbl1ShowInfo();
                cbx1.Visible = false;
                ShowPlanesElements();
            }
            else if (cbxQueries.SelectedIndex == 1)
            {
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                ShowPlanesElements();
                Lbl1ShowInfo("Аэропорт");
                cbx1.Visible = true;
                db.Airports.Load();
                cbx1.DataSource = db.Airports.Local.ToBindingList();
            }
            else if (cbxQueries.SelectedIndex == 2)
            {
                addedPlanes = new List<int>();
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                Lbl1ShowInfo("Аэропорт");
                label3.Text = "Добавленные самолеты";
                cbx1.Visible = true;
                db.Airports.Load();
                cbx1.DataSource = db.Airports.Local.ToBindingList();
                Lbl2ShowInfo("Самолет");
                db.Airplanes.Load();
                cbx2.DataSource = db.Airplanes.Local.ToBindingList();
                ShowPlanesElements(true);
            }
            else if (cbxQueries.SelectedIndex == 3)
            {
                addedCargoes = new List<int>();
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                Lbl1ShowInfo();
                cbx1.Visible = false;
                Lbl2ShowInfo("Груз");
                label3.Text = "Добавленные грузы";
                db.Cargoes.Load();
                cbx2.DataSource = db.Cargoes.Local.ToBindingList();
                ShowPlanesElements(true);
            }
            else if (cbxQueries.SelectedIndex == 4)
            {
                listBox2.Items.Clear();
                listBox2.Visible = false;
                lbl2.Visible = true;
                btnAddPlane.Visible = false;
                btnDeleteFromListBox2.Visible = false;
                listBox1.Items.Clear();
                Lbl1ShowInfo("Самолет");
                db.Airplanes.Load();
                cbx1.DataSource = db.Airplanes.Local.ToBindingList();
                cbx1.Visible = true;
                Lbl2ShowInfo("Груз");
                cbx2.Visible = true;
                label3.Text = "";
                db.Cargoes.Load();
                cbx2.DataSource = db.Cargoes.Local.ToBindingList();
                
            }

        }

        private void DeleteFromListBox2()
        {
            if (listBox2.SelectedIndex < 0) return;
            if (cbxQueries.SelectedIndex == 2)
            {
                var elem = listBox2.SelectedItem as Airplane;
                addedPlanes.Remove(elem.Id);
            }
            else if (cbxQueries.SelectedIndex == 3)
            {
                var elem = listBox2.SelectedItem as Cargo;
                addedCargoes.Remove(elem.Id);
            }
            else return;
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }


        private void btnDeleteFromListBox2_Click(object sender, EventArgs e)
        {
            DeleteFromListBox2();
        }
    }
}
