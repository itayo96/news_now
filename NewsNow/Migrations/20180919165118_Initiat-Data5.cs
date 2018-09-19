using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class InitiatData5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ID", "CategoryId", "DetailedContent", "DetailedHeader", "HomeContent", "HomeHeader", "HomeImage" },
                values: new object[] { 2, 1, null, null, "A text describing this article", "blah blah", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
