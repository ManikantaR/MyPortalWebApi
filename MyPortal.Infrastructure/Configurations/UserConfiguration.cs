using MyPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.FirstName).IsRequired()
               .HasMaxLength(60);

            builder.Property(e => e.LastName)
               .HasMaxLength(60);

            builder.Property(e => e.BirthDate).HasColumnType("datetime");

            builder.Property(e => e.Phone).HasMaxLength(11);

            builder.Property(e => e.ClientId).HasColumnName("ClientId");

            builder.HasOne(e => e.Client)
                .WithMany(d => d.Users)
                .HasForeignKey(e => e.ClientId)
                .HasConstraintName("FK_Users_Clients");
        }
    }
}
