using BeingBeing.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeingBeing.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                return View("/Pages/Home/test.cshtml");
            }
            else
            {
                return View("/Pages/Home/default.cshtml");
            }
        }
    }
}
