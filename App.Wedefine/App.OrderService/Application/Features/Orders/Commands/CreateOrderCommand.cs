using App.OrderService.API.Models.Requests;
using App.OrderService.API.Models.Responses;
using App.OrderService.Application.Interfaces;
using App.OrderService.Domain.Entities;
using MediatR;

namespace App.OrderService.Application.Features.Orders.Commands
{
    public class CreateOrderCommand : IRequest<CreateOrderResponse>
    {
        public CreateOrderRequest OrderRequest { get; set; }

        public class Handler : IRequestHandler<CreateOrderCommand, CreateOrderResponse>
        {
            private readonly IOrderRepository _orderRepository;

            public Handler(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            public async Task<CreateOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    OrderDate = DateTime.UtcNow,
                    CustomerId = request.OrderRequest.CustomerId,
                    OrderItems = await GetOrderItemsAsync(request),
                };

                await _orderRepository.AddAsync(order);
                return new CreateOrderResponse
                {
                    OrderId = order.Id,
                    OrderNumber = order.OrderNumber,
                    OrderDate = order.OrderDate
                };
            }

            #region private            
            private async Task<List<OrderItem>> GetOrderItemsAsync(CreateOrderCommand request)
            {
                var tasks = request.OrderRequest.OrderItems.Select(async item => new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = await _orderRepository.GetProductPrice(item.ProductId)
                }).ToList();

                var orderItemsArray = await Task.WhenAll(tasks);  // Returns OrderItem[]

                return orderItemsArray.ToList();  // Converts array to List<OrderItem>
            }

            #endregion
        }
    }
}
