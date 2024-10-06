using App.OrderService.Domain.Entities;

namespace App.OrderService.API.Models.Responses
{
    public class GetOrderResponse
    {     
        public string OrderNumber { get; set; }  
        public DateTime OrderDate { get; set; }  
        public decimal TotalAmount { get; set; } 
        public string CustomerName { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
