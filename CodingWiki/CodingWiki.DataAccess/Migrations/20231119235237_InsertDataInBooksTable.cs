using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InsertDataInBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "123B12", 10.00m, "Spider Man" },
                    { 2, "123B13", 12.00m, "He-man and the universe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
