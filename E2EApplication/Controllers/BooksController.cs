using E2EApplication.Data;
using E2EApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace E2EApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        /*static List<Book> books = new List<Book>
        {
            new Book { id = 1, title = "1984", author = "George Orwell", yearPublished = "1949" },
            new Book { id = 2, title = "To Kill a Mocking,ird", author = "Harper Lee", yearPublished = "1960" },
            new Book { id = 3, title = "The Great Gatsby", author = "F. Scott Fitzgerald", yearPublished = "1925" },
            new Book { id = 4, title = "Pride and Prejudice", author = "Jane Austen", yearPublished = "1813" },
            new Book { id = 5, title = "The Catcher in the Rye", author = "J.D. Salinger", yearPublished = "1951" }
        };*/

        private readonly BookAPIContext _context;
        public BooksController(BookAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return Ok(await _context.BooksData.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _context.BooksData.FindAsync(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }
        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book newBook)
        {
            if (newBook == null || string.IsNullOrEmpty(newBook.title) || string.IsNullOrEmpty(newBook.author) || string.IsNullOrEmpty(newBook.yearPublished))
            {
                return BadRequest("Invalid book data.");
            }
            _context.BooksData.Add(newBook);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.id }, newBook);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> UpdateBook(int id, Book updatedBook)
        {
            var existingBook = await _context.BooksData.FindAsync(id);
            if (existingBook == null)
            {
                return NotFound();
            }
            existingBook.title = updatedBook.title;
            existingBook.author = updatedBook.author;
            existingBook.yearPublished = updatedBook.yearPublished;
            await _context.SaveChangesAsync();
            return Ok(existingBook);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            var book = await _context.BooksData.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.BooksData.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }



        /*        ** Apis with in-memory data storage ** 
         *        
         *        [HttpGet("{id}")]
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
                public ActionResult<Book> UpdateBook(int id, Book updatedBook)
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
        */
    }
}
