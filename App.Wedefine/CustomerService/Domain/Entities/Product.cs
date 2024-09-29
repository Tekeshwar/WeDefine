namespace App.ProductService.Domain.Entities
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void UpdateProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
