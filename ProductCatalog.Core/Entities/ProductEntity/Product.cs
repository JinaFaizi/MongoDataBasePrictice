using ProductCatalog.Core.Entities.EntityBase;

namespace ProductCatalog.Core.Entities;

public class Product : ProductEntityBase<int>
{
    public string? ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public string? ProductCategory { get; set; }
}