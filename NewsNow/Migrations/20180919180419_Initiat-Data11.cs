using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class InitiatData11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "HomeContent", "HomeHeader" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 4, 19, 254, DateTimeKind.Local), "This is the description of an article. Read more.", "Targets in Syria: Bombs" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "DateCreated", "HomeContent", "HomeHeader" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), "This is the description of an article. Read more.", "\"West side is a prison\"" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "DateCreated", "DetailedContent", "DetailedHeader", "HomeContent", "HomeHeader", "HomeImage" },
                values: new object[] { 3, 1, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "The Israeli startups in space", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "News");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 2, "Sports" },
                    { 3, "Politics" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "DateCreated", "DetailedContent", "DetailedHeader", "HomeContent", "HomeHeader", "HomeImage" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "1:0 on Raanana vs Kaka", null },
                    { 5, 2, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 6, 2, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 7, 3, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 8, 3, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null },
                    { 9, 3, new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null, null, "This is the description of an article. Read more.", "Dummy article", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "HomeContent", "HomeHeader" },
                values: new object[] { new DateTime(2018, 9, 19, 20, 28, 4, 846, DateTimeKind.Local), "Test 1", "First post" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "DateCreated", "HomeContent", "HomeHeader" },
                values: new object[] { new DateTime(2018, 9, 19, 20, 28, 4, 847, DateTimeKind.Local), "Test 2", "Second post" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "Politics");
        }
    }
}
