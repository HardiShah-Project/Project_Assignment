using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_06112020.Migrations
{
    public partial class sp_GetEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE sp_GetEmployee                  
                AS
                BEGIN                   
                    select * from Employees
                END";
            migrationBuilder.Sql(sp);

            var proc = @"create procedure sp_AddEmployee
                @Name nvarchar(25),
                @JoiningDate datetime,
                @ReleaseDate datetime,
                @Skils varchar(25)
               as  
               begin  
                    INSERT INTO Employees
                    (Name,JoiningDate,ReleaseDate, Skils)
                    VALUES (@Name, @JoiningDate, @ReleaseDate,@Skils)
                End";

            migrationBuilder.Sql(proc);

            var edit = @"Create Procedure sp_UpdateEmployee
                   @Code int,
                   @Name varchar(25),
                   @JoiningDate datetime,
                   @ReleaseDate datetime,
                   @Skils varchar(25)
                  as
                  begin
                       Update Employees
                       set Name = @Name,
                       JoiningDate = @JoiningDate,
                       ReleaseDate = @ReleaseDate,
                       Skils=@Skils
                       where Code = @Code
                   End";
            migrationBuilder.Sql(edit);

            var del= @"Create procedure sp_DeleteEmployee
                  @Code int     
                as
                begin
                   Delete from Employee where Code = @Code
                End";
            migrationBuilder.Sql(del);
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"Drop Procedure sp_GetEmployee";
            migrationBuilder.Sql(sp);

            var proc = @"Drop Procedure sp_AddEmployee";
            migrationBuilder.Sql(proc);

            var edit = @"Drop Procedure sp_UpdateEmployee";
            migrationBuilder.Sql(edit);

            var del = @"Drop Procedure sp_DeleteEmployee";
            migrationBuilder.Sql(del);
        }
    }
}
