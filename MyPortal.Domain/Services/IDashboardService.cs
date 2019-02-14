using System.Collections.Generic;
using System.Threading.Tasks;
using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;

namespace MyPortal.Core.Services
{
    public interface IDashboardService
    {  

        Task<List<Dashboard>> GetDashboardsAsync();
        Task<Dashboard> GetDashboardAsync(int id);
        Task<Dashboard> CreateDashboard(Dashboard dashboard);
    }
}