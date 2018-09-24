using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Addedcategorycoloranddescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorARGB",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 687, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 22, 23, 48, 688, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "ColorARGB", "Description" },
                values: new object[] { -15132304, "World wide news" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "ColorARGB", "Description" },
                values: new object[] { -7667573, "Debates and conflicts" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "ColorARGB", "Description" },
                values: new object[] { -16751616, "Trade, commerce and money" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "ColorARGB", "Description" },
                values: new object[] { -7667712, "And its a score!" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "ColorARGB", "Description", "Name" },
                values: new object[] { -2354116, "Music, movies and the starts", "Culture" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "ColorARGB", "Description" },
                values: new object[] { -13726889, "I Think..." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorARGB",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 23, 16, 58, 25, 66, DateTimeKind.Local));

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
                keyValue: 5,
                column: "Name",
                value: "Colture");
        }
    }
}
