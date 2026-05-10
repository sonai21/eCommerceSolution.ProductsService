namespace eCommerceSolution.ProductsService.Models.DTOs;

public record ProductResponse(
    Guid ProductId,
    string? ProductName,
    string? Category,
     decimal? UnitPrice,
     int? QuantityInStock
    );

