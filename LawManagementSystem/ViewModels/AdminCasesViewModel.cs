using LawManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.ViewModels
{
    public class AdminCasesViewModel
    {
        public int Id { get; set; }
        [DisplayName("Client Name")]       
        public string Name { get; set; }
        [DisplayName("Contact No.")]
        public string ContactNo { get; set; }
        [DisplayName("Case Type")]
        public CaseType Type{ get; set; }        
        public string Details { get; set; }
        [DisplayName("Registered Date")]
        public DateTime Stamp { get; set; }
    }
}
