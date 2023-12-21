
using System.Security.Cryptography.X509Certificates;

namespace FoodFactory.Models
{

    public class MealOption
    {

        public string[] Name { get; set;}

        public string Label { get; set;}

        public MealOption(string[] name)
        {
            Name = name;
        }

        public MealOption()
        {
            Name = new string[] { "Small", "Medium", "Large1111" };
        }

       

    }


    public class Food
    {
        
           public int FoodId { get; set; }
        public string FoodName;

        public List <MealOption> Options { get; set; } 

        public Food(string name)
        {
            FoodName = name;
            Options= new List <MealOption>();
        }

       

        public void AddOption(MealOption option)
        {
            Options.Add(option);
        }    
        
    }

}
