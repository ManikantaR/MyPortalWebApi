using MyPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Infrastructure.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.StreetAddress)
              .HasMaxLength(100);

            builder.Property(e => e.State)
              .HasMaxLength(30);

            builder.Property(e => e.Phone)
              .HasMaxLength(11);

            builder.Property(e => e.PinCode)
            .HasMaxLength(6);

        }
    }
}
