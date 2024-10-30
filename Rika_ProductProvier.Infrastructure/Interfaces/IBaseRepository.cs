using System.Linq.Expressions;

namespace Rika_ProductProvier.Infrastructure.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateOneAsync(TEntity entity);
        Task<TEntity> UpdateOneAsync(TEntity entity);
        Task<TEntity> DeleteOneAsync(TEntity entity);
        Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
    }
}