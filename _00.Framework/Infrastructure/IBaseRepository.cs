using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _00.Framework.Infrastructure
{
    public interface IBaseRepository<in Tkey, T>
    {
        void Creat(T entity);
        T Get(Tkey id);
        List<T> GetAll();
        bool Exists(Expression<Func<T, bool>> expression);
    }
}
