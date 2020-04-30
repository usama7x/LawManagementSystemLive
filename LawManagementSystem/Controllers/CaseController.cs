using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Data;
using LawManagementSystem.Models;
using LawManagementSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LawManagementSystem.Controllers
{
    [Authorize]
    public class CaseController : Controller
    {
        readonly UserManager<AppUser> userManager;
        readonly AppDbContext dbContect;
        public CaseController(UserManager<AppUser> userManager, AppDbContext dbContect)
        {
            this.dbContect = dbContect;
            this.userManager = userManager;
        }

        public IActionResult RegisterCase()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterCase(UserCaseViewModel model)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var newCase = new Case()
            {
                AppUser = user,
                Details = model.Details,
                TimeStamp = DateTime.Now,
                Type = model.Type

            };

            await dbContect.Cases.AddAsync(newCase);
            await dbContect.SaveChangesAsync();
            //Console.WriteLine(registeredCase);

            var userCase = new UserCase()
            {
                AppUserId = user.Id,
                Stamp = DateTime.Now,
                Case = newCase,
                CaseId = newCase.CaseId,
                User = user

            };

            await dbContect.UserCase.AddAsync(userCase);
            await dbContect.SaveChangesAsync();
            return View();
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult GetAllAsync()
        {
            var userCases = dbContect.UserCase.Select(x => new AdminCasesViewModel
            {
                Name = x.User.FirstName + " " + x.User.LastName,
                ContactNo = x.User.PhoneNumber,
                Details = x.Case.Details,
                Id = x.Id,
                Stamp = x.Stamp,
                Type = x.Case.Type
            });
            return View(userCases);
        }
       
    }
}