using SMS.DAL.Abstracts;
using SMS.DAL.Context;
using SMS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL.Concrete.EntityFramework
{
    public abstract class EFRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class
    {
        public SMSContext context;
        public EFRepositoryBase()
        {
            context = new SMSContext();
        }
        public TEntity Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return entity;
        }
        public TEntity Get(int id)
        {
            var entity = context.Set<TEntity>().Find(id);
            return entity;
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsNoTracking().ToList();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().AsNoTracking().Where(predicate).ToList();
        }

        public TEntity UpdateOrDelete(TEntity entity)
        {
            var result = context.Entry(entity);
            result.State = EntityState.Modified;
            context.SaveChanges();
            return entity;
        }
    }
}
