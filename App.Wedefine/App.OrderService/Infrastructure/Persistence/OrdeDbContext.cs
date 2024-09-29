using App.OrderService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.OrderService.Infrastructure.Persistence
{
    public class OrdeDbContext :DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrdeDbContext(DbContextOptions<OrdeDbContext> options) : base(options) { }
    }
}
