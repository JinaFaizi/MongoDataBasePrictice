using ProductCatalog.Core.Entities;

namespace ProductCatalog.Core.Interfaces;

public interface IProductService
{
    Task<Product> GetProductByIdAsync(int id);
    Task<List<Product>> GetProductsAsync();
    Task<Product> CreateProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);
    Task<Product> DeleteProductAsync(Product product);
    Task<List<Product>> GetProductsByCategoryIdAsync(string category);
}