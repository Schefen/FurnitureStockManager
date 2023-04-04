using Furniture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> ListCategories();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        List<Category> CategorySearch(string CategoryName);

    }
}
