using AutoMapper;
using MyPortal.Core.Entities;
using MyPortal.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortal.WebApi
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<User,UserDetailDto>().ReverseMap();
            CreateMap<Dashboard, DashBoardDto>().ReverseMap();
            CreateMap<CreateDashBoard, Dashboard>();
        }
    }
}
