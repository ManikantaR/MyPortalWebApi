using MyPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Core.Repositories
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClientsAsync();
        Task<Client> GetClientAsync(int id);
        
    }
}
