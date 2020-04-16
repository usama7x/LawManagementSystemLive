using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.Models
{
    public class Law
    {
        public int LawId { get; set; }
        public string Name { get; set; }
        public string SectionNo { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        
    }
}
