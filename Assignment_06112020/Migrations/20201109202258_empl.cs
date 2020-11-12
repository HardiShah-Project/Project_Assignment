using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_06112020.Migrations
{
    public partial class empl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Skils = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "EmpProjects",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Technologies = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpProjects", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkilName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "EmpProjects",
                columns: new[] { "Code", "EndDate", "Name", "StartDate", "Technologies" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 12, 0, 5, 0, 0, DateTimeKind.Unspecified), "John", new DateTime(2019, 1, 10, 0, 3, 0, 0, DateTimeKind.Unspecified), ".NET" },
                    { 2, new DateTime(2021, 1, 18, 0, 8, 0, 0, DateTimeKind.Unspecified), "Chris", new DateTime(2020, 1, 5, 0, 2, 0, 0, DateTimeKind.Unspecified), "Angular" },
                    { 3, new DateTime(2022, 1, 20, 0, 4, 0, 0, DateTimeKind.Unspecified), "Mukesh", new DateTime(2019, 1, 7, 0, 3, 0, 0, DateTimeKind.Unspecified), "React" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Code", "JoiningDate", "Name", "ReleaseDate", "Skils" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 10, 0, 3, 0, 0, DateTimeKind.Unspecified), "John", new DateTime(2021, 1, 12, 0, 5, 0, 0, DateTimeKind.Unspecified), ".NET" },
                    { 2, new DateTime(2020, 1, 5, 0, 2, 0, 0, DateTimeKind.Unspecified), "Chris", new DateTime(2021, 1, 10, 0, 8, 0, 0, DateTimeKind.Unspecified), "Angular" },
                    { 3, new DateTime(2019, 1, 7, 0, 3, 0, 0, DateTimeKind.Unspecified), "Mukesh", new DateTime(2022, 1, 2, 0, 4, 0, 0, DateTimeKind.Unspecified), "React" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "ID", "SkilName" },
                values: new object[,]
                {
                    { 1, ".NET" },
                    { 2, "Angular" },
                    { 3, "React" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "EmpProjects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
