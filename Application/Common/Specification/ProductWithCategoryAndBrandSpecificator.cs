using Domain.Entities;

namespace Application.Common.Specification
{
    public class ProductWithCategoryAndBrandSpecificator : Specification<Product>
    {
        public ProductWithCategoryAndBrandSpecificator()
        {
            AddInclude(p => p.Category);
            AddInclude(p => p.Brand);
        }

        public ProductWithCategoryAndBrandSpecificator(int id) : base(x => x.Id == id)
        {
            AddInclude(p => p.Category);
            AddInclude(p => p.Brand);
        }
    }
}
