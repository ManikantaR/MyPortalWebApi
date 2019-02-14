using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Infrastructure.Data.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        public DashboardRepository(MyPortalDbContext context) => Context = context;

        public MyPortalDbContext Context { get; }

        public async Task<Dashboard> AddDashboard(Dashboard dashboard)
        {
            Context.Dashboards.Add(dashboard);
            await Context.SaveChangesAsync();
            return dashboard;
        }

        public async Task<Dashboard> GetDashboardAsync(int id)
        {
            return await Context.Dashboards.Where(d => d.Id == id).SingleOrDefaultAsync();
        }

        public async Task<List<Dashboard>> GetDashboardsAsync()
        {
           
                return await Context.Dashboards.ToListAsync();
           
        }
    }
}
