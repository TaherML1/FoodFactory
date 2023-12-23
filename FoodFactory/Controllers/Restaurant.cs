using FoodFactory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FoodFactory.Controllers
{
    public class Restaurant : Controller
    {
        private readonly FoodFactoryDBContext _foodFactoryDbContext;

        public Restaurant(FoodFactoryDBContext foodFactoryDbContext)
        {
            _foodFactoryDbContext = foodFactoryDbContext;
        }

        // GET:

        public IActionResult Create()
        {
            var viewModel = new CreateFoodViewModel();
            return View(viewModel);
        }

        // POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Create(CreateFoodViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var food = new Food
                {
                    Type = viewModel.Type,
                    Size = viewModel.Size,
                    Cheese = viewModel.Cheese,
                    Dessert = viewModel.Dessert,
                    Drinks = viewModel.Drinks,
                };

                _foodFactoryDbContext.MyFoods.Add(food);
                _foodFactoryDbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            viewModel.TypeChoices = new List<string> { "Standard", "Zurna", "Beef" };
            viewModel.SizeChoices = new List<string> { "Small", "Medium", "Large" };
            viewModel.CheeseChoices = new List<string> { "Cheddar", "Tazekaşar", "None" };
            viewModel.DessertChoices = new List<string> { "CheeseCake", "Puding", "Souffle", "Tiramisu", "Biscotti" };
            viewModel.DrinksChoices = new List<string> { "Cola", "Ayran", "IceTea", "Sprite", "Fanta" };

            return View(viewModel);
        }


        public IActionResult Pizza()
        {
            var viewModel2 = new CreateFoodViewModel();
            return View(viewModel2);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Pizza(CreateFoodViewModel viewModel2)
        {

            if (ModelState.IsValid)
            {
                var Pizza = new Food
                {
                    Type = viewModel2.Type,
                    Size = viewModel2.Size,
                    Cheese = viewModel2.Cheese,
                    Dessert = viewModel2.Dessert,
                    Drinks = viewModel2.Drinks,
                };

                _foodFactoryDbContext.MyFoods.Add(Pizza);
                _foodFactoryDbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
           
            viewModel2.PizzaTypeChoices = new List<string> { "Margarita", "Pepperoni Pizza", " BBQ Chicken Pizza", "Cheese Pizza" };
            viewModel2.SizeChoices = new List<string> { "Small", "Medium", "Large" };
            viewModel2.PizzaPromotion = new List<string> { "Cheddar", "Chicken", "Mushroom", "Sausage","Bacon" };
            viewModel2.DessertChoices = new List<string> { "CheeseCake", "Puding", "Souffle", "Tiramisu", "Biscotti" };
            viewModel2.DrinksChoices = new List<string> { "Cola", "Ayran", "IceTea", "Sprite", "Fanta" };

            return View(viewModel2);
        }
    

    }
}