using System.ComponentModel.DataAnnotations;

namespace BookReviewHub.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        // Navigation property (optional, but good for reverse reference)
        public List<Book>? Books { get; set; }
    }
}
