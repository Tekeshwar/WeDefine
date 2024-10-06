using App.OrderService.Application.Interfaces;
using App.OrderService.Domain.Entities;
using App.OrderService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace App.OrderService.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {        
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<decimal> GetProductPrice(Guid productId)
        {
            // Find the product by ID and return its price
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            return product != null ? product.Price : 0;
        }

        public async Task<Order> GetOrderByIdAsync(Guid orderId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }
        public Task UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
