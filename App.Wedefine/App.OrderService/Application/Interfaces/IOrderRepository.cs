using App.OrderService.Domain.Entities;

namespace App.OrderService.Application.Interfaces
{
    public interface IOrderRepository
    {
       Task AddAsync(Order order);
    }
}
