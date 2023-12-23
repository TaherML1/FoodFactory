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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            // Retrieve the order by id
            var order = _foodFactoryDbContext.MyFoods.Find(id);

            if (order == null)
            {
                return NotFound();
            }

            // Remove the order from the database
            _foodFactoryDbContext.MyFoods.Remove(order);
            _foodFactoryDbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        }
}
