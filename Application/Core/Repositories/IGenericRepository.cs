using Application.Common.Specification;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Core.Repositories
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(object id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);
    }
}
