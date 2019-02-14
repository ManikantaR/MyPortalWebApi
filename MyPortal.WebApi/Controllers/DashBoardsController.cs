using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyPortal.Core.Entities;
using MyPortal.Core.Services;
using MyPortal.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyPortal.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardsController : ControllerBase
    {
        public DashBoardsController(IDashboardService dashboardService,IMapper mapper,IUserService userService)
        {
            DashboardService = dashboardService;
            Mapper = mapper;
            UserService = userService;
        }

        public IDashboardService DashboardService { get; }
        public IMapper Mapper { get; }
        public IUserService UserService { get; }

        [Route("~/api/Users/{id}/Dashboards")]
        //[HttpGet("")]
        public async Task<IActionResult> GetUserDashboards(int id)
        {
            var user = await UserService.GetUserDashBoardsAsync(id);
            return Ok(Mapper.Map<UserWithDashBoards>(user));

        }

        [HttpPut("")]
        public async Task<IActionResult> CreateDashboard([FromBody] CreateDashBoard dashBoardDto)
        {
            var dashboard = await DashboardService.CreateDashboard( Mapper.Map<Dashboard>(dashBoardDto));
            return CreatedAtRoute("DashboardApi", new { id = dashboard},dashboard);
        }


        [HttpGet("")]
        public  async Task<IActionResult> GetDashboards()
        {
            var dashboards = await DashboardService.GetDashboardsAsync();
            return Ok(Mapper.Map<List<DashBoardDto>>(dashboards));
        }

        [HttpGet("{id}",Name ="DashboardApi")]
        public async Task<IActionResult> GetDashboard(int id)
        {
            var dashboard = await DashboardService.GetDashboardAsync(id);
            return Ok(Mapper.Map<DashBoardDto>(dashboard));
        }
    }
}