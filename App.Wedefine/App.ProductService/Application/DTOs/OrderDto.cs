namespace App.ProductService.Application.DTOs
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }        
        public Guid CustomerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; } = new();
    }
}
