using eCommerceSolution.ProductsService.Models.DTOs;

namespace eCommerceSolution.ProductsService.ServiceContracts;

public interface IProductsService
{
    Task<ProductResponse?> AddProduct(ProductAddRequest productAddRequest);
    Task<IEnumerable<ProductResponse>> GetAllProducts();

    Task<ProductResponse?> GetProductById(Guid productId);

    Task<ProductResponse?> DeleteProduct(Guid productId);
}
