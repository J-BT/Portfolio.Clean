using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Clean.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration230929_ProjectModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactEmailObject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmailContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmailSender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEmails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PCLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PCLogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectTitleFr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTitleJp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectDescriptionFr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescriptionJp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectGithub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ContactEmails",
                columns: new[] { "Id", "ContactEmailContent", "ContactEmailObject", "ContactEmailSender", "CreationDate", "LastUpdate" },
                values: new object[] { 1, "This first ContactEmail is a test for db initialization", "Initialization test", "Configuration", new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.InsertData(
                table: "PCLogs",
                columns: new[] { "Id", "CreationDate", "LastUpdate", "PCLogContent" },
                values: new object[] { 1, new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(5528), "This first PCLog is a test for db initialization" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreationDate", "LastUpdate", "ProjectDescriptionEn", "ProjectDescriptionFr", "ProjectDescriptionJp", "ProjectGithub", "ProjectName", "ProjectTechnologies", "ProjectTitleEn", "ProjectTitleFr", "ProjectTitleJp", "ProjectUrl", "ProjectVideo" },
                values: new object[] { 1, new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 9, 29, 12, 30, 15, 557, DateTimeKind.Local).AddTicks(6071), "The database is working", "La base de données fonctionne", "データベースが発動されました", null, "This first Project is a test for db initialization", "C#,Blazor", "Test Project", "Projet Test", "テストプロジェクト", null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactEmails");

            migrationBuilder.DropTable(
                name: "PCLogs");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
