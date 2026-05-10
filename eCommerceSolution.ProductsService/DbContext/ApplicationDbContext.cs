using eCommerceSolution.ProductsService.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerceSolution.ProductsService.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
}
