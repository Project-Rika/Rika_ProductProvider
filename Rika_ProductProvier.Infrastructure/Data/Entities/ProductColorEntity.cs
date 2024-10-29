namespace Rika_ProductProvier.Infrastructure.Data.Entities;

public class ProductColorEntity
{
    public int ProductColorId { get; set; }

    public string ProductColorName { get; set; } = null!;

    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
}
