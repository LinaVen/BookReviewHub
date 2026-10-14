using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using BookReviewHub.Models;

namespace BookReviewHub.Controllers
{
    public class BooksMvcController : Controller
    {
        private readonly HttpClient _httpClient;

        public BooksMvcController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<IActionResult> Index()
        {
            var books = await _httpClient.GetFromJsonAsync<List<Book>>("https://localhost:7253/api/BooksApi");
            return View(books);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _httpClient.GetFromJsonAsync<Book>($"https://localhost:7253/api/BooksApi/{id}");
            return View(book);
        }
        // POST: BooksMvc/AddReview
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> AddReview(ReviewFormViewModel model)
{
    // Validate the submitted review
    if (!ModelState.IsValid)
    {
        return RedirectToAction("Details", new { id = model.BookId });
    }

    // Prepare the review
    var review = new Review
    {
        BookId = model.BookId,
        ReviewerName = model.ReviewerName,
        Rating = model.Rating,
        Comment = model.Comment
    };

    // Send the review to our Web API
    var response = await _httpClient.PostAsJsonAsync(
        "https://localhost:7253/api/BooksApi/reviews", review);

    if (!response.IsSuccessStatusCode)
    {
        return BadRequest("Unable to save the review.");
    }

    // Return to the book details page
    return RedirectToAction("Details", new { id = model.BookId });
}
    }

}
