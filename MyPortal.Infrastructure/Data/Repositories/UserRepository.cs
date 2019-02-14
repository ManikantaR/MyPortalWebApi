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
    public class UserRepository : IUserRepository
    {

        public UserRepository(MyPortalDbContext context) => Context = context;

        public MyPortalDbContext Context { get; }

        public Task<User> GetUserAsync(int id)
        {
            return Context.Users.Where(u => u.Id == id).SingleOrDefaultAsync();
        }

        public Task<List<Dashboard>> GetUserDashBoardsAsync(int id)
        {

            return Context.UserDashBoards.Where(u => u.UserId == id).
                Select(t=>t.Dashboard).ToListAsync();
        }

        public Task<List<User>> GetUsersAsync()
        {
            return Context.Users.ToListAsync();
        }
    }
}
