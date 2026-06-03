using BookReviewHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviewHub.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

            // Exit if data already exists
            if (context.Books.Any() || context.Genres.Any())
                return;

            // Seed genres
            var genres = new List<Genre>
            {
                new Genre { Name = "Fiction" },
                new Genre { Name = "Non-Fiction" },
                new Genre { Name = "Science" },
                new Genre { Name = "History" },
                new Genre { Name = "Fantasy" },
                new Genre { Name = "Romance" }
            };

            context.Genres.AddRange(genres);
            context.SaveChanges();

            // Seed books (at least 5 per genre)
            var books = new List<Book>
            {
                new Book { Title = "Fiction Book 1", Author = "Author A", GenreId = genres[0].Id },
                new Book { Title = "Fiction Book 2", Author = "Author A", GenreId = genres[0].Id },
                new Book { Title = "Fiction Book 3", Author = "Author A", GenreId = genres[0].Id },
                new Book { Title = "Fiction Book 4", Author = "Author A", GenreId = genres[0].Id },
                new Book { Title = "Fiction Book 5", Author = "Author A", GenreId = genres[0].Id },

                new Book { Title = "Non-Fiction Book 1", Author = "Author B", GenreId = genres[1].Id },
                new Book { Title = "Non-Fiction Book 2", Author = "Author B", GenreId = genres[1].Id },
                new Book { Title = "Non-Fiction Book 3", Author = "Author B", GenreId = genres[1].Id },
                new Book { Title = "Non-Fiction Book 4", Author = "Author B", GenreId = genres[1].Id },
                new Book { Title = "Non-Fiction Book 5", Author = "Author B", GenreId = genres[1].Id },

                // Add 5 for each remaining genre...
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
