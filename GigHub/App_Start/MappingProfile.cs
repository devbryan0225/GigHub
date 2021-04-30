using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigHub.Models;
using GigHub.Controllers.Api;

namespace GigHub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
            Mapper.CreateMap<Gig, GigDto>();
            Mapper.CreateMap<Notification, NotificationDto>();
        }
    }
}