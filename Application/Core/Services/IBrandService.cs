using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Core.Services
{
    public interface IBrandService
    {
        Task<Brand> GetBrandByIdAsync(int id);
        Task<IReadOnlyList<Brand>> GetAllBrandsAsync();
    }
}
