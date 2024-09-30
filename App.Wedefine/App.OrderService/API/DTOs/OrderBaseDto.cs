namespace App.OrderService.API.DTOs
{
    public class OrderBaseDto
    {
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
    }
}
