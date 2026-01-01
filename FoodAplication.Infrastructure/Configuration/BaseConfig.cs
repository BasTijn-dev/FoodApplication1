using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodAplication.Infrastructure.Configuration
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : Audit
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id); // Primary key

            builder.Property(e => e.CreatedOn)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .IsRequired();

            builder.Property(e => e.IsDeleted)
                   .HasDefaultValue(false);

            builder.HasQueryFilter(e => !e.IsDeleted); // Soft delete filter
        }
    }

}
