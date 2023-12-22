using System.ComponentModel.DataAnnotations;

namespace FoodFactory.Models
{
    public class MealOption
    {
        [Key]
        public int  mealId {get; set;}
        public string[] Name { get; set; }

        public string Label { get; set; }

        public MealOption(string[] name)
        {
            Name = name;
        }

        public MealOption()
        {
            Name = new string[] { "Small", "Medium", "Large1111" };
        }
    }
}
