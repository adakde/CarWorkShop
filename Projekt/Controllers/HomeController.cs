using Microsoft.AspNetCore.Mvc;
using Projekt.Models;
using System.Diagnostics;

namespace Projekt.Controllers
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
            string Title;
            string Description;
            string[] Tags;
            return View();
        }

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Jakub",
                    LastName = "Kasprzak"
                },
                new Person()
                {
                    FirstName = "Kacper",
                    LastName = "Kasprzak"
                },
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
