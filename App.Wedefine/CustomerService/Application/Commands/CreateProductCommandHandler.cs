using App.ProductService.Application.Interfaces;
using App.ProductService.Domain.Entities;
using MediatR;
using System.Reflection.Metadata;

namespace App.ProductService.Application.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductRequest, int>
    {
         private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateProductRequest request,CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price);
            await _repository.AddAsync(product);
            return product.Id;
        }        
    }
}
