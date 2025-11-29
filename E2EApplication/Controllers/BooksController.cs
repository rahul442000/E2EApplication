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
            new Book { id = 1, title = "1984", author = "George Orwell", yearPublished = "1949" },
            new Book { id = 2, title = "To Kill a Mocking,ird", author = "Harper Lee", yearPublished = "1960" },
            new Book { id = 3, title = "The Great Gatsby", author = "F. Scott Fitzgerald", yearPublished = "1925" },
            new Book { id = 4, title = "Pride and Prejudice", author = "Jane Austen", yearPublished = "1813" },
            new Book { id = 5, title = "The Catcher in the Rye", author = "J.D. Salinger", yearPublished = "1951" }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = books.FirstOrDefault(b => b.id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }   

        [HttpPost]
        public ActionResult<Book> AddBook(Book newBook)
        {
            if(newBook == null || string.IsNullOrEmpty(newBook.title) || string.IsNullOrEmpty(newBook.author) || string.IsNullOrEmpty(newBook.yearPublished))
            {
                return BadRequest("Invalid book data.");
            }
            newBook.id = books.Max(b => b.id) + 1;
            books.Add(newBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.id }, newBook);
        }                
        
        [HttpPut("{id}")]
        public ActionResult<Book> UpdateBook(Book updateBook)
        {
            var existingBook = books.FirstOrDefault(b => b.id == updateBook.id);
            if (existingBook == null)
            {
                return NotFound();
            }
            existingBook.title = updateBook.title;
            existingBook.author = updateBook.author;
            existingBook.yearPublished = updateBook.yearPublished;
            return Ok(existingBook);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.id == id);
            if (book == null)
            {
                return NotFound();
            }
            books.Remove(book);
            return NoContent();
        }
    }
}
