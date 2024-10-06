namespace App.OrderService.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; } // Linked product
        public int Quantity { get; set; } // Quantity of product
        public decimal UnitPrice { get; set; } // Price of product at the time of the order
        public decimal TotalPrice => Quantity * UnitPrice; // Derived property
    }

}
