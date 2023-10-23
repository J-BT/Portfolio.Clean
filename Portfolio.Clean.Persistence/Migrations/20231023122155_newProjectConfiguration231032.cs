using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Clean.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newProjectConfiguration231032 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContactEmails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(902), new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "PCLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(1701), new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdate", "ProjectName", "ProjectTechnologies" },
                values: new object[] { new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(2241), "test1", "csharp,blazor, webassembly, html, css, iis" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreationDate", "LastUpdate", "ProjectDescriptionEn", "ProjectDescriptionFr", "ProjectDescriptionJp", "ProjectGithub", "ProjectName", "ProjectTechnologies", "ProjectTitleEn", "ProjectTitleFr", "ProjectTitleJp", "ProjectUrl", "ProjectVideo" },
                values: new object[] { 2, new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 10, 23, 14, 21, 55, 765, DateTimeKind.Local).AddTicks(2248), "The database is working", "La base de données fonctionne", "データベースが発動されました", null, "test2", "Csharp, Typescript, Angular, HTML, CSS, IIS", "Test Project 2", "Projet Test 2", "テストプロジェクト 2", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "ContactEmails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "PCLogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdate" },
                values: new object[] { new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "LastUpdate", "ProjectName", "ProjectTechnologies" },
                values: new object[] { new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(6071), "This first Project is a test for db initialization", "C#,Blazor" });
        }
    }
}
