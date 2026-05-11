using eCommerceSolution.ProductsService.DbContext;
using eCommerceSolution.ProductsService.Models.Entities;
using eCommerceSolution.ProductsService.RepositoryContracts;

namespace eCommerceSolution.ProductsService.Repositories;

public class ProductsRepository : IProductsRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    public ProductsRepository(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public async Task<Product?> AddProduct(Product product)
    {
        product.ProductId = Guid.NewGuid();

         _applicationDbContext.Add(product);
       var numOfRowAffected = await _applicationDbContext.SaveChangesAsync();
        if(numOfRowAffected > 0)
        {
            return product;
        }
        else
        {
            return null;
        }
    }
}
