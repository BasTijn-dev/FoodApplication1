using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodApplication.Domain.Entities;

namespace FoodAplication.Infrastructure.Configuration
{
    public class TheCustomerAddressConfig : BaseConfig<Address>
    {
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.CustomerAddress).IsRequired().HasMaxLength(100);
            builder.Property(c => c.City).IsRequired().HasMaxLength(180);
            builder.Property(c => c.State).IsRequired().HasMaxLength(180);
            builder.Property(c => c.Country).IsRequired().HasMaxLength(180);
            builder.HasOne(a => a.CustomerId)
                .WithOne(a => a.CustomerAddressId)
                .HasForeignKey<FoodApplication.Domain.Entities.Address>(a => a.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
    }
}
