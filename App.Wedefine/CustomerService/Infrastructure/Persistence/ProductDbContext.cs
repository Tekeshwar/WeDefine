using App.ProductService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.ProductService.Infrastructure.Persistence
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    }
}
