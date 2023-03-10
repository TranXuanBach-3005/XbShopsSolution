using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;
using XbShopSolution.Data.Entities;


namespace XbShopSolution.Application.Repositories.Repository
{
    public class ProductInCategoryRepository : GenericRepository<ProductInCategory>, IProductInCategoryRepository
    {
        public ProductInCategoryRepository(xbSolutionDbContext context) : base(context)
        {
        }
    }
}
