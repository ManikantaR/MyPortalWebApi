using System.Collections.Generic;
using System.Threading.Tasks;
using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;

namespace MyPortal.Core.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int id);
        Task<User> GetUserDashBoardsAsync(int id);
        Task<List<User>> GetUsersAsync();
    }
}