using MyPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<List<Dashboard>> GetUserDashBoardsAsync(int id);
    }
}
