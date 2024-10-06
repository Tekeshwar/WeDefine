using App.ProductService.Domain.Entities;

namespace App.ProductService.Application.Interfaces
{
    public interface IProductRepository
    {
        //Task AddProductAsync(Product order);
        //Task GetProductAsync(string productId);

        Task AddAsync(Product product);
        Task<Product> GetByIdAsync(Guid productId);
        Task<IEnumerable<Product>> GetAllAsync();
        Task UpdateAsync(Product product);
        Task DeleteAsync(Guid productId);

    }
}
