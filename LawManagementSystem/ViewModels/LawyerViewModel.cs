using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.ViewModels
{
    public class LawyerViewModel
    {
        [Required]
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int YearsOfExperience { get; set; }
        public string Expertise { get; set; }
    }
}
