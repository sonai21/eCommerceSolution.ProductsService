using eCommerceSolution.ProductsService.DbContext;
using eCommerceSolution.ProductsService.Models.Entities;
using eCommerceSolution.ProductsService.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

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
    public async Task<Product?> GetProductById(Guid productId)
    {
        var result = await _applicationDbContext.Products.FindAsync(productId);
        return result;
    }
    public async Task<Product?> DeleteProduct(Guid productId)
    {
       var result = await GetProductById(productId);
        if(result == null)
        {
            return null;
        }
        _applicationDbContext.Products.Remove(result);
        await _applicationDbContext.SaveChangesAsync();
        return result;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        IEnumerable<Product> allProducts = await _applicationDbContext.Products.ToListAsync();
        return allProducts;
    }

    
}
