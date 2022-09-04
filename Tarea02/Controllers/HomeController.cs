using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tarea02.Models;

namespace Tarea02.Controllers
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
            var objAlu = new Alumno()
            {
                Id = 2,
                Name = "Juan",
                Course = "Inglés"
            };
            return View("Index",objAlu);
            //return View();
        }
        public IActionResult Index()
        {
            var objAlu = new Alumno()
            {
                Id = 3,
                Name = "Carlos Zamorano",
                Course = "Programacion Orientada Objetos"
            };
            return View("Index",objAlu);
            //return View();
        }
        public IActionResult Index()
        {
            var objAlu = new Alumno()
            {
                Id = 1,
                Name = "Jafet Cánepa",
                Course = "Multiplataforma"
            };
            return View("Index",objAlu);
            //return View();
        }

        public IActionResult Privacy()
        {
            var objSup = new Supermercado()
            {
                name = "Tottus",
                lugar = "La Molina"
            };
            return View("Privacy",objSup);
            //return View();
        }
        public IActionResult Ejercicio3()
        {
            var objSup = new Supermercado()
            {
                name = "Plaza Vea",
                lugar = "Miraflores"
            };
            return View("Ejercicio3",objSup);
            //return View();
        }
        {
            var objSup = new Supermercado()
            {
                name = "Metro",
                lugar = "San Isidro"
            };
            return View("Ejercicio3",objSup);
            //return View();
        }
        public IActionResult Ejercicio4()
        {
            var objPer = new Persona()
            {
                Name = "Andrea",
                Age = 20,
                Sex = "Femenino"
            };
            return View("Ejercicio4", objPer);
            //return View();
        }
     public IActionResult Ejercicio4()
        {
            var objPer = new Persona()
            {
                Name = "Antonella",
                Age = 17,
                Sex = "Femenino"
            };
            return View("Ejercicio4", objPer);
            //return View();
        }
     public IActionResult Ejercicio4()
        {
            var objPer = new Persona()
            {
                Name = "Carlos",
                Age = 25,
                Sex = "Masculino"
            };
            return View("Ejercicio4", objPer);
            //return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}