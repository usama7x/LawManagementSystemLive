using AutoMapper;
using LawManagementSystem.Models;
using LawManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterViewModel, AppUser>()
                .ForMember(x => x.UserName, x => x.MapFrom(u => u.Email));
        }
    }
}
