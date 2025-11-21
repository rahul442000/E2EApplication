using E2EApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E2EApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", yearPublished = "1949" },
            new Book { Id = 2, Title = "To Kill a Mocking,ird", Author = "Harper Lee", yearPublished = "1960" },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", yearPublished = "1925" },
            new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", yearPublished = "1813" },
            new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", yearPublished = "1951" }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }
    }
}
