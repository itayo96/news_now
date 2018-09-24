using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class Changesimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 13, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "DateCreated", "HomeImageUrl" },
                values: new object[] { new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local), "https://images.haarets.co.il/image/upload/w_2184,h_1270,x_0,y_75,c_crop,g_north_west/w_857,h_482,q_auto,c_fill,f_auto/fl_any_format.preserve_transparency.progressive:none/v1537691679/1.6494059.1232180831.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 1, 2, 40, 14, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 7, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "DateCreated", "HomeImageUrl" },
                values: new object[] { new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local), "https://www.jpost.com/HttpHandlers/ShowImage.ashx?id=350908&w=898&h=628" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 9, 24, 0, 57, 35, 9, DateTimeKind.Local));
        }
    }
}
