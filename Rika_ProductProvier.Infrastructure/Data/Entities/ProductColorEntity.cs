namespace Rika_ProductProvier.Infrastructure.Data.Entities;

public class ProductColorEntity
{
    public int Id { get; set; }

    public string ColorName { get; set; } = null!;

    public ICollection<ProductEntity> Products { get; set; } = new List<ProductEntity>();
}
