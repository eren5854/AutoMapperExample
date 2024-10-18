namespace AutoMapperExample.DTOs;

public sealed record CreateProductDto(
    string ProductName,
    string ProductCategory,
    string? ImageUrl,
    int Quantity,
    double? Price);
