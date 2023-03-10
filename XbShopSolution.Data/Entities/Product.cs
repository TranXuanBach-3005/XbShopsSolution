using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Data.Abstract;
using XbShopSolution.Data.Enums;

namespace XbShopSolution.Data.Entities
{
    public class Product:Auditable
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginaPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public bool? IsFeatured { get; set; }
        public Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set;}
        public List<ProductImage> ProductImages { get; set;}
        public List<OrderDetail> OrderDetails { get; set;}
        public List<Cart> Carts { get; set; }
    }
}
