using Microsoft.AspNetCore.Mvc;
using OpertationClucter.Models;
using System.Diagnostics;

namespace OpertationClucter.Controllers
{
    public class HomeController : Controller
    {
        int va;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calucter(int Number1, char Opertation, int Number2)
        {
            char Opertations = Opertation;
            ViewData["Number1"] = Number1;
            ViewData["Number2"] = Number2;
            switch (Opertation)
            {
                case '+':
                    va = Number1 + Number2;
                    break;

                case '-':
                    va = Number1 - Number1;
                    break;

                case '*':
                    va = Number1 * Number2;
                    break;

                case '/':
                    va = Number1 / Number2;
                    break;
            }
            ViewData["values"] = va;
            ViewData["Opertation"] = Opertation;
            return View("Index");
        }


    }
}