using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCRUD.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[,]
                {
                    { 1, "This is sample content for Post 1.", "Post 1" },
                    { 2, "This is sample content for Post 2.", "Post 2" },
                    { 3, "This is sample content for Post 3.", "Post 3" },
                    { 4, "This is sample content for Post 4.", "Post 4" },
                    { 5, "This is sample content for Post 5.", "Post 5" },
                    { 6, "This is sample content for Post 6.", "Post 6" },
                    { 7, "This is sample content for Post 7.", "Post 7" },
                    { 8, "This is sample content for Post 8.", "Post 8" },
                    { 9, "This is sample content for Post 9.", "Post 9" },
                    { 10, "This is sample content for Post 10.", "Post 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
