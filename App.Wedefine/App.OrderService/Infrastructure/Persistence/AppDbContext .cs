using App.OrderService.Domain.Entities;
using App.ProductService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.OrderService.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
