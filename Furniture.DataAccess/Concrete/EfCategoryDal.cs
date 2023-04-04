using Furniture.DataAccess.Abstract;
using Furniture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.DataAccess.Concrete
{
    public class EfCategoryDal : EntityRepositoryBase<Category, FurnitureContext>, ICategoryDal
    {

    }
}
