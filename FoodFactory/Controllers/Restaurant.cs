using FoodFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodFactory.Controllers
{
    public class Restaurant : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Zurna()
        {
            return View();
        }

        public IActionResult Pizza()
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
