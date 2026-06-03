using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewHub.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string ReviewerName { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;

        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }
    }
}
