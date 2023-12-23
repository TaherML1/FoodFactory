using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FoodFactory.Models
{
    public class Food
    {

        public int Id { get; set; }

      
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
    }

}