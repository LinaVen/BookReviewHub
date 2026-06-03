using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookReviewHub.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Science Fiction" },
                    { 3, "Mystery" },
                    { 4, "Romance" },
                    { 5, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", 1, "Book 1 - Genre 1" },
                    { 2, "Author 2", 1, "Book 2 - Genre 1" },
                    { 3, "Author 3", 1, "Book 3 - Genre 1" },
                    { 4, "Author 4", 1, "Book 4 - Genre 1" },
                    { 5, "Author 5", 1, "Book 5 - Genre 1" },
                    { 6, "Author 6", 2, "Book 1 - Genre 2" },
                    { 7, "Author 7", 2, "Book 2 - Genre 2" },
                    { 8, "Author 8", 2, "Book 3 - Genre 2" },
                    { 9, "Author 9", 2, "Book 4 - Genre 2" },
                    { 10, "Author 10", 2, "Book 5 - Genre 2" },
                    { 11, "Author 11", 3, "Book 1 - Genre 3" },
                    { 12, "Author 12", 3, "Book 2 - Genre 3" },
                    { 13, "Author 13", 3, "Book 3 - Genre 3" },
                    { 14, "Author 14", 3, "Book 4 - Genre 3" },
                    { 15, "Author 15", 3, "Book 5 - Genre 3" },
                    { 16, "Author 16", 4, "Book 1 - Genre 4" },
                    { 17, "Author 17", 4, "Book 2 - Genre 4" },
                    { 18, "Author 18", 4, "Book 3 - Genre 4" },
                    { 19, "Author 19", 4, "Book 4 - Genre 4" },
                    { 20, "Author 20", 4, "Book 5 - Genre 4" },
                    { 21, "Author 21", 5, "Book 1 - Genre 5" },
                    { 22, "Author 22", 5, "Book 2 - Genre 5" },
                    { 23, "Author 23", 5, "Book 3 - Genre 5" },
                    { 24, "Author 24", 5, "Book 4 - Genre 5" },
                    { 25, "Author 25", 5, "Book 5 - Genre 5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
