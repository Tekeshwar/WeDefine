using App.OrderService.API.Enums;

namespace App.OrderService.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } // Unique identifier
        public string OrderNumber { get; set; } // Unique order number
        public DateTime OrderDate { get; set; } // When the order was placed
        public decimal TotalAmount { get; set; } // Total price
        public Guid CustomerId { get; set; } // Customer who placed the order

        // Navigation properties
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
