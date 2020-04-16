using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LawManagementSystem.Models
{
    public class AppUser: IdentityUser
    {
        public IList<Case> Cases { get; set; }
    }

    public class AppRole: IdentityRole
    {
       
    }
}
