using _00.Framework.Domin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _00.Framework.Infrastructure
{
    public abstract class BaseRepository<Tkey, T> : IBaseRepository<Tkey, T> where T : DominBase<Tkey>
    {
        private readonly DbContext dbContext;

        public BaseRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Creat(T entity)
        {
            dbContext.Add<T>(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().Any(expression);
        }

        public T Get(Tkey id)
        {
            return dbContext.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }
    }
}
