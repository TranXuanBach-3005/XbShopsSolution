using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;
using XbShopSolution.Data.Entities;


namespace XbShopSolution.Application.Repositories.Repository
{
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(xbSolutionDbContext context) : base(context)
        {
        }
    }
}
