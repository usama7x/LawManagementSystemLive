using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LawManagementSystem.Controllers
{
    public class LawsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}