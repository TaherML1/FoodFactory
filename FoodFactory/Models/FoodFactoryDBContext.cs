using Microsoft.EntityFrameworkCore;

namespace FoodFactory.Models
{
    public class FoodFactoryDBContext : DbContext
    {
        public FoodFactoryDBContext(DbContextOptions<FoodFactoryDBContext> options) : base(options) {
        
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<MealOption> MealOptions { get; set; }
    }
}
