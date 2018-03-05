using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class CustomerAndVehicleInfo : Form
    {
        public CustomerAndVehicleInfo()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerAndVehicleInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDBDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cRMDBDataSet1.Customer);
            cmboBoxCustomerInfo.Items.Add("Customer Name");
            cmboBoxCustomerInfo.Items.Add("Phone number");
            cmboBoxCustomerInfo.Items.Add("License Plate");
            cmboBoxCustomerInfo.MaxDropDownItems = 3;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
