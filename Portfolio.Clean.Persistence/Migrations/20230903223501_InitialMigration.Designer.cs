﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Clean.Persistence.DatabaseContext;

#nullable disable

namespace Portfolio.Clean.Persistence.Migrations
{
    [DbContext(typeof(PortfolioDatabaseContext))]
    [Migration("20230903223501_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Portfolio.Clean.Domain.ContactEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactEmailContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmailObject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmailSender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ContactEmails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactEmailContent = "This first ContactEmail is a test for db initialization",
                            ContactEmailObject = "Initialization test",
                            ContactEmailSender = "Configuration",
                            CreationDate = new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(6446),
                            LastUpdate = new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(6390)
                        });
                });

            modelBuilder.Entity("Portfolio.Clean.Domain.PCLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PCLogContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PCLogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(8672),
                            LastUpdate = new DateTime(2023, 9, 4, 0, 35, 1, 307, DateTimeKind.Local).AddTicks(8651),
                            PCLogContent = "This first PCLog is a test for db initialization"
                        });
                });

            modelBuilder.Entity("Portfolio.Clean.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectGithub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProjectScreenshots")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProjectTechnologies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectVideo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 9, 4, 0, 35, 1, 308, DateTimeKind.Local).AddTicks(772),
                            LastUpdate = new DateTime(2023, 9, 4, 0, 35, 1, 308, DateTimeKind.Local).AddTicks(754),
                            ProjectName = "This first Project is a test for db initialization",
                            ProjectTechnologies = "C#,Blazor"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
