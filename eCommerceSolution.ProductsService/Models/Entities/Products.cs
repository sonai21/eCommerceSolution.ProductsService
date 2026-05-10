namespace eCommerceSolution.ProductsService.Models.Entities;

public class Products
{
    public Guid ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? Category { get; set; }
    public decimal? UnitPrice { get; set; }
    public int? QuantityInStock {  get; set; } 
}
