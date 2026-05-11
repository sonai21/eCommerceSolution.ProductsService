using eCommerceSolution.ProductsService.Models.Entities;

namespace eCommerceSolution.ProductsService.RepositoryContracts;

public interface IProductsRepository
{
    Task<Product?> AddProduct(Product product);
    Task<IEnumerable<Product>> GetAllProducts();
}
