using eCommerceSolution.ProductsService.Models.Entities;

namespace eCommerceSolution.ProductsService.RepositoryContracts;

public interface IProductsRepository
{
    Task<Product?> AddProduct(Product product);
    Task<IEnumerable<Product>> GetAllProducts();

    Task<Product?> GetProductById(Guid productId);

    Task<Product?> DeleteProduct(Guid productId);
}
