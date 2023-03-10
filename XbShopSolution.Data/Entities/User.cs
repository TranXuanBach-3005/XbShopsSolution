using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbShopSolution.Data.Entities
{
    public class User:IdentityUser<Guid>
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
    }
}
