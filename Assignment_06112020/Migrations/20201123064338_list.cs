using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_06112020.Migrations
{
    public partial class list : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skils",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "Emp_Id",
                table: "EmpProjects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "EmpProjects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "employeeLists",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    JoiningDate = table.Column<DateTime>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Skils = table.Column<string>(nullable: false),
                    ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeLists", x => x.Code);
                });

            migrationBuilder.InsertData(
                table: "employeeLists",
                columns: new[] { "Code", "ID", "JoiningDate", "Name", "ReleaseDate", "Skils" },
                values: new object[] { 1, null, new DateTime(2019, 1, 10, 0, 3, 0, 0, DateTimeKind.Unspecified), "John", new DateTime(2021, 1, 12, 0, 5, 0, 0, DateTimeKind.Unspecified), ".NET" });

            migrationBuilder.InsertData(
                table: "employeeLists",
                columns: new[] { "Code", "ID", "JoiningDate", "Name", "ReleaseDate", "Skils" },
                values: new object[] { 2, null, new DateTime(2020, 1, 5, 0, 2, 0, 0, DateTimeKind.Unspecified), "Chris", new DateTime(2021, 1, 18, 0, 8, 0, 0, DateTimeKind.Unspecified), "Angular" });

            migrationBuilder.InsertData(
                table: "employeeLists",
                columns: new[] { "Code", "ID", "JoiningDate", "Name", "ReleaseDate", "Skils" },
                values: new object[] { 3, null, new DateTime(2019, 1, 7, 0, 3, 0, 0, DateTimeKind.Unspecified), "Mukesh", new DateTime(2022, 1, 20, 0, 4, 0, 0, DateTimeKind.Unspecified), "React" });

            migrationBuilder.CreateIndex(
                name: "IX_EmpProjects_Emp_Id",
                table: "EmpProjects",
                column: "Emp_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpProjects_Employees_Emp_Id",
                table: "EmpProjects",
                column: "Emp_Id",
                principalTable: "Employees",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_EmpProjects_ID",
                table: "Skills",
                column: "ID",
                principalTable: "EmpProjects",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Employees_ID",
                table: "Skills",
                column: "ID",
                principalTable: "Employees",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_employeeLists_ID",
                table: "Skills",
                column: "ID",
                principalTable: "employeeLists",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpProjects_Employees_Emp_Id",
                table: "EmpProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_EmpProjects_ID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Employees_ID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_employeeLists_ID",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "employeeLists");

            migrationBuilder.DropIndex(
                name: "IX_EmpProjects_Emp_Id",
                table: "EmpProjects");

            migrationBuilder.DropColumn(
                name: "Emp_Id",
                table: "EmpProjects");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "EmpProjects");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Skils",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 1,
                column: "Skils",
                value: ".NET");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 2,
                column: "Skils",
                value: "Angular");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 3,
                column: "Skils",
                value: "React");
        }
    }
}
