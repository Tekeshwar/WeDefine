namespace App.OrderService.API.Models.Requests
{
    public class CreateOrderRequest
    {
        public Guid CustomerId { get; set; }
        public List<OrderItemRequest> OrderItems { get; set; } = new();
    }
}
