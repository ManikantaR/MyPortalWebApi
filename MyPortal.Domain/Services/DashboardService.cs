using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Core.Services
{
    public class DashboardService : IDashboardService
    {
        public DashboardService(IDashboardRepository repository)
        {
            Repository = repository;
        }

        private IDashboardRepository Repository { get; }

        public async Task<Dashboard> CreateDashboard(Dashboard dashboard)
        {
            dashboard.CreatedOn = DateTime.Now;
           return await Repository.AddDashboard(dashboard);
        }

        public async Task<Dashboard> GetDashboardAsync(int id)
        {
            return await Repository.GetDashboardAsync(id);
        }

        public async  Task<List<Dashboard>> GetDashboardsAsync()
        {
            return await Repository.GetDashboardsAsync();
        }
    }
}
