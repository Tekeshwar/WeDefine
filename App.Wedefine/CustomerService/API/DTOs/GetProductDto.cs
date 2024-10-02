namespace App.ProductService.API.DTOs
{
    public class GetProductDto : ProductBaseDto
    {
        public GetProductDto(string name, decimal price) : base(name, price) { }

        public int Id { get; set; }
    }
}
