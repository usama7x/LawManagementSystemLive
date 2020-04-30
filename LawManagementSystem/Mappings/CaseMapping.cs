using AutoMapper;
using LawManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.Mappings
{
    public class CaseMapping: Profile
    {
        public CaseMapping()
        {
            CreateMap<Case, UserCase>()
             .ForMember(x => x.AppUserId, x => x.MapFrom(x => x.AppUser.Id));
               
        }
    }
}
