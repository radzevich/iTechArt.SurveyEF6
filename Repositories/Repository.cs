using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace EF6CodeFirstApplication.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> SetOfEntities;

        public Repository(DbContext context)
        {
            Context = context;
            SetOfEntities = Context.Set<TEntity>();
        }

        public void Create(TEntity entityItem)
        {
            SetOfEntities.Add(entityItem);
            Context.SaveChanges();
        }

        public IEnumerable<TEntity> Read()
        {
            return SetOfEntities.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Read(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public void Remove(TEntity item)
        {
            SetOfEntities.Remove(item);
            Context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            Context.Entry(item).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
