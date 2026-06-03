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


    }
}
