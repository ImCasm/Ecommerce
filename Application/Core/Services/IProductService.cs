using Application.Common.Specification;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Core.Services
{
    public interface IProductService
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<Product> GetByIdWithSpec(ISpecification<Product> spec);
        Task<IReadOnlyList<Product>> GetAllWithSpec(ISpecification<Product> spec);
    }
}
