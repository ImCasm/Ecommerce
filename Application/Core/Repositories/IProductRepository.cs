using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
    }
}
