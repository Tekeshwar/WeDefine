using App.OrderService.Application.Interfaces;
using App.OrderService.Domain.Entities;
using MediatR;

namespace App.OrderService.Application.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderRequest, int>
    {
        private readonly IOrderRepository _orderRepository;
        public CreateOrderCommandHandler(IOrderRepository orderRepository) 
        {
            _orderRepository = orderRepository;
        }

        public async Task<int> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {

            Order order = new Order
            {
                ProductName = request.ProductName,
                Price = request.Price
            };

            await  _orderRepository.AddAsync(order);
            return order.Id;
        }
        
    }
}
