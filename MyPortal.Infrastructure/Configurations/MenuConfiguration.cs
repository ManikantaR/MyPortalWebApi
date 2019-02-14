using MyPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Infrastructure.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(e => e.Name).HasColumnName("Name").HasMaxLength(40);
            builder.Property(e => e.Url).HasColumnName("Url").HasMaxLength(200);
            //builder.Property(e => e.ParentMenuId)
            //        .HasColumnName("ParentMenuId")
            //        .HasDefaultValueSql("((-1))");

            builder.HasOne(p => p.ParentMenu)
                .WithMany(s => s.SubMenus)
                .HasForeignKey(f => f.ParentMenuId)
                .HasConstraintName("FK_Parent_SubMenu");
        }
    }
}
