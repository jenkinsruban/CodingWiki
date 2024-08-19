using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Books_ID",
                table: "BookDetails");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BookDetails",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookDetails_ID",
                table: "BookDetails",
                newName: "IX_BookDetails_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Books_BookId",
                table: "BookDetails",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Books_BookId",
                table: "BookDetails");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookDetails",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                newName: "IX_BookDetails_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Books_ID",
                table: "BookDetails",
                column: "ID",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
