namespace Rika_ProductProvier.Infrastructure.Data.Entities;

public class ProductSizeEntity
{
    public int ProductSizeId { get; set; }
    public string ProductSizeName { get; set; } = null!;
    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
}
