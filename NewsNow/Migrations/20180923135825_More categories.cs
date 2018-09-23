using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Morecategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DetailedContent" },
                values: new object[] { new DateTime(2018, 9, 23, 16, 58, 25, 66, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 68, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "World");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "Politics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "Buisness");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 4, "Sports" },
                    { 5, "Colture" },
                    { 6, "Opinions" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DetailedContent" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 18, 57, 879, DateTimeKind.Local), "123" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Name",
                value: "News");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Name",
                value: "Sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Name",
                value: "Politics");
        }
    }
}
