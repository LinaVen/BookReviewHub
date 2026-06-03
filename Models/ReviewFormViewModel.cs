namespace BookReviewHub.Models
{
    public class ReviewFormViewModel
    {
        public int BookId { get; set; }
        public string? ReviewerName { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
    }
}
