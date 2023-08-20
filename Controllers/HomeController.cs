using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using User_Registration_And_Login_With_MVC_And_Identity_UI.Areas.Identity.Data;
using User_Registration_And_Login_With_MVC_And_Identity_UI.Models;

namespace User_Registration_And_Login_With_MVC_And_Identity_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger,UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager  = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserID"]= _userManager.GetUserId(User);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}