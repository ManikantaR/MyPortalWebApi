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
    public class ClientRepository : IClientRepository
    {
        public ClientRepository(MyPortalDbContext context) => Context = context;

        public MyPortalDbContext Context { get; }

        public Task<Client> GetClientAsync(int id)
        {
            return Context.Clients.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
              

        public Task<List<Client>> GetClientsAsync()
        {
            return Context.Clients.ToListAsync();
        }
    }
}
