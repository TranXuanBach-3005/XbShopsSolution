using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;

namespace XbShopSolution.Application.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly xbSolutionDbContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductImageRepository _productImageRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISlideRepository _slideRepository;
        private readonly IProductInCategoryRepository _productInCategoryRepository;

        public UnitOfWork(xbSolutionDbContext context, IProductRepository productRepository,
                                                     IProductImageRepository productImageRepository,
                                                     IUserRepository userRepository,
                                                     ICategoryRepository categoryRepository,
                                                     IProductInCategoryRepository productInCategoryRepository,
                                                     ISlideRepository slideRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _productImageRepository = productImageRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
            _productInCategoryRepository = productInCategoryRepository;
            _slideRepository = slideRepository;
        }

        public IProductRepository ProductRepository { get => _productRepository; }
        public IProductImageRepository ProductImageRepository { get => _productImageRepository; }

        public IUserRepository UserRepository { get => _userRepository; }

        public ICategoryRepository CategoryRepository { get => _categoryRepository; }

        public IProductInCategoryRepository ProductInCategoryRepository { get => _productInCategoryRepository; }

        public ISlideRepository SlideRepository { get => _slideRepository; }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SavesChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
