using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LawManagementSystem.Models;
using LawManagementSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LawManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        readonly SignInManager<AppUser> signInManager;
        readonly UserManager<AppUser> userManager;
        readonly IMapper mapper;
        public AccountController(UserManager<AppUser> userManager,
                                SignInManager<AppUser> signInManager,
                                IMapper mapper)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginViewModel loginModel, string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            var user = await userManager.FindByEmailAsync(loginModel.Email);
            if (user is null)
                return NotFound();
            var result = await signInManager.PasswordSignInAsync(user, loginModel.Password, loginModel.RememberMe, false);
            if (result.Succeeded)
                return LocalRedirect(returnUrl);
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (!ModelState.IsValid)            
                return View(model);
            var user = mapper.Map<AppUser>(model);
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View(model);
            }
            return RedirectToAction("Index", "Home");           
           
        }

    }
}