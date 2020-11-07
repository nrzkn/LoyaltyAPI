using Loyalty.Core.Domain;
using Loyalty.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Data
{
    public class LoyaltyDbContext : DbContext
    {
        public LoyaltyDbContext()
        {

        }

        #region overrided Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            modelBuilder.ApplyConfiguration(new CustomersStoresMapping());
            modelBuilder.ApplyConfiguration(new OwnerMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DHVOGDN;Database=LoyaltyDB;Trusted_Connection=True");
        }
        #endregion

        #region DbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<CustomersStores> CustomersStores { get; set; }
        public DbSet<Owner> Owners { get; set; }

        //Deneme
        #endregion
    }
}
