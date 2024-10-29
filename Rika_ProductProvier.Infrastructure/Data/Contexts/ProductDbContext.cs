using Microsoft.EntityFrameworkCore;
using Rika_ProductProvier.Infrastructure.Data.Entities;

namespace Rika_ProductProvier.Infrastructure.Data.Contexts;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<ProductColorEntity> ProductColor { get; set; }
    public DbSet<ProductSizeEntity> ProductSize { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
