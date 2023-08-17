using Microsoft.EntityFrameworkCore;

namespace CatBreed.Models
{
    public class CatBreedContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public CatBreedContext(DbContextOptions<CatBreedContext> options) : base(options)
        {
        }
    }

}