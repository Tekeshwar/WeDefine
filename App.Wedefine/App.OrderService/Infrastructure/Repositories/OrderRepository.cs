using App.OrderService.Application.Interfaces;
using App.OrderService.Domain.Entities;
using App.OrderService.Infrastructure.Persistence;

namespace App.OrderService.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _orderDbContext;
        public OrderRepository(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public async Task AddAsync(Order order)
        {
            _orderDbContext.Orders.Add(order);
            await _orderDbContext.SaveChangesAsync();
        }
    }
}
