using Microsoft.AspNetCore.Mvc;
using NapaEduWebAppMVC.Models;
using System.Diagnostics;

namespace NapaEduWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        public ActionResult Index([FromQuery]string? text)
        {
            return View( text);
        }

        public IActionResult CustomResult(string? text)
        {
            return View(viewName: nameof(Index),model: text);
        }
    }
}
