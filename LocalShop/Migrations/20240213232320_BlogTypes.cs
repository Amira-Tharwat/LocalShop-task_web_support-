using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocalShop.Migrations
{
    /// <inheritdoc />
    public partial class BlogTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "blogTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "comedy" },
                    { 2, "romantic" },
                    { 3, "horror" },
                    { 4, "scientific" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blogTypes");
        }
    }
}
