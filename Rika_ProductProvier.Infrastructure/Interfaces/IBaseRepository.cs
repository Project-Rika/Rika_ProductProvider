namespace Rika_ProductProvier.Infrastructure.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateOneAsync(TEntity entity);
        Task<TEntity> UpdateOneAsync(TEntity entity);
        Task<TEntity> DeleteOneAsync(TEntity entity);
        Task<TEntity> GetOneAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}