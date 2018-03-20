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

                if (ValidatePhone() == true && ValidateName() == true && ValidateEmail() == true)
                {
                    customerTableAdapter.InsertData(maxID, name, address, phone, email);
                }

                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);
                this.customerTableAdapter.Fill(this.cRMDBDataSet.Customer);
                
                nameTextBox.Clear();
                addressTextBox.Clear();
                phoneTextBox.Clear();
                emailTextBox.Clear();
                nameTextBox.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * ValidatePhone method check the phoneTextBox
         * to see if it matched human definition of a phone number
         * 
         * @return isValid returns either a true or false if conditions are met
         */

        public bool ValidatePhone()
        {
            string phone = phoneTextBox.Text;
            bool isValid = false;

            if(phone.Length == 13)
            {
                foreach(char ch in phone)
                {
                    if (char.IsPunctuation(phone, 0) && char.IsPunctuation(phone, 4) && char.IsPunctuation(phone, 8))
                    {
                        isValid = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Phone number must be in format \"(XXX)XXX-XXXX\"");
            }

            return isValid;
        }

        /**
         * ValidateName method checks to see if there's any
         * numbers present inside of the nameTextBox.
         * The initial value isValid is set to true, but if a char
         * is read as an int, then the isValid will be set to false.
         * 
         * @return isValid returns either a true or false if conditions are met
         */

        private bool ValidateName()
        {
            bool isValid = true;
            string name = nameTextBox.Text;

            foreach(char ch in name)
            {
                if (char.IsDigit(ch))
                {
                    isValid = false;
                }
            }

            if(isValid == false)
            {
                MessageBox.Show("Invalid name - must be letters only.");
            }

            return isValid;
        }

        /**
         * ValidateEmail method checks to see if the email is valid, and returns
         * true or false depending on the outcome.
         * 
         * @return isValid returns either a true or false if conditions are met
         */

        private bool ValidateEmail()
        {
            bool isValid = false;
            string email = emailTextBox.Text;

            if (email.Contains('@') && email.Contains('.') && email.Length > 5)
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("Invalid email.");
            }

            return isValid;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                string phone = phoneTextBox.Text;
                string email = emailTextBox.Text;

                int selectedID = customerDataGridView.CurrentCell.RowIndex + 1;
                customerTableAdapter.DeleteData(selectedID, name, address, phone, email);

                this.Width = 361;
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);
                this.customerTableAdapter.Fill(this.cRMDBDataSet.Customer);

                MessageBox.Show(selectedID.ToString());
            }
            catch
            {
                MessageBox.Show("Don't try this srsly");
            }

        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            this.Width = 508;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                this.Width = 361;
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cRMDBDataSet);
                this.customerTableAdapter.Fill(this.cRMDBDataSet.Customer);
            }
            catch
            {
                MessageBox.Show("Yeah don't try this");
            }

        }
    }
}