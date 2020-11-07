using Loyalty.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loyalty.Data.Mapping
{
    public class CustomersStoresMapping : IEntityTypeConfiguration<CustomersStores>
    {
        public void Configure(EntityTypeBuilder<CustomersStores> builder)
        {
            builder.HasKey(x => new { x.CustomerId, x.StoreId });

            builder.HasOne<Customer>(x => x.Customer)
                .WithMany(x => x.CustomersStores)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne<Store>(x => x.Store)
                .WithMany(x => x.CustomersStores)
                .HasForeignKey(x => x.StoreId);
        }
    }
}
