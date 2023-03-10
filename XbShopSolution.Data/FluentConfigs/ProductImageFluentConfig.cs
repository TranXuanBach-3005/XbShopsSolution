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
    public class ProductImageFluentConfig : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).UseIdentityColumn();
            builder.Property(n => n.Caption).IsRequired();
            builder.Property(n => n.ImagePath).IsRequired();
            builder.HasOne(p => p.Product)
                   .WithMany(pi => pi.ProductImages)
                   .HasForeignKey(p => p.ProductId);
        }
    }
}
