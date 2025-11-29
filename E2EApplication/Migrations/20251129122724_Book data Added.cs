using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E2EApplication.Migrations
{
    /// <inheritdoc />
    public partial class BookdataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1,
                column: "title",
                value: "Mount Fuji 1984");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1,
                column: "title",
                value: "1984");
        }
    }
}
