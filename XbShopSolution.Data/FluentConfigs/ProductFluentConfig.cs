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
    public class ProductFluentConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.SeoAlias).IsRequired(false);
            builder.Property(x => x.ViewCount).HasDefaultValue(0);
        }
    }
}
