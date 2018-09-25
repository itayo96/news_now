using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class ArticlesLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Articles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 583, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                columns: new[] { "DateCreated", "Location" },
                values: new object[] { new DateTime(2018, 9, 25, 11, 0, 58, 586, DateTimeKind.Local), "תל אביב, ישראל" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 565, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 9, 25, 1, 24, 17, 567, DateTimeKind.Local));
        }
    }
}
