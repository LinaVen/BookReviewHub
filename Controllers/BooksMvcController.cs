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
    }
}
