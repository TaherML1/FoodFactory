using Microsoft.EntityFrameworkCore;

namespace FoodFactory.Models
{
    public class FoodFactoryDBContext : DbContext
    {
        public FoodFactoryDBContext(DbContextOptions<FoodFactoryDBContext> options) : base(options) {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>()
                .Property(f => f.FoodName)
                .HasColumnName("FoodName");
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<MealOption> MealOptions { get; set; }
    }
}
