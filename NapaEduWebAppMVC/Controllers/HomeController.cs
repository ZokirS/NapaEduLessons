using Microsoft.AspNetCore.Mvc;
using NapaEduWebAppMVC.Models;
using System.Diagnostics;
using System.Text;

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

        public ActionResult Index(Person person)
        {
            ViewData["info"] = "Hello from controller";
            ViewBag.info = "hello from viewbag";
            return View(person);
        }

        public IActionResult CustomResult(string? text)
        {
            return View(viewName: nameof(Index),model: text);
        }
    }
}
