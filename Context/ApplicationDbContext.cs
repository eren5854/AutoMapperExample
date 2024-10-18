using AutoMapperExample.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
