using eCommerceSolution.ProductsService.Models.DTOs;
using eCommerceSolution.ProductsService.Models.Entities;
using eCommerceSolution.ProductsService.RepositoryContracts;
using eCommerceSolution.ProductsService.ServiceContracts;

namespace eCommerceSolution.ProductsService.Services;

public class ProductsService : IProductsService
{
    private readonly IProductsRepository _productsRepository;

    public ProductsService(IProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }
    public async Task<ProductResponse?> AddProduct(ProductAddRequest productAddRequest)
    {
        Product addProductData = new Product()
        {
            ProductName = productAddRequest.ProductName,
            UnitPrice = productAddRequest.UnitPrice,
            Category = productAddRequest.Category,
            QuantityInStock = productAddRequest.QuantityInStock
        };

        var result = await _productsRepository.AddProduct(addProductData);
        if (result != null)
        {
            return new ProductResponse()
            {
                ProductId = result.ProductId,
                ProductName = result.ProductName,
                UnitPrice = result.UnitPrice,
                Category = result.Category,
                QuantityInStock = result.QuantityInStock
            };

        }
        else
        {
            return null;
        }
    }

    public async Task<IEnumerable<ProductResponse>> GetAllProducts()
    {
        IEnumerable<Product> allProducts = await _productsRepository.GetAllProducts();
        IEnumerable<ProductResponse> productResponses = allProducts.Select(item => new ProductResponse()
        {
            ProductId = item.ProductId,
            ProductName = item.ProductName,
            UnitPrice = item.UnitPrice,
            Category = item.Category,
            QuantityInStock = item.QuantityInStock
        });
        return productResponses;
    }
}
