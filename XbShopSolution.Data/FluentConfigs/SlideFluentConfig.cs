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
    public class SlideFluenConfig : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("Slides");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).UseIdentityColumn();
            builder.Property(n => n.Name).HasMaxLength(200).IsRequired();
            builder.Property(n => n.Description).HasMaxLength(200).IsRequired();
            builder.Property(n => n.Url).HasMaxLength(200).IsRequired();
            builder.Property(n => n.Image).HasMaxLength(200).IsRequired();
        }
    }
}
