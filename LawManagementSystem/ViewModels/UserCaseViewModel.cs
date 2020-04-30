using LawManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.ViewModels
{
    public class UserCaseViewModel
    {
        public CaseType Type { get; set; }
        public string Details { get; set; }
        public DateTime Stamp { get; set; }
        public string ContactNo { get; set; }
    }
}
