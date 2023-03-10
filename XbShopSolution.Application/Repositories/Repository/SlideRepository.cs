using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;
using XbShopSolution.Data.Entities;


namespace XbShopSolution.Application.Repositories.Repository
{
    public class SlideRepository : GenericRepository<Slide>, ISlideRepository
    {
        public SlideRepository(xbSolutionDbContext context) : base(context)
        {
        }
    }
}
