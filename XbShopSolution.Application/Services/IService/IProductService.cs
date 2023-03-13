using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.ViewModel.ViewModel.Products;

namespace XbShopSolution.Application.Services.IService
{
    public interface IProductService
    {
        Task<int> CreateProductAsync(ProductCreateViewModel model);
    }
}
