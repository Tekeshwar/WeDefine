///using App.ProductService.Application.DTOs;
using App.OrderService.API.Models.Responses;
using MediatR;

namespace App.OrderService.Application.Features.Orders.Query
{
    public class GetOrderByIdQuery:IRequest<GetOrderResponse>
    {
        public Guid OrderId { get; set; }

        public GetOrderByIdQuery(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
