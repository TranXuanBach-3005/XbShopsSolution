using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Application.Repositories.IRepository;
using XbShopSolution.Data.EF;

namespace XbShopSolution.Application.Repositories.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T :class
    {
        protected DbSet<T> _dbSet;

        public GenericRepository(xbSolutionDbContext context)
        {
            _dbSet = context.Set<T>();
        }

        public async Task CreateAsync(T t)
        {
            await _dbSet.AddAsync(t);
        }

        public async Task CreateRangeAsync(List<T> t)
        {
            await _dbSet.AddRangeAsync(t);
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
        }

        public async Task<List<T>> GetAllAsync()
        {
          return  await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
           return await _dbSet.FindAsync(Id);
        }

        public void Update(T t)
        {
            _dbSet.Update(t);
        }
    }
}
