using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_06112020.Migrations
{
    public partial class xyz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_employeeLists_ID",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "employeeLists");

            migrationBuilder.DropColumn(
                name: "Technologies",
                table: "EmpProjects");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "EmpProjects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EmpProjects",
                keyColumn: "Code",
                keyValue: 1,
                column: "ID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EmpProjects",
                keyColumn: "Code",
                keyValue: 2,
                column: "ID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "EmpProjects",
                keyColumn: "Code",
                keyValue: 3,
                column: "ID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 1,
                column: "ID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 2,
                column: "ID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 3,
                column: "ID",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "EmpProjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Technologies",
                table: "EmpProjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "employeeLists",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID = table.Column<int>(type: "int", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Skils = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeLists", x => x.Code);
                });

            migrationBuilder.UpdateData(
                table: "EmpProjects",
                keyColumn: "Code",
                keyValue: 1,
                columns: new[] { "ID", "Technologies" },
                values: new object[] { null, ".NET" });

            migrationBuilder.UpdateData(
                table: "EmpProjects",
                keyColumn: "Code",
                keyValue: 2,
                columns: new[] { "ID", "Technologies" },
                values: new object[] { null, "Angular" });

            migrationBuilder.UpdateData(
                table: "EmpProjects",
                keyColumn: "Code",
                keyValue: 3,
                columns: new[] { "ID", "Technologies" },
                values: new object[] { null, "React" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 1,
                column: "ID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 2,
                column: "ID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Code",
                keyValue: 3,
                column: "ID",
                value: null);

            migrationBuilder.InsertData(
                table: "employeeLists",
                columns: new[] { "Code", "ID", "JoiningDate", "Name", "ReleaseDate", "Skils" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2019, 1, 10, 0, 3, 0, 0, DateTimeKind.Unspecified), "John", new DateTime(2021, 1, 12, 0, 5, 0, 0, DateTimeKind.Unspecified), ".NET" },
                    { 2, null, new DateTime(2020, 1, 5, 0, 2, 0, 0, DateTimeKind.Unspecified), "Chris", new DateTime(2021, 1, 18, 0, 8, 0, 0, DateTimeKind.Unspecified), "Angular" },
                    { 3, null, new DateTime(2019, 1, 7, 0, 3, 0, 0, DateTimeKind.Unspecified), "Mukesh", new DateTime(2022, 1, 20, 0, 4, 0, 0, DateTimeKind.Unspecified), "React" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_employeeLists_ID",
                table: "Skills",
                column: "ID",
                principalTable: "employeeLists",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
