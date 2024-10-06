using App.ProductService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace App.ProductService.Infrastructure.Persistance
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> products) : base(products) { }

        public DbSet<Product> Products { get; set; }

    }
}
