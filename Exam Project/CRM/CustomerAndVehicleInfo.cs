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
            cmboBoxCustomerInfo.Items.Add("Customer Name");
            cmboBoxCustomerInfo.Items.Add("Phone number");
            cmboBoxCustomerInfo.Items.Add("License Plate");
            cmboBoxCustomerInfo.MaxDropDownItems = 3;

        }
    }
}
