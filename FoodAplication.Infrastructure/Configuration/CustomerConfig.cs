using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodAplication.Infrastructure.Configuration
{
    public class TheCustomerConfig : BaseConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.EmailAddress).IsRequired().HasMaxLength(200);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(15);

            builder.HasMany(ca => ca.CustomerAddress).WithOne().HasForeignKey(ca => ca.CreatedBy);
            builder.HasMany(da => da.Delivery).WithOne().HasForeignKey(da => da.CreatedBy);
            builder.HasMany(fa => fa.FoodOrders).WithOne().HasForeignKey(fa => fa.CreatedBy);
        }
    }
}
