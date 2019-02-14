using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyPortal.Core.Services;
using MyPortal.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyPortal.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        public ClientsController(IClientService clientService,IMapper mapper)
        {
            ClientService = clientService;
            Mapper = mapper;
        }

        public bool ClientsDto { get; private set; }
        private IClientService ClientService { get; }
        public IMapper Mapper { get; }

        [HttpGet("")]
       public async Task<IActionResult> GetClients()
        {
            var clients = await ClientService.GetClientsAsync();
          
            return Ok(Mapper.Map<List<ClientDto>>(clients));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var client = await ClientService.GetClientAsync(id);

            return Ok(Mapper.Map<ClientDto>(client));
        }
    }
}