using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class DBchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "DetailedContent",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "HomeImage",
                table: "Articles",
                newName: "Summery");

            migrationBuilder.RenameColumn(
                name: "HomeHeader",
                table: "Articles",
                newName: "HomeImageUrl");

            migrationBuilder.RenameColumn(
                name: "HomeContent",
                table: "Articles",
                newName: "Header");

            migrationBuilder.RenameColumn(
                name: "DetailedHeader",
                table: "Articles",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Summery",
                table: "Articles",
                newName: "HomeImage");

            migrationBuilder.RenameColumn(
                name: "HomeImageUrl",
                table: "Articles",
                newName: "HomeHeader");

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Articles",
                newName: "HomeContent");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Articles",
                newName: "DetailedHeader");

            migrationBuilder.AddColumn<string>(
                name: "DetailedContent",
                table: "Articles",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "DateCreated", "DetailedContent", "DetailedHeader", "HomeContent", "HomeHeader", "HomeImage" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2018, 9, 23, 22, 23, 48, 687, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Targets in Syria: Bombs", "https://i.ytimg.com/vi/R_iYQlMw0r0/maxresdefault.jpg" },
                    { 2, 1, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "\"West side is a prison\"", "http://www.bworldonline.com/wp-content/uploads/2018/02/Megaworld-Westside-City.jpg" },
                    { 3, 1, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "The Israeli startups in space", "https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2017/whatisspacet.jpg" },
                    { 4, 2, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "1:0 on Raanana vs Kaka", "https://sportshub.cbsistatic.com/i/r/2018/07/15/31f520b7-cad4-48f7-8509-485d51cfb90a/thumbnail/370x208/26c493f4ffe1ad85aea04580c4eb45bb/lionel-messi-argentina.jpg" },
                    { 5, 2, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 6, 2, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 7, 3, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 8, 3, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 9, 3, new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null }
                });
        }
    }
}
