using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SoftUniGamesApp.Web.ViewModels;

namespace SoftUniGamesApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {

        }

        public IActionResult Index()
        {
            ViewData["Title"] = "IndieZone";
            ViewData["Message"] = "Welcome to the Indie game Zone";


            return View();
        }
    }
}
