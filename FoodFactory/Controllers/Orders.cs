using Microsoft.AspNetCore.Mvc;

namespace FoodFactory.Controllers
{
    public class Orders : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
