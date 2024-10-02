namespace App.ProductService.API.DTOs
{
    public class ProductBaseDto
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public ProductBaseDto(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
