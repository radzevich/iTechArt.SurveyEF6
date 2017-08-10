using System;
using System.Collections.Generic;

namespace EF6CodeFirstApplication.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entityItem);
        IEnumerable<TEntity> Read();
        IEnumerable<TEntity> Read(Func<TEntity, bool> predicate);
        void Remove(TEntity entityItem);
        void Update(TEntity entityItem);
    }
}
