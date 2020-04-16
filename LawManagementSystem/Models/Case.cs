using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LawManagementSystem.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        public string Nature { get; set; }
        public string Detail { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
