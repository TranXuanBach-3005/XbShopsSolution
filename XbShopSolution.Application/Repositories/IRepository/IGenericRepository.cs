using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbShopSolution.Application.Repositories.IRepository
{
    public interface IGenericRepository<T> where T :class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task CreateAsync(T t);
        Task CreateRangeAsync(List<T> t);
        void Update(T t);
        void Delete(T t);
    }
}
