using App.ProductService.Application.Interfaces;
using App.ProductService.Domain.Entities;
using App.ProductService.Infrastructure.Persistence;

namespace App.ProductService.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext dbContext) { _context = dbContext; }
        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}
