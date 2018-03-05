namespace CRM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerCheckBox = new System.Windows.Forms.CheckBox();
            this.vehicleCheckBox = new System.Windows.Forms.CheckBox();
            this.partsCheckBox = new System.Windows.Forms.CheckBox();
            this.invoicesCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnParts = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invoicesCheckBox);
            this.groupBox1.Controls.Add(this.partsCheckBox);
            this.groupBox1.Controls.Add(this.vehicleCheckBox);
            this.groupBox1.Controls.Add(this.customerCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Fields";
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.AutoSize = true;
            this.customerCheckBox.Location = new System.Drawing.Point(7, 20);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(70, 17);
            this.customerCheckBox.TabIndex = 0;
            this.customerCheckBox.Text = "Customer";
            this.customerCheckBox.UseVisualStyleBackColor = true;
            // 
            // vehicleCheckBox
            // 
            this.vehicleCheckBox.AutoSize = true;
            this.vehicleCheckBox.Location = new System.Drawing.Point(94, 20);
            this.vehicleCheckBox.Name = "vehicleCheckBox";
            this.vehicleCheckBox.Size = new System.Drawing.Size(61, 17);
            this.vehicleCheckBox.TabIndex = 1;
            this.vehicleCheckBox.Text = "Vehicle";
            this.vehicleCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsCheckBox
            // 
            this.partsCheckBox.AutoSize = true;
            this.partsCheckBox.Location = new System.Drawing.Point(7, 44);
            this.partsCheckBox.Name = "partsCheckBox";
            this.partsCheckBox.Size = new System.Drawing.Size(50, 17);
            this.partsCheckBox.TabIndex = 2;
            this.partsCheckBox.Text = "Parts";
            this.partsCheckBox.UseVisualStyleBackColor = true;
            // 
            // invoicesCheckBox
            // 
            this.invoicesCheckBox.AutoSize = true;
            this.invoicesCheckBox.Location = new System.Drawing.Point(94, 44);
            this.invoicesCheckBox.Name = "invoicesCheckBox";
            this.invoicesCheckBox.Size = new System.Drawing.Size(66, 17);
            this.invoicesCheckBox.TabIndex = 3;
            this.invoicesCheckBox.Text = "Invoices";
            this.invoicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(124, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(225, 12);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 39);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnParts
            // 
            this.btnParts.Location = new System.Drawing.Point(225, 62);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(75, 39);
            this.btnParts.TabIndex = 7;
            this.btnParts.Text = "Parts";
            this.btnParts.UseVisualStyleBackColor = true;
            // 
            // btnVehicles
            // 
            this.btnVehicles.Location = new System.Drawing.Point(308, 12);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(75, 39);
            this.btnVehicles.TabIndex = 8;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.UseVisualStyleBackColor = true;
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(308, 62);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(75, 39);
            this.btnInvoices.TabIndex = 9;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(167, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 144);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.btnParts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Joe\'s Automotive CRM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox invoicesCheckBox;
        private System.Windows.Forms.CheckBox partsCheckBox;
        private System.Windows.Forms.CheckBox vehicleCheckBox;
        private System.Windows.Forms.CheckBox customerCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnClose;
    }
}

