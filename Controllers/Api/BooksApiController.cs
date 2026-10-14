using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookReviewHub.Data;
using BookReviewHub.Models;

namespace BookReviewHub.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BooksApiController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.Include(b => b.Genre).ToListAsync();
        }

        // GET: api/books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            try
            {
                var book = await _context.Books
                    .Include(b => b.Genre)
                    .Include(b => b.Reviews)
                    .FirstOrDefaultAsync(b => b.Id == id);

                if (book == null)
                    return NotFound();

                return book;
            }
            catch (Exception ex)
            {
                // 💡 This line will give us the real cause in the browser
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        // POST: api/BooksApi/reviews
        [HttpPost("reviews")]
        public async Task<IActionResult> AddReview([FromBody] Review review)
        {
            // Validate the review
            if (string.IsNullOrWhiteSpace(review.ReviewerName) ||
                string.IsNullOrWhiteSpace(review.Comment) ||
                review.Rating < 1 || review.Rating > 5)
            {
                return BadRequest("Please provide a name, comment, and rating from 1 to 5.");
            }

            // Check that the book exists
            bool bookExists = await _context.Books.AnyAsync(b => b.Id == review.BookId);

            if (!bookExists)
            {
                return NotFound("Book not found.");
            }

            // Save the review to the database
            var newReview = new Review
            {
                BookId = review.BookId,
                ReviewerName = review.ReviewerName,
                Rating = review.Rating,
                Comment = review.Comment
            };

            _context.Reviews.Add(newReview);
            await _context.SaveChangesAsync();

            return Ok(newReview);
        }

    }
}
