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

            this.db = new CourseWorkDbContext();
            this.loginName.Text = MainFormService.AppUser.Login;
            this.btnLogout.Click += (sender, e) =>
            {
                MainFormService.LogoutUser();
                MainFormService.ShowLoginView();
            };
            this.Disposed += (sender, args) => db.Dispose();

            this.tabControlAirplanes.Selected +=  async (s, a) =>  await ShowAirplanesDataGrid();
        }

        AirplaneService airplaneService { get { return AirplaneService.Get(); } }

        

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

       
    }
}
