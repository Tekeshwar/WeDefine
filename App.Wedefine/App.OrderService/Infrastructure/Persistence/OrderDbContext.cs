using App.OrderService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.OrderService.Infrastructure.Persistence
{
    public class OrderDbContext :DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }
    }
}
