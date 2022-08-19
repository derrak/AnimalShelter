using Microsoft.EntityFrameworkCore;
using System;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<Animal>()
          .HasData(
              new Animal { Animald = 1, UserId = 4, DateCreated = DateTime.Now, AnimalName = "Yanaba", AnimalSpecies = "Polar Bear", Availability = true, AnimalBreed = "Unknown", Description = "Afraid of shoes" },
              new Animal { AnimalId = 2, UserId = 3, DateCreated = DateTime.Now, AnimalName = "Meg", AnimalSpecies = "Giant Panda", Availability = true, AnimalBreed = "Unknown", Description = "Toilet trained" },
              new Animal { AnimalId = 3, UserId = 3, DateCreated = DateTime.Now, AnimalName = "Goldie", AnimalSpecies = "Amur Leopard", Availability = true, AnimalBreed = "Unknown", Description = "Can't sit still" },
              new Animal { AnimalId = 4, UserId = 2, DateCreated = DateTime.Now, AnimalName = "Kendrick", AnimalSpecies = "Orangutan", Availability = true, AnimalBreed = "Unknown", Description = "Really messy roommate" },
              new Animal { AnimalId = 5, UserId = 1, DateCreated = DateTime.Now, AnimalName = "Angie", AnimalSpecies = "Sea Turtle", Availability = true, AnimalBreed = "Unknown", Description = "Thinks they're a cat" }.
              new Animal { AnimalId = 6, UserId = 4, DateCreated = DateTime.Now, AnimalName = "Theodore", AnimalSpecies = "Chimpanzee", Availability = true, AnimalBreed = "Unknown", Description = "Good snuggles" },
              new Animal { AnimalId = 7, UserId = 1, DateCreated = DateTime.Now, AnimalName = "Eggy", AnimalSpecies = "Elephant", Availability = false, AnimalBreed = "Unknown", Description = "Demands to sleep in bed with humans" },
              new Animal { AnimalId = 8, UserId = 5, DateCreated = DateTime.Now, AnimalName = "Gerald", AnimalSpecies = "Plains Bison", Availability = false, AnimalBreed = "Unknown", Description = "Loves giving wet kisses" },
              new Animal { AnimalId = 9, UserId = 6, DateCreated = DateTime.Now, AnimalName = "Gavr", AnimalSpecies = "Vaquita", Availability = false, AnimalBreed = "Unknown", Description = "1 of 10 left in the world" },
              new Animal { AnimalId = 10, UserId = 2, DateCreated = DateTime.Now, AnimalName = "Wagyu", AnimalSpecies = "Rhino", Availability = false, AnimalBreed = "Unknown", Description = "Loves to nuzzle" }
          );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}ˇ`