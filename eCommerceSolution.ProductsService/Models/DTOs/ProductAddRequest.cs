using System.ComponentModel.DataAnnotations;

namespace eCommerceSolution.ProductsService.Models.DTOs;

public class ProductAddRequest
{
    [Required(ErrorMessage = "Product name is required.")]
    public string? ProductName { get; set; }

    public string? Category { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? QuantityInStock { get; set; }
}