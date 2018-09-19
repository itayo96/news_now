using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Addedhomeimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PageHeader",
                table: "Article",
                newName: "HomeImage");

            migrationBuilder.RenameColumn(
                name: "PageContent",
                table: "Article",
                newName: "DetailedHeader");

            migrationBuilder.AddColumn<string>(
                name: "DetailedContent",
                table: "Article",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedContent",
                table: "Article");

            migrationBuilder.RenameColumn(
                name: "HomeImage",
                table: "Article",
                newName: "PageHeader");

            migrationBuilder.RenameColumn(
                name: "DetailedHeader",
                table: "Article",
                newName: "PageContent");
        }
    }
}
