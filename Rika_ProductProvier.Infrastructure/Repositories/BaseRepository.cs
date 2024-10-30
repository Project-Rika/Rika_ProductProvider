using Rika_ProductProvier.Infrastructure.Data.Contexts;
using Rika_ProductProvier.Infrastructure.Interfaces;

namespace Rika_ProductProvier.Infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly ProductDbContext _context;

    public BaseRepository(ProductDbContext context)
    {
        _context = context;
    }

    public virtual async Task<TEntity> CreateOneAsync(TEntity entity)
    {
        try
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Task<TEntity> DeleteOneAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetOneAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> UpdateOneAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
