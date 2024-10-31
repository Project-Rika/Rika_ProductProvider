﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rika_ProductProvier.Infrastructure.Data.Entities;

public class ProductEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string ProductName { get; set; } = null!;
    public decimal ProductPrice { get; set; } = 0;
    public decimal ProductSalePrice { get; set; } = 0;
    public string ProductDescription { get; set; } = null!;
    public int ProductCategoryId { get; set; }

    public int ProductSizeId { get; set; }
    public ProductSizeEntity ProductSize { get; set; } = null!;
    
    public int? ProductColorId { get; set; }
    public ProductColorEntity? ProductColor { get; set; }
}