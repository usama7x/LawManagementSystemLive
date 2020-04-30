using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LawManagementSystem.Models
{
    public class Case
    {
        public int CaseId { get; set; }
        [DisplayName("Court Type")]
        public CaseType Type { get; set; }
        public string Details { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public enum CaseType
    {
        Criminal,
        Civil,
        Bail,
        Appeal
    }
}
