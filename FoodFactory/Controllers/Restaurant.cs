using FoodFactory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static FoodFactory.Models.Food;

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

            List<Food> Products = new List<Food>() {

                new Food() {FoodId=0,FoodName="Doner wrap",Price=3.50,Status=true},
                new Food() {FoodId=1,FoodName="Zurna wrap",Price=5,Status=true},
                new Food() {FoodId=2,FoodName="Doner",Price=3.50,Status=false},
                new Food() {FoodId=3,FoodName="Mega Zurna Wrap",Price=7.90,Status=true},
                new Food() {FoodId=4,FoodName="Ayran",Price=1,Status=true},
                new Food() {FoodId=5,FoodName="Soda",Price=1,Status=true},


            };


            return View(Products);
        }

        public IActionResult Pizza()
        {

            List<Food> Products = new List<Food>() {

                new Food() {FoodId=0,FoodName="Margarita",Price=3.50,Status=true},
                new Food() {FoodId=1,FoodName="Mixed",Price=5,Status=true},
                new Food() {FoodId=2,FoodName="Meat Master",Price=3.50,Status=false},
                new Food() {FoodId=3,FoodName="Vegan",Price=7.90,Status=true},
                new Food() {FoodId=4,FoodName="Ayran",Price=1,Status=true},
                new Food() {FoodId=5,FoodName="Soda",Price=1,Status=true},


            };

            return View(Products);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
