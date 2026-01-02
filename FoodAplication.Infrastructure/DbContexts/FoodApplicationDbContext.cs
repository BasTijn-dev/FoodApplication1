using FoodApplication.Domain.Entities;
using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodAplication.Infrastructure.DbContexts;


    public class FoodApplicationDbContext : DbContext
    {
        public FoodApplicationDbContext(DbContextOptions<FoodApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DeliverySystem> DeliverySystems { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(
                typeof(FoodApplicationDbContext).Assembly);
        }
    }


