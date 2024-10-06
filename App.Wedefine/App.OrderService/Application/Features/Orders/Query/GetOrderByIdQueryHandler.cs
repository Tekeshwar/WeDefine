using App.OrderService.API.Models.Responses;
using App.OrderService.Application.Interfaces;
using App.OrderService.Domain.Entities;
using App.ProductService.Application.DTOs;
using MediatR;

namespace App.OrderService.Application.Features.Orders.Query
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, GetOrderResponse>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<GetOrderResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            // Fetch the order by ID, including order items
            var order = await _orderRepository.GetOrderByIdAsync(request.OrderId);

            

            // Map the domain order to GetOrderResponse DTO
            var orderDto = new GetOrderResponse
            {
                OrderNumber = order.OrderNumber,
                TotalAmount = order.TotalAmount,
                CustomerName = "",  // You can populate this field if customer data is available
                OrderDate = order.OrderDate,
                OrderItems = order.OrderItems.Select(item => new OrderItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                }).ToList()
            };

            return orderDto;
        }
    }

}
