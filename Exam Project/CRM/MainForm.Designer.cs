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
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(108, 67);
            this.btnCustomerInfo.TabIndex = 0;
            this.btnCustomerInfo.Text = "Customer and Vehicle Information";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // btnParts
            // 
            this.btnParts.Location = new System.Drawing.Point(151, 12);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(108, 67);
            this.btnParts.TabIndex = 2;
            this.btnParts.Text = "Parts";
            this.btnParts.UseVisualStyleBackColor = true;
            this.btnParts.Click += new System.EventHandler(this.btnParts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 185);
            this.Controls.Add(this.btnParts);
            this.Controls.Add(this.btnCustomerInfo);
            this.Name = "MainForm";
            this.Text = "Joe\'s Automotive CRM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnParts;
    }
}

