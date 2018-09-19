using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Sepretadhomeanddetailedviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Article",
                newName: "PageHeader");

            migrationBuilder.AddColumn<string>(
                name: "HomeContent",
                table: "Article",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeHeader",
                table: "Article",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PageContent",
                table: "Article",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeContent",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "HomeHeader",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "PageContent",
                table: "Article");

            migrationBuilder.RenameColumn(
                name: "PageHeader",
                table: "Article",
                newName: "Header");
        }
    }
}
