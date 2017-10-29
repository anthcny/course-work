using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    using System.Data.Entity;
    using Dal;

    public partial class TrafficAddForm : MainForm
    {
        CourseWorkDbContext db;

        public TrafficAddForm()
        {
            InitializeComponent();
            db = MainFormService.Db;

            Load += async (s, a) => await FillAirplanesCbx();
            Load += async (s, a) => await FillAirportsCbxs();
            Load += async (s, a) => await FillCargoesCbx();
        }

        private async Task FillAirplanesCbx()
        {
            await db.Airplanes.LoadAsync();
            cbxAirplanes.DataSource = db.Airplanes.Local.ToBindingList();
        }

        private async Task FillAirportsCbxs()
        {
            await db.Airports.LoadAsync();
            var listFrom = db.Airports.Local.ToBindingList();
            BindingList<Airport> listTo = new BindingList<Airport>(listFrom);
            cbxFrom.DataSource = listFrom;
            cbxTo.DataSource = listTo;
        }
        
        private async Task FillCargoesCbx()
        {
            await db.Cargoes.LoadAsync();
            cbxCargoes.DataSource = db.Cargoes.Local.ToBindingList();
        }

        List<int> idCargoesToList = new List<int>();
        float cargosWeight=0;

        private void AddCargoToList()
        {
            var cargo = cbxCargoes.Items[cbxCargoes.SelectedIndex] as Cargo;
            var airPlane = cbxAirplanes.Items[cbxAirplanes.SelectedIndex] as Airplane;
            cargosWeight += cargo.Weight * cargo.Quantity;
            if(cargosWeight > airPlane.Carrying)
            {
                MessageBox.Show("Операция отклонена! Превышен суммерый вес груза для данного самолета.");
                return;
            }

            if (idCargoesToList.IndexOf(cargo.Id) >= 0) return;

            idCargoesToList.Add(cargo.Id);

            checkedListBoxCargoes.Items.Add(cbxCargoes.SelectedItem);
            checkedListBoxCargoes.Refresh();
        }

        private void DeleteCargoesFromList()
        {
            var checkedCargoes = checkedListBoxCargoes.CheckedItems;
            int countCheckedCargoes = checkedCargoes.Count;
            if (countCheckedCargoes == 0) return;

            while (checkedCargoes.Count != 0)
            {
                var itemToRemove = checkedCargoes[0];
                checkedListBoxCargoes.Items.Remove(itemToRemove);
                idCargoesToList.RemoveAt(idCargoesToList.IndexOf(cbxCargoes.Items.IndexOf(itemToRemove)));
            }
            checkedListBoxCargoes.Refresh();
        }

        private void AddNewTraffic()
        {
            if(cbxFrom.SelectedItem == cbxTo.SelectedItem)
            {
                MessageBox.Show("Операция Отклонена! Указанные города должны быть разными.");
                return;
            }

            if (idCargoesToList.Count == 0)
            {
                MessageBox.Show("Добавьте груз");
                return;
            }
            Traffic traffic = new Traffic
            {
                IdAirplane = (cbxAirplanes.Items[cbxAirplanes.SelectedIndex] as Airplane).Id,
                IdAirportFrom = (cbxFrom.Items[cbxFrom.SelectedIndex] as Airport).Id,
                IdAirportTo = (cbxTo.Items[cbxTo.SelectedIndex] as Airport).Id
            };

            var cargos = db.Cargoes
                 .Where(c => idCargoesToList.Contains(c.Id))
                 .ToList();

            cargos.ForEach(c => traffic.Cargos.Add(c));



            //db.Entry(traffic).State = EntityState.Modified;
            db.Traffics.Add(traffic);
            db.SaveChanges();
            this.Close();
        }

        private void btnAddToCargoList_Click(object sender, EventArgs e)
        {
            AddCargoToList();
        }

        private void btnDeleteCargoesFromList_Click(object sender, EventArgs e)
        {
            DeleteCargoesFromList();
        }

        private void btnAddNewTraffic_Click(object sender, EventArgs e)
        {
            AddNewTraffic();
        }
    }

}
