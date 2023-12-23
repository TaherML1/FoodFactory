using FoodFactory.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodFactory.Controllers
{
    public class OrderController : Controller
    {
        
            private readonly FoodFactoryDBContext _foodFactoryDbContext;

            public OrderController(FoodFactoryDBContext foodFactoryDbContext)
            {
                _foodFactoryDbContext = foodFactoryDbContext;
            }

            public IActionResult Index()
            {
                // Retrieve orders from the database
                var orders = _foodFactoryDbContext.MyFoods.ToList();
                return View(orders);
            }
        }
}
