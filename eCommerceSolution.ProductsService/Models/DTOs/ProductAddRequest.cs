namespace eCommerceSolution.ProductsService.Models.DTOs;

public record ProductAddRequest
(
    string? ProductName,
    string? Category ,
     decimal? UnitPrice ,
     int? QuantityInStock 
);
