using System;
using System.Collections.Generic;
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
    public class UsersController : ControllerBase
    {
        public UsersController(IUserService userService, IMapper mapper)
        {
            UserService = userService;
            Mapper = mapper;
        }

        public IUserService UserService { get; }
        public IMapper Mapper { get; }
        [HttpGet("")]
        public async Task<IActionResult> GetUsersAsync()
        {
            var users = await UserService.GetUsersAsync();
            return Ok(Mapper.Map<List<UserDetailDto>>(users));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserAsync(int id,bool includeDashboards=false)
        {
            var user = await UserService.GetUserAsync(id);
            return Ok(Mapper.Map<UserDetailDto>(user));
        }

      

    }
}