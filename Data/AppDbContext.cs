using Microsoft.EntityFrameworkCore;
using BookReviewHub.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BookReviewHub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Review> Reviews => Set<Review>();

        // Seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Genres
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Fantasy" },
                new Genre { Id = 2, Name = "Science Fiction" },
                new Genre { Id = 3, Name = "Mystery" },
                new Genre { Id = 4, Name = "Romance" },
                new Genre { Id = 5, Name = "Horror" }
            );

            // Books (5 per genre)
            int bookId = 1;
            for (int genreId = 1; genreId <= 5; genreId++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    modelBuilder.Entity<Book>().HasData(new Book
                    {
                        Id = bookId,
                        Title = $"Book {i} - Genre {genreId}",
                        Author = $"Author {bookId}",
                        GenreId = genreId
                    });
                    bookId++;
                }
            }
        }
    }
}
