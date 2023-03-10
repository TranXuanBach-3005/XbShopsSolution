﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XbShopSolution.Data.Entities;

namespace XbShopSolution.Data.FluentConfigs
{
    public class ProductInCategoryFluentConfig : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new
            {
                x.ProductId,
                x.CategoryId
            });
            builder.HasOne(x => x.Product)
                   .WithMany(x => x.ProductInCategories)
                   .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Category)
                  .WithMany(x => x.ProductInCategories)
                  .HasForeignKey(x => x.CategoryId);
        }
    }
}
