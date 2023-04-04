using Furniture.Business.Abstract;
using Furniture.DataAccess.Abstract;
using Furniture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal; // New'lemeye gerek kalmadan kullanım sağlıyoruz.
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }
        public List<Category> CategorySearch(string CategoryName)
        {
            return _categoryDal.GetAll(p=>p.CategoryName.Contains(CategoryName)); // Parametre olan string değer var mı?
        }
        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
        public List<Category> ListCategories()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
