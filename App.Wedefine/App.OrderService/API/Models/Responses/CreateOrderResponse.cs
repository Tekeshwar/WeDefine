namespace App.OrderService.API.Models.Responses
{
    public class CreateOrderResponse
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }

}
