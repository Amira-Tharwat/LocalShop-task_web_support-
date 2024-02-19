using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Metadata;
using LocalShop.Models;

namespace LocalShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> products { get; set; }

        public DbSet<BlogType> blogTypes { get; set; }
        public DbSet<Blog> blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "nike" },
                new Company { Id = 2, Name = "adidas" }
                );

            modelBuilder.Entity<BlogType>().HasData(
               new BlogType { Id = 1, Name = "comedy" },
               new BlogType { Id = 2, Name = "romantic" },
               new BlogType { Id = 3, Name = "horror" },
               new BlogType { Id = 4, Name = "scientific" }
               );
        }

    }
}
