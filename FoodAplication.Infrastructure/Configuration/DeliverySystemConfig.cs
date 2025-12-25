using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodAplication.Infrastructure.Configuration
{
    public class DeliverySystemConfig : BaseConfig<FoodApplication.Domain.Entities.DeliverySystem>
    {
        public override void Configure(EntityTypeBuilder<DeliverySystem> builder)
        {

            base.Configure(builder);
            builder.Property(d => d.DispatchRiderName).IsRequired().HasMaxLength(100);
            builder.Property(d => d.DeliveryDate).IsRequired();
            builder.Property(d => d.Status).IsRequired().HasMaxLength(50);
            builder.HasOne(d => d.FoodOrders)
                .WithMany()
                .HasForeignKey("OrderId")
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
        }
    }
}
