using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Data.Entities;
using XbShopSolution.ViewModel.ViewModel.Products;

namespace XbShopSolution.ViewModel.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ProductCreateViewModel, Product>();
        }
    }
}
