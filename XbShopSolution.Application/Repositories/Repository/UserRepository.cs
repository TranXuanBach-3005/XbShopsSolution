using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;
using XbShopSolution.Data.Entities;


namespace XbShopSolution.Application.Repositories.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(xbSolutionDbContext context) : base(context)
        {
        }
    }
}
