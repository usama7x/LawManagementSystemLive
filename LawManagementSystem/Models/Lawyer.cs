
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.Models
{
    public class Lawyer
    {
        public int LawyerId { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int YearsOfExperience { get; set; }
        public string Expertise { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
