using Ejercicio4MVC.Models.DAL;
using Ejercicio4MVC.Models.ENT;
using Ejercicio4MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Ejercicio4MVC.Models.VM;

namespace Ejercicio4MVC.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult EditarPersonas() {
            Random rnd = new Random();
            List<Persona> personas = Listados.ObtenerPersonas();
            Persona personaSeleccionada = personas[rnd.Next(personas.Count)];
            EditarPersonasVM editarPersonasVM = new EditarPersonasVM(personaSeleccionada);

            return View(editarPersonasVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
