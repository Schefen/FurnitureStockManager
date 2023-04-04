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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> ListProducts()
        {
            return _productDal.GetAll();
        }

        public List<Product> SearchProduct(string ProductName)
        {
            return _productDal.GetAll(p => p.ProductName.Contains(ProductName));
        }
        
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
