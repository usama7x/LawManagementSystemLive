using System;
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
    public class LawyersController : Controller
    {
        readonly AppDbContext dbContext;
        public LawyersController(AppDbContext dbContext )
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index(string searchString)
        {
            var lawyers =  dbContext.Lawyers.OrderByDescending(x => x.TimeStamp).ToList();
            if (!string.IsNullOrEmpty(searchString))
            {
                var result = lawyers.Where(x => x.Name.Contains(searchString) || x.Expertise
               .Contains(searchString) || x.Address.Contains(searchString)).ToList();
                return View(result);
            }
            return View(lawyers);
        }

        [HttpGet]
        public IActionResult CreateLawyer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateLawyerAsync(LawyerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var newLawyer = new Lawyer()
            {
                Name = model.Name,
                Email = model.Email,
                PhoneNo = model.PhoneNo,
                YearsOfExperience = model.YearsOfExperience,
                TimeStamp = DateTime.Now,
                Address = model.Address,
                Expertise = model.Expertise
            };
            await dbContext.Lawyers.AddAsync(newLawyer);
            await dbContext.SaveChangesAsync();
            return View();
        }
    }
}