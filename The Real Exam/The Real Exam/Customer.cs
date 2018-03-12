using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace The_Real_Exam
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public int maxID = 0;

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cRMDBDataSet.Customer);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;
                
                maxID = customerDataGridView.RowCount;
                customerTableAdapter.InsertData(maxID, name, address, phone, email);

                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);
                this.customerTableAdapter.Fill(this.cRMDBDataSet.Customer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}