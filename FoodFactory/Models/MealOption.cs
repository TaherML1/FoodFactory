using System.ComponentModel.DataAnnotations;

namespace FoodFactory.Models
{
    public class MealOption
    {
        [Key]
        public int  mealId {get; set;}
        public string[] Name { get; set; }
        public string Label { get; set; }

        public MealOption(int id,string[] name,string label)
        {
            mealId = id;
            Name = name;
            Label = label;
        }

        public MealOption()
        {
            mealId=0;   
            Name = new string[] { "one", "two", "three" };
            Label = "Option";
        }
    }
}
