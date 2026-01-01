using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodAplication.Infrastructure.Configuration
{
    public class AddressConfig : BaseConfig<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.CustomerAddress).IsRequired().HasMaxLength(100);
            builder.Property(a => a.City).IsRequired().HasMaxLength(150);
            builder.Property(a => a.State).IsRequired().HasMaxLength(150);
            builder.Property(a => a.Country).IsRequired().HasMaxLength(150);

            builder.HasOne(a => a.Customer)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(a => a.CustomerId);
        }
    }

}
