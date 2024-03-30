using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IRepository<T>
    {
        T? Get(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>? orderBy = null);  //orderBy = null default değer.
        List<T> GetList(Expression<Func<T, bool>>? predicate, Expression<Func<T, object>>? orderBy = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
