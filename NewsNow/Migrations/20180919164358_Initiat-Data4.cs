using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class InitiatData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoryID",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Articles",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategoryID",
                table: "Articles",
                newName: "IX_Articles_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoryId",
                table: "Articles",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Categories_CategoryId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Articles",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                newName: "IX_Articles_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Categories_CategoryID",
                table: "Articles",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
