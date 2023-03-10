using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Application.Repositories.IRepository;

namespace XbShopSolution.Application.UnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        public IProductRepository ProductRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IProductImageRepository ProductImageRepository { get; }
        public IProductInCategoryRepository ProductInCategoryRepository { get; }
        public IUserRepository UserRepository { get; }
        public ISlideRepository SlideRepository { get; }
        void Save();
        Task<int> SavesChangeAsync();
        void BeginTransaction();
        void Commit();
    }
}
