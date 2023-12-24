using Microsoft.Build.Framework;
using System.Collections.Generic;
namespace FoodFactory.Models
{
    public class CreateFoodViewModel
    {
        
        [Required]
        public string Size { get; set; }
        [Required]
        public string Type { get; set; }

        [Required]

        public string Cheese { get; set; }
        [Required]
        public string Dessert { get; set; }
        [Required]
        public string Drinks { get; set; }

        public List<string> PizzaTypeChoices { get; set; } = new List<string> { "Margarita", "Pepperoni Pizza", "BBQ Chicken Pizza", "Cheese Pizza" };

        public List<string> PizzaPromotion { get; set; } = new List<string> { "Cheddar", "Chicken", "Mushroom", "Sausage", "Bacon" };
        public List<string> TypeChoices { get; set; } = new List<string> { "Standard", "Zurna", "Beef" };
        public List<string> SizeChoices { get; set; } = new List<string> { "Small", "Medium", "Large" };

        public List<string> CheeseChoices { get; set; } = new List<string> { "Cheddar", "Mozzarella", "None" };
        public List<string> DessertChoices { get; set; } = new List<string> { "CheeseCake", "Puding", "Souffle", "Tiramisu", "Biscotti" };

        public List<string> DrinksChoices { get; set; } = new List<string> { "Cola", "Ayran", "IceTea", "Sprite", "Fanta" };



    }
}