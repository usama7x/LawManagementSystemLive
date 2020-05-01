using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Data;
using LawManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LawManagementSystem.Controllers
{
    [Authorize]
    public class CourtsController : Controller
    {
        readonly AppDbContext dbContext;
        public CourtsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index(string searchString)
        {

            var laws = dbContext.Courts.OrderByDescending(x => x.CourtId).ToList();
            if (!string.IsNullOrEmpty(searchString))
            {
                var result = laws.Where(x => x.Name.Contains(searchString) || 
                                x.Type.Contains(searchString) || x.Address
                .Contains(searchString)).ToList();
                return View(result);
            }
            return View(laws);
        }


        [HttpGet]
        [Authorize(Roles =  "admin")]
        public IActionResult CreateCourt()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateCourt(Court model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var newCourt = new Court()
            {
                Name = model.Name,
                Type = model.Type,
                Address = model.Address,
                TimeStamp = DateTime.Now
            };
            await dbContext.Courts.AddAsync(newCourt);
            await dbContext.SaveChangesAsync();           
            return View();
        }
    }
}