using FoodAplication.Infrastructure.Configuration;
using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodApplication.Infrastructure.Configuration
{
    public class FoodItemConfig : BaseConfig<FoodItem>
    {
        public override void Configure(EntityTypeBuilder<FoodItem> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.FoodName)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(m => m.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            builder.Property(m => m.IsAvailable)
                   .HasDefaultValue(true);
        }
    }
}



