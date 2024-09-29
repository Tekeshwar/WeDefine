using App.ProductService.Domain.Entities;

namespace App.ProductService.Application.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
    }
}
