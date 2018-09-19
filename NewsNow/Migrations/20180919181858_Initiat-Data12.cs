using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsNow.Migrations
{
    public partial class InitiatData12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 18, 57, 879, DateTimeKind.Local), "https://i.ytimg.com/vi/R_iYQlMw0r0/maxresdefault.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local), "http://www.bworldonline.com/wp-content/uploads/2018/02/Megaworld-Westside-City.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local), "https://3c1703fe8d.site.internapcdn.net/newman/gfx/news/hires/2017/whatisspacet.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 18, 57, 880, DateTimeKind.Local), "https://sportshub.cbsistatic.com/i/r/2018/07/15/31f520b7-cad4-48f7-8509-485d51cfb90a/thumbnail/370x208/26c493f4ffe1ad85aea04580c4eb45bb/lionel-messi-argentina.jpg" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 4, 19, 254, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "DateCreated", "HomeImage" },
                values: new object[] { new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 9, 19, 21, 4, 19, 256, DateTimeKind.Local));
        }
    }
}
