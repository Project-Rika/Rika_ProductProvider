using Rika_ProductProvier.Infrastructure.Data.Contexts;
using Rika_ProductProvier.Infrastructure.Data.Entities;

namespace Rika_ProductProvier.Infrastructure.Repositories;

public class ProductRepository(ProductDbContext context) : BaseRepository<ProductEntity>(context)
{
    private readonly ProductDbContext _context = context;
}
