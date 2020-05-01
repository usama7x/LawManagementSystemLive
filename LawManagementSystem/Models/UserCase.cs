using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.Models
{
    public class UserCase
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Case Case { get; set; }
        public int CaseId { get; set; }
        public string ContactNo {get; set;}
        public DateTime Stamp { get; set; }
    }
}
