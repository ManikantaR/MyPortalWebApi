using MyPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Core.Repositories
{
    public interface IDashboardRepository
    {
        Task<List<Dashboard>> GetDashboardsAsync();
        Task<Dashboard> GetDashboardAsync(int id);
        Task<Dashboard> AddDashboard(Dashboard dashboard);
    }
}
