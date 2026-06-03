using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewHub.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? Title { get; set; }

        [Required, StringLength(100)]
        public string? Author { get; set; }

        // Foreign key for Genre
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        // ✅ Navigation property for Genre
        public Genre? Genre { get; set; }

        // Navigation property for Reviews
        public List<Review>? Reviews { get; set; }
    }
}
