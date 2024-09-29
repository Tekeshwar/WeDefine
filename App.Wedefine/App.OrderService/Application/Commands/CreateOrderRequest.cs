using MediatR;

namespace App.OrderService.Application.Commands
{
    public class CreateOrderRequest:IRequest<int>
    {
        public int Id { get; private set; }
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
    }
}
