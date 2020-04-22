using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LawManagementSystem.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public IList<Case> Cases { get; set; }
        public string City { get; set; }
    }

    public class AppRole: IdentityRole
    {
       
    }
}
