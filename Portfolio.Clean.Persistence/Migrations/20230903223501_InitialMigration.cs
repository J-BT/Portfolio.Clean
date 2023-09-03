using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Clean.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    ProjectTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectScreenshots = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
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
                values: new object[] { 1, "This first ContactEmail is a test for db initialization", "Initialization test", "Configuration", new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.InsertData(
                table: "PCLogs",
                columns: new[] { "Id", "CreationDate", "LastUpdate", "PCLogContent" },
                values: new object[] { 1, new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(8651), "This first PCLog is a test for db initialization" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreationDate", "LastUpdate", "ProjectGithub", "ProjectName", "ProjectScreenshots", "ProjectTechnologies", "ProjectUrl", "ProjectVideo" },
                values: new object[] { 1, new DateTime(2023, 9, 4, 0, 35, 1, 308, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 9, 4, 0, 35, 1, 308, DateTimeKind.Local).AddTicks(754), null, "This first Project is a test for db initialization", null, "C#,Blazor", null, null });
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
