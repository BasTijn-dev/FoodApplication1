using FoodAplication.Infrastructure.Configuration;
using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DeliverySystemConfig : BaseConfig<DeliverySystem>
{
    public override void Configure(EntityTypeBuilder<DeliverySystem> builder)
    {
        base.Configure(builder);

        builder.Property(d => d.DispatchRiderName).IsRequired().HasMaxLength(100);
        builder.Property(d => d.Status).IsRequired().HasMaxLength(50);
        builder.Property(d => d.DeliveryDate).IsRequired();

        builder.HasOne(d => d.Order)
               .WithOne(o => o.DeliverySystem)
               .HasForeignKey<DeliverySystem>(d => d.OrderId);
    }
}


