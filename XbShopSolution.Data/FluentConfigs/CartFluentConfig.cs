using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Data.Entities;

namespace XbShopSolution.Data.FluentConfigs
{
    public class CartFluentConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).UseIdentityColumn();
            builder.Property(n => n.Price).IsRequired();
            builder.Property(n => n.Quantity).IsRequired();
            builder.HasOne(p => p.Product)
                   .WithMany(c => c.Carts)
                   .HasForeignKey(p => p.ProductId);
            builder.HasOne(u => u.User)
                   .WithMany(c => c.Carts)
                   .HasForeignKey(u => u.UserId);
        }
    }
}
