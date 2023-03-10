using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;
using XbShopSolution.Data.Entities;

namespace XbShopSolution.Application.Repositories.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(xbSolutionDbContext context) : base(context)
        {
        }
    }
}
