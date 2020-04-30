using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.Models
{
    public class Court
    {
        public int CourtId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public string Address{ get; set; }
        public DateTime TimeStamp { get; set; }


    }
}
