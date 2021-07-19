using Application.Common.Specification;
using Application.Core.Repositories;
using Application.Core.Services;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<IReadOnlyList<Product>> GetAllWithSpec(ISpecification<Product> spec)
        {
            return await _productRepository.GetAllWithSpec(spec);
        }

        public async Task<Product> GetByIdWithSpec(ISpecification<Product> spec)
        {
            return await _productRepository.GetByIdWithSpec(spec);
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }
    }
}
