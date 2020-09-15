using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IService<TEntity> where TEntity:class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        TEntity Update(TEntity entity);
    }
}
