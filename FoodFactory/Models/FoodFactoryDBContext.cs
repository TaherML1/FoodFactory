using Microsoft.EntityFrameworkCore;

namespace FoodFactory.Models
{
    public class FoodFactoryDBContext : DbContext
    {
        public FoodFactoryDBContext(DbContextOptions<FoodFactoryDBContext> options) 
            : base(options)
        {
        }

        public DbSet<Food> MyFoods { get; set; }
        // Add DbSet properties for other entities, if any

        // Add any additional configuration or methods as needed
    }
}

