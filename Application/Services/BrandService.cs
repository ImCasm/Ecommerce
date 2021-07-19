using Application.Core.Repositories;
using Application.Core.Services;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly IGenericRepository<Brand> _repository;

        public BrandService(IGenericRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyList<Brand>> GetAllBrandsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
