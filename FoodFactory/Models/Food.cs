
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace FoodFactory.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        public string FoodName { get; set; }

        public List <MealOption> Options { get; set; }



        public Food(int id, string name)
        {
            FoodId = id;
            FoodName = name;
            Options = new List<MealOption>();
        }


        public Food()
        {
            FoodId = 0;
            FoodName = "Food";
            Options = new List<MealOption>();
        }

        

        public void AddOption(MealOption option)
        {
            Options.Add(option);
        }    
        
    }

}
