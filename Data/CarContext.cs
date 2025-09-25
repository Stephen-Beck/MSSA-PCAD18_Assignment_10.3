using Assignment_10._3.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3.Data
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Dealership> Dealerships { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=GARDEN;initial catalog=PCAD18Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        // (Optional in case database is blank) Adds the seed data (dummy records) to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dealership>().HasData(
                new Dealership { DealershipID = 1, DealershipName = "Carvana", Location = "Virginia" },
                new Dealership { DealershipID = 2, DealershipName = "Carmax", Location = "Maryland" });

            modelBuilder.Entity<Car>().HasData(
    new Car { VIN = GenerateVIN(), Make = "Toyota", Model = "Camry", Year = 2023, Color = "White", Price = 26320, DealershipID = 1 },
    new Car { VIN = GenerateVIN(), Make = "Ford", Model = "Mustang", Year = 2024, Color = "Red", Price = 27495, DealershipID = 1 },
    new Car { VIN = GenerateVIN(), Make = "Honda", Model = "Civic", Year = 2023, Color = "Blue", Price = 23645, DealershipID = 2 });

        }

        public static string GenerateVIN()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 17).ToUpper();
        }
    }
}
