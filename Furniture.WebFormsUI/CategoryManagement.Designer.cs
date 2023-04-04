namespace Furniture.WebFormsUI
{
    partial class CategoryManagement
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
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbCategoryId = new System.Windows.Forms.TextBox();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryBack = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategories
            // 
            this.dgCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Location = new System.Drawing.Point(12, 58);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.Size = new System.Drawing.Size(342, 325);
            this.dgCategories.TabIndex = 0;
            this.dgCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategories_CellClick);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryId.Location = new System.Drawing.Point(371, 118);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(108, 23);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category Id :";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Location = new System.Drawing.Point(371, 173);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(117, 23);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Adı :";
            // 
            // tbCategoryId
            // 
            this.tbCategoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryId.Location = new System.Drawing.Point(488, 115);
            this.tbCategoryId.Name = "tbCategoryId";
            this.tbCategoryId.Size = new System.Drawing.Size(171, 31);
            this.tbCategoryId.TabIndex = 2;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryName.Location = new System.Drawing.Point(488, 170);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(171, 31);
            this.tbCategoryName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 52);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 52);
            this.panel2.TabIndex = 4;
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryAdd.Location = new System.Drawing.Point(384, 289);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(133, 34);
            this.btnCategoryAdd.TabIndex = 5;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryDelete.Location = new System.Drawing.Point(384, 329);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(133, 34);
            this.btnCategoryDelete.TabIndex = 5;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryBack
            // 
            this.btnCategoryBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryBack.Location = new System.Drawing.Point(523, 329);
            this.btnCategoryBack.Name = "btnCategoryBack";
            this.btnCategoryBack.Size = new System.Drawing.Size(133, 34);
            this.btnCategoryBack.TabIndex = 5;
            this.btnCategoryBack.Text = "Geri";
            this.btnCategoryBack.UseVisualStyleBackColor = true;
            this.btnCategoryBack.Click += new System.EventHandler(this.btnCategoryBack_Click);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryUpdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryUpdate.Location = new System.Drawing.Point(523, 289);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnCategoryUpdate.TabIndex = 5;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 441);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnCategoryBack);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnCategoryAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.tbCategoryId);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.dgCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryManagement";
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbCategoryId;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryBack;
        private System.Windows.Forms.Button btnCategoryUpdate;
    }
}