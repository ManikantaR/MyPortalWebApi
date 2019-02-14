using MyPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Infrastructure.Configurations
{
    class UserDashBoardConfiguration : IEntityTypeConfiguration<UserDashBoards>
    {
        public void Configure(EntityTypeBuilder<UserDashBoards> builder)
        {
            builder.Property(e => e.UserId)
                .HasColumnName("UserId");

            builder.Property(e => e.DashboardId).HasColumnName("DashboardId");

            builder.HasOne(e => e.Dashboard).WithMany(u => u.DashboardUsers).HasForeignKey(u => u.DashboardId)
           .HasConstraintName("FK_Dashboard_Users");

            builder.HasOne(e => e.User).WithMany(u => u.UserDashboards).HasForeignKey(u => u.UserId)
                .HasConstraintName("FK_User_UDashboards");

            
        }
    }
}
