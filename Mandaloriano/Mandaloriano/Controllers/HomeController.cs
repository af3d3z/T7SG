using BL;
using ENT;
using Mandaloriano.Models;
using Mandaloriano.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mandaloriano.Controllers
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
            return View();
        }

        public IActionResult Mandaloriano() {
            return View(ListaMisionesBL.GetMisionesBL());
        }

        [HttpPost]
        public IActionResult Mandaloriano(int misionId) {
            return View("MandalorianoMision", new ListaYMisionVM(misionId));
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
