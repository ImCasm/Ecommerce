using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Core.Services
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryByIdAsync(int id);
        Task<IReadOnlyList<Category>> GetAllCategoriesAsync();
    }
}
