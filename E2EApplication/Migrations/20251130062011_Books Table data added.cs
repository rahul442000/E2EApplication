using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E2EApplication.Migrations
{
    /// <inheritdoc />
    public partial class BooksTabledataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BooksData",
                columns: new[] { "id", "author", "title", "yearPublished" },
                values: new object[,]
                {
                    { 1, "George Orwell", "Mount Fuji 1984", "1949" },
                    { 2, "Harper Lee", "To Kill a Mocking,ird", "1960" },
                    { 3, "F. Scott Fitzgerald", "The Great Gatsby", "1925" },
                    { 4, "Jane Austen", "Pride and Prejudice", "1813" },
                    { 5, "J.D. Salinger", "The Catcher in the Rye", "1951" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksData",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BooksData",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BooksData",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BooksData",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BooksData",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
