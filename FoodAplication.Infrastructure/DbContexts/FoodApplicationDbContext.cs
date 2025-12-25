using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodAplication.Infrastructure.DbContexts;

    public class FoodApplicationDbContext : DbContext
    {

        public FoodApplicationDbContext(DbContextOptions<FoodApplicationDbContext> options = null) : base(options)
        {


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> CustomersAddress { get; set; }
        public DbSet<List> Foods { get; set; }
        public DbSet<DeliverySystem> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new Configuration.CustomerConfig());
            builder.ApplyConfiguration(new Configuration.AddressConfig());
            builder.ApplyConfiguration(new Configuration.DeliverySystemConfig());
        }
    }
