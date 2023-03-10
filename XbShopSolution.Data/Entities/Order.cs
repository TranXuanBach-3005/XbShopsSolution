using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Data.Enums;

namespace XbShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
        public User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
