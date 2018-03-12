using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Real_Exam
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void vehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);

        }

        public int maxID;

        private void Vehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDBDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.cRMDBDataSet.Vehicles);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string make, model, year, mileage;
                make = makeTextBox.Text;
                model = modelTextBox.Text;
                year = yearTextBox.Text;
                mileage = mileageTextBox.Text;
                string dateTime1 = date_RecievedDateTimePicker.Text;
                string dateTime2 = date_ReturnedDateTimePicker.Text;

                maxID = vehiclesDataGridView.RowCount;
                vehiclesTableAdapter.InsertData(maxID, make, model, 0, 0, System.DateTime.Now, System.DateTime.Now);

                this.Validate();
                this.vehiclesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);
                this.vehiclesTableAdapter.Fill(this.cRMDBDataSet.Vehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
