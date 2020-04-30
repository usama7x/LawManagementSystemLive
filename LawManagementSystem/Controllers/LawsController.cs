﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Data;
using LawManagementSystem.Models;
using LawManagementSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LawManagementSystem.Controllers
{
    [Authorize]
    public class LawsController : Controller
    {
        readonly AppDbContext dbContext;
        public LawsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        
        public IActionResult Index(string searchString)
        {

            var laws = dbContext.Laws.ToList();
            if (!string.IsNullOrEmpty(searchString))
            {
                var result = laws.Where(x => x.SectionNo.Contains(searchString) || x.Description
                .Contains(searchString)).ToList();
                return View(result);
            }
            return View(laws);
        }
        
        [HttpGet]
        public IActionResult CreateLaw()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateLaw(LawViewModel model)
        {
            dbContext.Laws.Add(new Law 
            {
                Name = model.Name,
                Description = model.Description,
                Category = model.Category,
                SectionNo = model.SectionNo
            });
            return View();
        }
    }
}