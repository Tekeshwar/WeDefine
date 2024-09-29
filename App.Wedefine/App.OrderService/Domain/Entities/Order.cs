namespace App.OrderService.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
         
    }
}
