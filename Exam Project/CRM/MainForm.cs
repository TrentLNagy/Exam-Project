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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            CustomerAndVehicleInfo customerVehicleInfo = new CustomerAndVehicleInfo();
            customerVehicleInfo.ShowDialog();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            Parts parts = new Parts();
            parts.ShowDialog();
        }
    }
}
