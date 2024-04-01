using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IAsyncRepository<T>
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>? orderBy = null);  //orderBy = null default değer.
        Task<List<T>> GetListAsync(Expression<Func<T, bool>>? predicate=null, Expression<Func<T, object>>? orderBy = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
