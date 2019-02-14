using MyPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortal.Infrastructure.Data
{
    public class MyPortalDbContext:DbContext
    {
        public MyPortalDbContext(DbContextOptions<MyPortalDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<UserDashBoards> UserDashBoards { get; set; }
        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyPortalDbContext).Assembly);
        }
    }
}
