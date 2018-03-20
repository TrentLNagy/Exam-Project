namespace The_Real_Exam
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMDBDataSet = new The_Real_Exam.CRMDBDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnDeleteInfo = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.customerTableAdapter = new The_Real_Exam.CRMDBDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new The_Real_Exam.CRMDBDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(7, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 13);
            nameLabel.TabIndex = 32;
            nameLabel.Text = "New name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(7, 63);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 13);
            addressLabel.TabIndex = 33;
            addressLabel.Text = "New address:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(7, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(59, 13);
            emailLabel.TabIndex = 34;
            emailLabel.Text = "New email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(7, 102);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(65, 13);
            phoneLabel.TabIndex = 35;
            phoneLabel.Text = "New phone:";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 156);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(239, 220);
            this.customerDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.cRMDBDataSet;
            // 
            // cRMDBDataSet
            // 
            this.cRMDBDataSet.DataSetName = "CRMDBDataSet";
            this.cRMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(176, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 130);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vehicles";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(214, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 324);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(259, 275);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(75, 43);
            this.btnInvoices.TabIndex = 8;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.Location = new System.Drawing.Point(259, 226);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteInfo.TabIndex = 7;
            this.btnDeleteInfo.Text = "Delete info";
            this.btnDeleteInfo.UseVisualStyleBackColor = true;
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(259, 128);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(75, 43);
            this.btnAddInfo.TabIndex = 6;
            this.btnAddInfo.Text = "Add info";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(74, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(74, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(74, 38);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(74, 64);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email";
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(259, 177);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(75, 43);
            this.btnChangeInfo.TabIndex = 32;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = The_Real_Exam.CRMDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(10, 40);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox1.TabIndex = 33;
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.addressTextBox1.Location = new System.Drawing.Point(10, 79);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox1.TabIndex = 34;
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(10, 157);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox1.TabIndex = 35;
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.phoneTextBox1.Location = new System.Drawing.Point(10, 118);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinish);
            this.groupBox1.Controls.Add(this.nameTextBox1);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox1);
            this.groupBox1.Controls.Add(this.addressTextBox1);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.emailTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(364, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 223);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Info";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(10, 183);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 23);
            this.btnFinish.TabIndex = 37;
            this.btnFinish.Text = "Finish Editing";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 38;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.customerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRMDBDataSet cRMDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CRMDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private CRMDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnDeleteInfo;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button button1;
    }
}