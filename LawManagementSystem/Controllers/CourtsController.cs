using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace LawManagementSystem.Controllers
{
    public class CourtsController : Controller
    {
        readonly AppDbContext dbContext;
        public CourtsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var courts = dbContext.Courts.ToList();
            return View(courts);
        }
    }
}