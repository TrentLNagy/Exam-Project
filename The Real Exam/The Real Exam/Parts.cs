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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        public int maxID = 0;

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDBDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.cRMDBDataSet.Parts);

        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            string name;
            int cost, amount;

            name = nameTextBox.Text;
            cost = int.Parse(costTextBox.Text);
            amount = int.Parse(amountTextBox.Text);
            maxID = partsDataGridView.RowCount;

            partsTableAdapter.InsertData(name, amount, cost);

            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);
            this.partsTableAdapter.Fill(this.cRMDBDataSet.Parts);
        }
    }
}
