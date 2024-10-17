using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T7SG.Models;

namespace T7SG.Controllers
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
            String msg = "";
            DateTime tiempo = DateTime.Now;

            ViewBag.Hora = tiempo.ToLongTimeString();

            if (tiempo.Hour >= 21 && tiempo.Hour < 6)
            {
                msg = "Buenas noches";
            }
            else if (tiempo.Hour >= 6 && tiempo.Hour <= 12)
            {
                msg = "Buenos días";
            }
            else {
                msg = "Buenas tardes";
            }
            ViewData["msg"] = msg;
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
