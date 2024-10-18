namespace AutoMapperExample.DTOs;

public sealed record UpdateProductDto(
    Guid Id,
    string ProductName,
    string ProductCategory,
    string? ImageUrl,
    int Quantity,
    double? Price);
