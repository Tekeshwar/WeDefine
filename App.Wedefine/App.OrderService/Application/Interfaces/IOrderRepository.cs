using App.OrderService.Domain.Entities;

namespace App.OrderService.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task<Order> GetByIdAsync(Guid orderId);
        Task<IEnumerable<Order>> GetAllAsync();
        Task UpdateAsync(Order order);
        Task DeleteAsync(Guid orderId);
        Task<decimal> GetProductPrice(Guid productId);
        Task<Order> GetOrderByIdAsync(Guid orderId);
    }
}
