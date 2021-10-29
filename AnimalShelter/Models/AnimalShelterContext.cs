using Microsoft.EntityFrameworkCore;

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
      builder.Entity<Cat>()
        .HasData(
        new Cat { CatId = 1, CatName = "Toey", CatGender = "Female", CatBreed = "Chocolate York", CatColor = "Black, Grey" },
        new Cat { CatId = 2, CatName = "Yuumi", CatGender = "Female", CatBreed = "Bandle", CatColor = "Blue, Yellow" },
        new Cat { CatId = 3, CatName = "Tardar Sauce", CatGender = "Female", CatBreed = "Mixed, Calico, Tabby", CatColor = "White, Brown, Cream" },
        new Cat { CatId = 4, CatName = "Mr. Bigglesworth", CatGender = "Male", CatBreed = "Sphynx", CatColor = "Naked" }

        );
      builder.Entity<Dog>()
        .HasData(
        new Dog { DogId = 1, DogName = "Loki", DogGender = "Male", DogBreed = "Mixed, Pitbull, Terrier, Australian Shepherd", DogColor = "Black, White"},
        new Dog { DogId = 2, DogName = "Brandie", DogGender = "Female", DogBreed = "Mixed, Pitbull, Terrier", DogColor = "Black, White"},
        new Dog { DogId = 3, DogName = "Clifford", DogGender = "Male", DogBreed = "Mixed, Vizsla, Hound, Bloodhound", DogColor = "Red"},
        new Dog { DogId = 4, DogName = "Balto", DogGender = "Male", DogBreed = "Siberian Husky", DogColor = "Black, White"}

        );
    }


    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }
    // public DbSet<ApplicationUser> ApplicationUsers { get; set; }
  }
}