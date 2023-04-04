namespace Furniture.WebFormsUI
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransaction
            // 
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.Location = new System.Drawing.Point(381, 12);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(350, 350);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnManagement.Image")));
            this.btnManagement.Location = new System.Drawing.Point(12, 13);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(350, 350);
            this.btnManagement.TabIndex = 2;
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnManagement;
    }
}