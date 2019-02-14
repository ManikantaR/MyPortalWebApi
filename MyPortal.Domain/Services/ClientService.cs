using MyPortal.Core.Entities;
using MyPortal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Core.Services
{
    public class ClientService : IClientService
    {
        public ClientService(IClientRepository repository)
        {
            Repository = repository;
        }

        private IClientRepository Repository { get; }

        public async Task<List<Client>> GetClientsAsync()
        {
            return await Repository.GetClientsAsync();
        }


        public async Task<Client> GetClientAsync(int id)
        {
            return await Repository.GetClientAsync(id);
        }
    }
}
