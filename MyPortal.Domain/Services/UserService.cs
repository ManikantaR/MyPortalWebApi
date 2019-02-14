using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Core.Services
{
    public class UserService : IUserService
    {
        public UserService(IUserRepository repository)
        {
            Repository = repository;
        }

        private  IUserRepository Repository { get; }

        public async Task<List<User>> GetUsersAsync()
        {
            return await Repository.GetUsersAsync();
        }

        public async  Task<User> GetUserAsync(int id)
        {
            return await Repository.GetUserAsync(id);
        }

        public async Task<User> GetUserDashBoardsAsync(int id)
        {
            var user = await Repository.GetUserAsync(id);
              
               var dashboards = await Repository.GetUserDashBoardsAsync(id);
            user.AddDashBoards(dashboards);
            return user;
        }

    }
}
