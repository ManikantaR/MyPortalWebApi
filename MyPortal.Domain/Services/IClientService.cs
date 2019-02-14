using System.Collections.Generic;
using System.Threading.Tasks;
using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;

namespace MyPortal.Core.Services
{
    public interface IClientService
    {


        Task<Client> GetClientAsync(int id);
        Task<List<Client>> GetClientsAsync();
    }
}