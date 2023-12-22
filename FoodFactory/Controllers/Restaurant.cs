using FoodFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static FoodFactory.Models.Food;

namespace FoodFactory.Controllers
{
    public class Restaurant : Controller
    {
        private readonly FoodFactoryDBContext dbContext;

        public Restaurant(FoodFactoryDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Zurna()
        {

            Food Zurna = new Food("Zurna");


            var WrapOption = new MealOption { Name = new[] { "Standard", "Zurna", "Meat" }, Label = "Zurna" };
            var sizeOption = new MealOption { Name = new[] { "Small", "Medium", "Large" }, Label = "Size" };
            var Cheese = new MealOption { Name = new[] { "Cheddar", "Tazekaşar","None" }, Label = "Cheese" };
            var Dessert = new MealOption { Name = new[] { "CheeseCake", "Puding", "Souffle", "Tiramisu", "Biscotti" }, Label = "Dessert" };
            var drinkOption = new MealOption { Name = new[] { "Cola", "Ayran", "IceTea", "Sprite", "Fanta" }, Label = "Drink" };


            Zurna.AddOption(WrapOption);
            Zurna.AddOption(sizeOption);
            Zurna.AddOption(Cheese);
            Zurna.AddOption(Dessert);
            Zurna.AddOption(drinkOption);


            return View(Zurna);


        }

        public IActionResult Pizza()
        {

            Food MealWithOptions = new Food("Pizza");


            var PizzaOption = new MealOption { Name = new[] { "Margarita", "Pepperoni", "Mixed", "Chicken" }, Label="Pizza" };
            var sizeOption = new MealOption { Name = new[] { "Small","Medium","Large" },Label="Size" };
            var Thickness = new MealOption { Name = new[] { "Thin", "Standard ","Thick"},Label="Thickness" };
            var Dessert = new MealOption { Name = new[] { "CheeseCake", "Puding", "Souffle", "Tiramisu", "Biscotti" }, Label="Dessert" };
            var drinkOption = new MealOption { Name = new[] { "Cola", "Ayran", "IceTea", "Sprite", "Fanta" }, Label="Drink" };


            MealWithOptions.AddOption(PizzaOption);
            MealWithOptions.AddOption(sizeOption);
            MealWithOptions.AddOption(Thickness);
            MealWithOptions.AddOption(Dessert);
            MealWithOptions.AddOption(drinkOption);
            



            return View(MealWithOptions);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
