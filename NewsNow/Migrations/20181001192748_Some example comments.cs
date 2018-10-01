using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Someexamplecomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sequence",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 439, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 22, 27, 48, 441, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "Author", "Content", "Sequence" },
                values: new object[] { "The one who knows", "Example content for an example comment", 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "Author", "Content", "Sequence" },
                values: new object[] { "Voldemort", "Multi line comment!\nI think this is an example comment", 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "ArticleId", "Author", "Content", "Sequence" },
                values: new object[] { 3, 1, "Jimmi", "Example content for an example comment", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Sequence",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 213, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 10, 1, 21, 14, 8, 215, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "Author", "Content" },
                values: new object[] { "abc", "example" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "Author", "Content" },
                values: new object[] { "123", "example2" });
        }
    }
}
