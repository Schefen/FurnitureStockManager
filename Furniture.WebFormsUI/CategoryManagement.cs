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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        ICategoryService _categoryService;
        FurnitureContext furnitureContext = new FurnitureContext();

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void ListCategories()
        {
            dgCategories.DataSource = _categoryService.ListCategories();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category
                {
                    CategoryId = Convert.ToInt32(tbCategoryId.Text),
                    CategoryName = tbCategoryName.Text,
                });
                MessageBox.Show("Kayıt Eklendi");
                ListCategories();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin");              
            }           
        }

        private void dgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCategoryId.Text = dgCategories.CurrentRow.Cells[0].Value.ToString();
            tbCategoryName.Text = dgCategories.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Update(new Category
                {
                    CategoryId = Convert.ToInt32(dgCategories.CurrentRow.Cells[0].Value),
                    CategoryName = tbCategoryName.Text,
                });
                MessageBox.Show("Kayıt Güncellendi");
                ListCategories();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin");
            }
        }
        public void Clear()
        {
            tbCategoryId.Text = "";
            tbCategoryName.Text = "";
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Delete(new Category
                {
                    CategoryId = Convert.ToInt32(dgCategories.CurrentRow.Cells[0].Value),
                });
                MessageBox.Show("Kayıt Silindi");
                ListCategories();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen girdiğiniz değerleri kontrol edin");            
            }
            
        }

        private void btnCategoryBack_Click(object sender, EventArgs e)
        {
            HomePage homePageFrm = new HomePage();
            homePageFrm.Show();
            this.Hide();
        }
    }
}
