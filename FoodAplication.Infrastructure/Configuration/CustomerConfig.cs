using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodAplication.Infrastructure.Configuration
{
    public class CustomerConfig : BaseConfig<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.EmailAddress).IsRequired().HasMaxLength(200);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(15);

            builder.HasMany(c => c.Addresses)
                   .WithOne(a => a.Customer)
                   .HasForeignKey(a => a.CustomerId);

            builder.HasMany(c => c.Orders)
                   .WithOne(o => o.Customer)
                   .HasForeignKey(o => o.CustomerId);
        }
    }


}
