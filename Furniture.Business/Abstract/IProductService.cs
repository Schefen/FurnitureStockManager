using Furniture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.Business.Abstract
{
    public interface IProductService
    {
        List<Product> ListProducts();
        List<Product> SearchProduct(string ProductName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
