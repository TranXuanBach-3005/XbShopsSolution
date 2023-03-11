using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbShopSolution.ViewModel.ViewModel.Products
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginaPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyword { get; set; }
        public string MetaTitle { get; set; }
        public bool? IsFeatured { get; set; }
        public string ProductslImage { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
    }
}
