using E2EApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace E2EApplication.Data
{
    public class BookAPIContext: DbContext
    {
        public BookAPIContext (DbContextOptions<BookAPIContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book {id = 1, title = "Mount Fuji 1984", author = "George Orwell", yearPublished = "1949" },
                new Book { id = 2, title = "To Kill a Mocking,ird", author = "Harper Lee", yearPublished = "1960" },
                new Book { id = 3, title = "The Great Gatsby", author = "F. Scott Fitzgerald", yearPublished = "1925" },
                new Book { id = 4, title = "Pride and Prejudice", author = "Jane Austen", yearPublished = "1813" },
                new Book { id = 5, title = "The Catcher in the Rye", author = "J.D. Salinger", yearPublished = "1951" }
            );
        }  
        public DbSet<Book> BooksData { get; set; }
    }
}
