using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SoftUniGamesApp.Models;

namespace SoftUniGamesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "IndieZone";
            ViewData["Message"] = "Welcome to the Indie game Zone";


            return View();
        }
    }
}
