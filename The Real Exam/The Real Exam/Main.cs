﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Vehicles vehicles = new Vehicles();
            vehicles.ShowDialog();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            Parts parts = new Parts();
            parts.ShowDialog();
        }
    }
}
