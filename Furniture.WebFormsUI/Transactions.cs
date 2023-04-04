using Furniture.Business.Abstract;
using Furniture.Business.Concrete;
using Furniture.DataAccess.Concrete;
using Furniture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture.WebFormsUI
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        IProductService _productService;
        FurnitureContext furnitureContext = new FurnitureContext();
        private void Transactions_Load(object sender, EventArgs e)
        {
            ListProd();
            TotalStock();
            TotalPrice();
        }

        private void ListProd()
        {
            dgProducts.DataSource = _productService.ListProducts();
            this.dgProducts.Columns["Category"].Visible = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgProducts.DataSource = _productService.SearchProduct(tbSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(tbCategoryId.Text),
                    ProductName = tbProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbProductPrice.Text),
                    QuantityPerUnit = Convert.ToInt32(tbProductQuantity.Text)
                });
                MessageBox.Show("Kayıt Eklendi");
                ListProd();
                TotalStock();
                TotalPrice();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin");
            }
            
        }

        private void tbCategoryId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUpdateCategoryId.Text = dgProducts.CurrentRow.Cells[1].Value.ToString();
            tbUpdateProductName.Text = dgProducts.CurrentRow.Cells[3].Value.ToString();
            tbUpdateProductPrice.Text = dgProducts.CurrentRow.Cells[4].Value.ToString();
            tbUpdateProductQuantity.Text = dgProducts.CurrentRow.Cells[5].Value.ToString();

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgProducts.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(tbUpdateCategoryId.Text),
                    ProductName = tbUpdateProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbUpdateProductPrice.Text),
                    QuantityPerUnit = Convert.ToInt32(tbUpdateProductQuantity.Text)
                });
                MessageBox.Show("Kayıt Güncellendi");
                ListProd();
                TotalStock();
                TotalPrice();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgProducts.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Kayıt Silindi");
            ListProd();
            TotalStock();
            TotalPrice();
        }
        public void TotalStock()
        {
            var stock = 0;
            stock = furnitureContext.Products.Sum(p => p.QuantityPerUnit);
            lblQuantityR.Text = stock.ToString();
        }
        public void TotalPrice()
        {
            decimal price = 0;
            price = furnitureContext.Products.Sum(p => p.UnitPrice);
            lblPriceR.Text = Convert.ToDecimal(price).ToString();
        }

        private void btnOpenGrid_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePageFrm = new HomePage();
            homePageFrm.Show();
            this.Hide();
        }
    }
}
