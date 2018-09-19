using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class InitiatData9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "HomeContent", "HomeHeader" },
                values: new object[] { "Test 1", "First post" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "HomeContent", "HomeHeader" },
                values: new object[] { "Test 2", "Second post" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "HomeContent", "HomeHeader" },
                values: new object[] { "A text describing this article", "Watch: Attack in Syria" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "HomeContent", "HomeHeader" },
                values: new object[] { "A text describing this article", "blah blah" });
        }
    }
}
