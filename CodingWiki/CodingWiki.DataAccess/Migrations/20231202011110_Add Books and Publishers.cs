using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodingWiki.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddBooksandPublishers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublisherId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublisherId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Chicago", "Pub1 Jimmy" },
                    { 2, "NewYork", "Pub2 John" },
                    { 3, "Hawaii", "Pub3 Ben" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "ISBN", "Price", "PublisherId", "Title" },
                values: new object[,]
                {
                    { 3, "123B14", 10.00m, 2, "Fake Sunday" },
                    { 4, "123B15", 10.00m, 2, "Cookie Jar" },
                    { 5, "123B16", 10.00m, 3, "Cloudy Forest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 1,
                column: "PublisherId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ID",
                keyValue: 2,
                column: "PublisherId",
                value: 0);
        }
    }
}
