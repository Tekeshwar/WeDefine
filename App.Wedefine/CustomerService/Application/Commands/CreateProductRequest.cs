using MediatR;

namespace App.ProductService.Application.Commands
{
    public class CreateProductRequest : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
