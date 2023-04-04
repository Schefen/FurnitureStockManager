using Furniture.DataAccess.Abstract;
using Furniture.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Furniture.DataAccess.Concrete
{
    public class EntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext furnitureContext = new TContext())
            {
                var added = furnitureContext.Entry(entity);
                added.State = EntityState.Added;
                furnitureContext.SaveChanges();
            }                   
        }

        public void Delete(TEntity entity)
        {
            using (TContext furnitureContext = new TContext())
            {
                var deleted = furnitureContext.Entry(entity);
                deleted.State = EntityState.Deleted;
                furnitureContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext furnitureContext = new TContext())
            {
                return furnitureContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext furnitureContext = new TContext())
            {
                return filter == null ? furnitureContext.Set<TEntity>().ToList():furnitureContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext furnitureContext = new TContext())
            {
                var updated = furnitureContext.Entry(entity);
                updated.State = EntityState.Modified;
                furnitureContext.SaveChanges();
            }
        }
    }
}
