using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Data.Enums;

namespace XbShopSolution.ViewModel.ViewModel.Products
{
    public class ProductUpdateViewModel
    {
        public string Name { get; set; }
        public bool? IsFeatured { get; set; }
        public string Description { set; get; }
        public string Details { set; get; }
        public Status Status { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyword { get; set; }
        public string MetaTitle { get; set; }
        public IFormFile ProductslImage { get; set; }
    }
}
