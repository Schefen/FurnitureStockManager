namespace Furniture.WebFormsUI
{
    partial class Transactions
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbCategoryId = new System.Windows.Forms.TextBox();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.lblPriceR = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantityR = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateProductQuantity = new System.Windows.Forms.Label();
            this.lblUpdateProductPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.lblUpdateCategoryName = new System.Windows.Forms.Label();
            this.lblUpdateCategoryId = new System.Windows.Forms.Label();
            this.tbUpdateProductQuantity = new System.Windows.Forms.TextBox();
            this.tbUpdateProductPrice = new System.Windows.Forms.TextBox();
            this.tbUpdateCategoryName = new System.Windows.Forms.TextBox();
            this.tbUpdateProductName = new System.Windows.Forms.TextBox();
            this.tbUpdateCategoryId = new System.Windows.Forms.TextBox();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            this.gbStatistics.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.gbTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.lblProductQuantity);
            this.gbAdd.Controls.Add(this.lblProductPrice);
            this.gbAdd.Controls.Add(this.lblProductName);
            this.gbAdd.Controls.Add(this.lblCategoryName);
            this.gbAdd.Controls.Add(this.lblCategoryId);
            this.gbAdd.Controls.Add(this.tbProductQuantity);
            this.gbAdd.Controls.Add(this.tbProductPrice);
            this.gbAdd.Controls.Add(this.tbCategoryName);
            this.gbAdd.Controls.Add(this.tbProductName);
            this.gbAdd.Controls.Add(this.tbCategoryId);
            this.gbAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAdd.Location = new System.Drawing.Point(12, 71);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(362, 322);
            this.gbAdd.TabIndex = 0;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Ürün Ekleme";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(210, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductQuantity.Location = new System.Drawing.Point(16, 211);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(106, 23);
            this.lblProductQuantity.TabIndex = 1;
            this.lblProductQuantity.Text = "Ürün Adedi :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Location = new System.Drawing.Point(16, 174);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(104, 23);
            this.lblProductPrice.TabIndex = 1;
            this.lblProductPrice.Text = "Ürün Fiyatı :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(16, 137);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(87, 23);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı :";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Location = new System.Drawing.Point(16, 100);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(112, 23);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Kategori Adı :";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryId.Location = new System.Drawing.Point(16, 63);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(105, 23);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Kategori ID :";
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductQuantity.Location = new System.Drawing.Point(129, 208);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(214, 31);
            this.tbProductQuantity.TabIndex = 0;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductPrice.Location = new System.Drawing.Point(129, 171);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(214, 31);
            this.tbProductPrice.TabIndex = 0;
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryName.Location = new System.Drawing.Point(129, 97);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.ReadOnly = true;
            this.tbCategoryName.Size = new System.Drawing.Size(214, 31);
            this.tbCategoryName.TabIndex = 0;
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbProductName.Location = new System.Drawing.Point(129, 134);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(214, 31);
            this.tbProductName.TabIndex = 0;
            // 
            // tbCategoryId
            // 
            this.tbCategoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCategoryId.Location = new System.Drawing.Point(129, 60);
            this.tbCategoryId.Name = "tbCategoryId";
            this.tbCategoryId.Size = new System.Drawing.Size(214, 31);
            this.tbCategoryId.TabIndex = 0;
            this.tbCategoryId.TextChanged += new System.EventHandler(this.tbCategoryId_TextChanged);
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.lblPriceR);
            this.gbStatistics.Controls.Add(this.lblPrice);
            this.gbStatistics.Controls.Add(this.lblQuantityR);
            this.gbStatistics.Controls.Add(this.lblQuantity);
            this.gbStatistics.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStatistics.Location = new System.Drawing.Point(396, 71);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(369, 147);
            this.gbStatistics.TabIndex = 1;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "İstatistikler";
            // 
            // lblPriceR
            // 
            this.lblPriceR.AutoSize = true;
            this.lblPriceR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceR.Location = new System.Drawing.Point(200, 80);
            this.lblPriceR.Name = "lblPriceR";
            this.lblPriceR.Size = new System.Drawing.Size(0, 23);
            this.lblPriceR.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(16, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(178, 23);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Ürünler Toplam Fiyat :";
            // 
            // lblQuantityR
            // 
            this.lblQuantityR.AutoSize = true;
            this.lblQuantityR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantityR.Location = new System.Drawing.Point(128, 48);
            this.lblQuantityR.Name = "lblQuantityR";
            this.lblQuantityR.Size = new System.Drawing.Size(0, 24);
            this.lblQuantityR.TabIndex = 0;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(16, 48);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 23);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Ürün Adedi :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 65);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 896);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 65);
            this.panel2.TabIndex = 3;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSearch.Location = new System.Drawing.Point(396, 224);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(369, 169);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Ürün Arama";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSearch.Location = new System.Drawing.Point(96, 90);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 31);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama :";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.lblUpdateProductQuantity);
            this.gbUpdate.Controls.Add(this.lblUpdateProductPrice);
            this.gbUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbUpdate.Controls.Add(this.lblUpdateCategoryName);
            this.gbUpdate.Controls.Add(this.lblUpdateCategoryId);
            this.gbUpdate.Controls.Add(this.tbUpdateProductQuantity);
            this.gbUpdate.Controls.Add(this.tbUpdateProductPrice);
            this.gbUpdate.Controls.Add(this.tbUpdateCategoryName);
            this.gbUpdate.Controls.Add(this.tbUpdateProductName);
            this.gbUpdate.Controls.Add(this.tbUpdateCategoryId);
            this.gbUpdate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUpdate.Location = new System.Drawing.Point(796, 71);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(369, 322);
            this.gbUpdate.TabIndex = 5;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Ürün Güncelleme";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(216, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateProductQuantity
            // 
            this.lblUpdateProductQuantity.AutoSize = true;
            this.lblUpdateProductQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateProductQuantity.Location = new System.Drawing.Point(29, 211);
            this.lblUpdateProductQuantity.Name = "lblUpdateProductQuantity";
            this.lblUpdateProductQuantity.Size = new System.Drawing.Size(106, 23);
            this.lblUpdateProductQuantity.TabIndex = 8;
            this.lblUpdateProductQuantity.Text = "Ürün Adedi :";
            // 
            // lblUpdateProductPrice
            // 
            this.lblUpdateProductPrice.AutoSize = true;
            this.lblUpdateProductPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateProductPrice.Location = new System.Drawing.Point(29, 174);
            this.lblUpdateProductPrice.Name = "lblUpdateProductPrice";
            this.lblUpdateProductPrice.Size = new System.Drawing.Size(104, 23);
            this.lblUpdateProductPrice.TabIndex = 9;
            this.lblUpdateProductPrice.Text = "Ürün Fiyatı :";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateProductName.Location = new System.Drawing.Point(29, 137);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(87, 23);
            this.lblUpdateProductName.TabIndex = 10;
            this.lblUpdateProductName.Text = "Ürün Adı :";
            // 
            // lblUpdateCategoryName
            // 
            this.lblUpdateCategoryName.AutoSize = true;
            this.lblUpdateCategoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateCategoryName.Location = new System.Drawing.Point(29, 100);
            this.lblUpdateCategoryName.Name = "lblUpdateCategoryName";
            this.lblUpdateCategoryName.Size = new System.Drawing.Size(112, 23);
            this.lblUpdateCategoryName.TabIndex = 11;
            this.lblUpdateCategoryName.Text = "Kategori Adı :";
            // 
            // lblUpdateCategoryId
            // 
            this.lblUpdateCategoryId.AutoSize = true;
            this.lblUpdateCategoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateCategoryId.Location = new System.Drawing.Point(29, 63);
            this.lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            this.lblUpdateCategoryId.Size = new System.Drawing.Size(105, 23);
            this.lblUpdateCategoryId.TabIndex = 12;
            this.lblUpdateCategoryId.Text = "Kategori ID :";
            // 
            // tbUpdateProductQuantity
            // 
            this.tbUpdateProductQuantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateProductQuantity.Location = new System.Drawing.Point(142, 208);
            this.tbUpdateProductQuantity.Name = "tbUpdateProductQuantity";
            this.tbUpdateProductQuantity.Size = new System.Drawing.Size(214, 31);
            this.tbUpdateProductQuantity.TabIndex = 3;
            // 
            // tbUpdateProductPrice
            // 
            this.tbUpdateProductPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateProductPrice.Location = new System.Drawing.Point(142, 171);
            this.tbUpdateProductPrice.Name = "tbUpdateProductPrice";
            this.tbUpdateProductPrice.Size = new System.Drawing.Size(214, 31);
            this.tbUpdateProductPrice.TabIndex = 4;
            // 
            // tbUpdateCategoryName
            // 
            this.tbUpdateCategoryName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateCategoryName.Location = new System.Drawing.Point(142, 97);
            this.tbUpdateCategoryName.Name = "tbUpdateCategoryName";
            this.tbUpdateCategoryName.ReadOnly = true;
            this.tbUpdateCategoryName.Size = new System.Drawing.Size(214, 31);
            this.tbUpdateCategoryName.TabIndex = 5;
            // 
            // tbUpdateProductName
            // 
            this.tbUpdateProductName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateProductName.Location = new System.Drawing.Point(142, 134);
            this.tbUpdateProductName.Name = "tbUpdateProductName";
            this.tbUpdateProductName.Size = new System.Drawing.Size(214, 31);
            this.tbUpdateProductName.TabIndex = 6;
            // 
            // tbUpdateCategoryId
            // 
            this.tbUpdateCategoryId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateCategoryId.Location = new System.Drawing.Point(142, 60);
            this.tbUpdateCategoryId.Name = "tbUpdateCategoryId";
            this.tbUpdateCategoryId.Size = new System.Drawing.Size(214, 31);
            this.tbUpdateCategoryId.TabIndex = 7;
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.btnBack);
            this.gbTrans.Controls.Add(this.btnDelete);
            this.gbTrans.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTrans.Location = new System.Drawing.Point(1203, 76);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(369, 317);
            this.gbTrans.TabIndex = 5;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "İşlemler";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(119, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 34);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgProducts
            // 
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(12, 432);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.Size = new System.Drawing.Size(1560, 458);
            this.dgProducts.TabIndex = 6;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(119, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 34);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.gbTrans);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.gbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbStatistics.ResumeLayout(false);
            this.gbStatistics.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.gbTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox tbCategoryId;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.GroupBox gbStatistics;
        private System.Windows.Forms.Label lblPriceR;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantityR;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateProductQuantity;
        private System.Windows.Forms.Label lblUpdateProductPrice;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Label lblUpdateCategoryName;
        private System.Windows.Forms.Label lblUpdateCategoryId;
        private System.Windows.Forms.TextBox tbUpdateProductQuantity;
        private System.Windows.Forms.TextBox tbUpdateProductPrice;
        private System.Windows.Forms.TextBox tbUpdateCategoryName;
        private System.Windows.Forms.TextBox tbUpdateProductName;
        private System.Windows.Forms.TextBox tbUpdateCategoryId;
        private System.Windows.Forms.GroupBox gbTrans;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button btnBack;
    }
}