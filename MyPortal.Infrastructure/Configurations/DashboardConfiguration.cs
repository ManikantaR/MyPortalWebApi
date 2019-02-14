using MyPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Infrastructure.Configurations
{
    public class DashboardConfiguration : IEntityTypeConfiguration<Dashboard>
    {
        public void Configure(EntityTypeBuilder<Dashboard> builder)
        {
            builder.Property(e => e.Name)
                .HasColumnName("Name").IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasColumnName("Description")
                .HasMaxLength(1000);
        }
    }
}
