﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OzelDersYerim.Entity.Concrete.Identity;
using OzelDersYerim.Web.Models.Dtos;

namespace OzelDersYerim.Web.Controllers
{
    [AutoValidateAntiforgeryToken]

    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //public async Task<IActionResult> Register(RegisterDto registerDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (true)
        //        {

        //        }
        //    }
        //}
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginDto { ReturnUrl = returnUrl });
        }

        //[HttpPost]
        //public Task<IActionResult> Login(LoginDto loginDto)
        //{

        //}
    }
}
