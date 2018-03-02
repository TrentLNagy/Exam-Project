namespace CRM
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.Location = new System.Drawing.Point(23, 12);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(93, 59);
            this.btnCustomerInfo.TabIndex = 0;
            this.btnCustomerInfo.Text = "Customer Information";
            this.btnCustomerInfo.UseVisualStyleBackColor = true;
            this.btnCustomerInfo.Click += new System.EventHandler(this.btnCustomerInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 319);
            this.Controls.Add(this.btnCustomerInfo);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive CRM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerInfo;
    }
}

