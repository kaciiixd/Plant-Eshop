using Microsoft.EntityFrameworkCore;
using PlantShop.Models;

namespace PlantShop.DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Alocasia", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Caladium", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Calathea", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Epipremnum", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Ficus", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Hoya", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Monstera", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Philodendron", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Succulents", DisplayOrder = 9 }

                );
        }

    }
}
