namespace The_Real_Exam
{
    partial class Vehicles
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
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label date_RecievedLabel;
            System.Windows.Forms.Label date_ReturnedLabel;
            this.cRMDBDataSet = new The_Real_Exam.CRMDBDataSet();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new The_Real_Exam.CRMDBDataSetTableAdapters.VehiclesTableAdapter();
            this.tableAdapterManager = new The_Real_Exam.CRMDBDataSetTableAdapters.TableAdapterManager();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.date_RecievedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_ReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnDeleteInfo = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            date_RecievedLabel = new System.Windows.Forms.Label();
            date_ReturnedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(18, 15);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 1;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(16, 41);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(23, 67);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Year:";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(8, 93);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(47, 13);
            mileageLabel.TabIndex = 6;
            mileageLabel.Text = "Mileage:";
            // 
            // date_RecievedLabel
            // 
            date_RecievedLabel.AutoSize = true;
            date_RecievedLabel.Location = new System.Drawing.Point(167, 12);
            date_RecievedLabel.Name = "date_RecievedLabel";
            date_RecievedLabel.Size = new System.Drawing.Size(82, 13);
            date_RecievedLabel.TabIndex = 8;
            date_RecievedLabel.Text = "Date Recieved:";
            // 
            // date_ReturnedLabel
            // 
            date_ReturnedLabel.AutoSize = true;
            date_ReturnedLabel.Location = new System.Drawing.Point(169, 38);
            date_ReturnedLabel.Name = "date_ReturnedLabel";
            date_ReturnedLabel.Size = new System.Drawing.Size(80, 13);
            date_ReturnedLabel.TabIndex = 10;
            date_ReturnedLabel.Text = "Date Returned:";
            // 
            // cRMDBDataSet
            // 
            this.cRMDBDataSet.DataSetName = "CRMDBDataSet";
            this.cRMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.cRMDBDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_Real_Exam.CRMDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(61, 12);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(61, 38);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(61, 64);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 5;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Mileage", true));
            this.mileageTextBox.Location = new System.Drawing.Point(61, 90);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 7;
            // 
            // date_RecievedDateTimePicker
            // 
            this.date_RecievedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiclesBindingSource, "Date Recieved", true));
            this.date_RecievedDateTimePicker.Location = new System.Drawing.Point(255, 8);
            this.date_RecievedDateTimePicker.Name = "date_RecievedDateTimePicker";
            this.date_RecievedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_RecievedDateTimePicker.TabIndex = 9;
            // 
            // date_ReturnedDateTimePicker
            // 
            this.date_ReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiclesBindingSource, "Date Returned", true));
            this.date_ReturnedDateTimePicker.Location = new System.Drawing.Point(255, 34);
            this.date_ReturnedDateTimePicker.Name = "date_ReturnedDateTimePicker";
            this.date_ReturnedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_ReturnedDateTimePicker.TabIndex = 11;
            // 
            // vehiclesDataGridView
            // 
            this.vehiclesDataGridView.AutoGenerateColumns = false;
            this.vehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vehiclesDataGridView.DataSource = this.vehiclesBindingSource;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(19, 172);
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.Size = new System.Drawing.Size(440, 220);
            this.vehiclesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn2.HeaderText = "Make";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mileage";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date Recieved";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Recieved";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date Returned";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date Returned";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(365, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 43);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(284, 113);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(75, 43);
            this.btnInvoices.TabIndex = 19;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.Location = new System.Drawing.Point(365, 63);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteInfo.TabIndex = 18;
            this.btnDeleteInfo.Text = "Delete info";
            this.btnDeleteInfo.UseVisualStyleBackColor = true;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(284, 64);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(75, 43);
            this.btnChangeInfo.TabIndex = 17;
            this.btnChangeInfo.Text = "Change info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(203, 63);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(75, 43);
            this.btnAddInfo.TabIndex = 16;
            this.btnAddInfo.Text = "Add info";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(190, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(21, 146);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 20);
            this.txtSearch.TabIndex = 21;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 404);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.vehiclesDataGridView);
            this.Controls.Add(date_ReturnedLabel);
            this.Controls.Add(this.date_ReturnedDateTimePicker);
            this.Controls.Add(date_RecievedLabel);
            this.Controls.Add(this.date_RecievedDateTimePicker);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRMDBDataSet cRMDBDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private CRMDBDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private CRMDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.DateTimePicker date_RecievedDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_ReturnedDateTimePicker;
        private System.Windows.Forms.DataGridView vehiclesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnDeleteInfo;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}