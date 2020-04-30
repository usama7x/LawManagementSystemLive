using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Data;
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
        public IActionResult Index()
        {
            var lawyers = dbContext.Lawyers.ToList();
            return View(lawyers);
        }
    }
}