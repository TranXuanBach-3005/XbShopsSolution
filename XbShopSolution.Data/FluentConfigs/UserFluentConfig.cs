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
    public class UserFluentConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(n => n.LastName).IsRequired();
            builder.Property(n => n.FistName).IsRequired();
            builder.Property(n => n.BirthDay).IsRequired();
        }
    }
}
