﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LawManagementSystem.ViewModels
{
    public class LawViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SectionNo { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
