using eCommerceSolution.ProductsService.Models.DTOs;

namespace eCommerceSolution.ProductsService.ServiceContracts;

public interface IProductsService
{
    Task<ProductResponse?> AddProduct(ProductAddRequest productAddRequest);
}
