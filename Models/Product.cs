namespace AutoMapperExample.Models;

public sealed class Product
{
    public Product()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductCategory {  get; set; } = string.Empty;
    public string? ImageUrl {  get; set; }
    public int Quantity { get; set; }
    public double? Price { get; set; }
}
