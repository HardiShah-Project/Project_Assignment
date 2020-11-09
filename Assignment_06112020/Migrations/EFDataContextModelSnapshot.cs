﻿// <auto-generated />
using System;
using Assignment_06112020.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment_06112020.Migrations
{
    [DbContext(typeof(EFDataContext))]
    partial class EFDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment_06112020.Models.EmpProject", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Technologies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("EmpProjects");

                    b.HasData(
                        new
                        {
                            Code = "001",
                            EndDate = new DateTime(2021, 1, 12, 0, 5, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            StartDate = new DateTime(2019, 1, 10, 0, 3, 0, 0, DateTimeKind.Unspecified),
                            Technologies = ".NET"
                        },
                        new
                        {
                            Code = "002",
                            EndDate = new DateTime(2021, 1, 18, 0, 8, 0, 0, DateTimeKind.Unspecified),
                            Name = "Chris",
                            StartDate = new DateTime(2020, 1, 5, 0, 2, 0, 0, DateTimeKind.Unspecified),
                            Technologies = "Angular"
                        },
                        new
                        {
                            Code = "003",
                            EndDate = new DateTime(2022, 1, 20, 0, 4, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mukesh",
                            StartDate = new DateTime(2019, 1, 7, 0, 3, 0, 0, DateTimeKind.Unspecified),
                            Technologies = "React"
                        });
                });

            modelBuilder.Entity("Assignment_06112020.Models.Employee", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Skils")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Code = "001",
                            JoiningDate = new DateTime(2019, 1, 10, 0, 3, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            ReleaseDate = new DateTime(2021, 1, 12, 0, 5, 0, 0, DateTimeKind.Unspecified),
                            Skils = ".NET"
                        },
                        new
                        {
                            Code = "002",
                            JoiningDate = new DateTime(2020, 1, 5, 0, 2, 0, 0, DateTimeKind.Unspecified),
                            Name = "Chris",
                            ReleaseDate = new DateTime(2021, 1, 10, 0, 8, 0, 0, DateTimeKind.Unspecified),
                            Skils = "Angular"
                        },
                        new
                        {
                            Code = "003",
                            JoiningDate = new DateTime(2019, 1, 7, 0, 3, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mukesh",
                            ReleaseDate = new DateTime(2022, 1, 2, 0, 4, 0, 0, DateTimeKind.Unspecified),
                            Skils = "React"
                        });
                });

            modelBuilder.Entity("Assignment_06112020.Models.Skill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SkilName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            SkilName = ".NET"
                        },
                        new
                        {
                            ID = 2,
                            SkilName = "Angular"
                        },
                        new
                        {
                            ID = 3,
                            SkilName = "React"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
