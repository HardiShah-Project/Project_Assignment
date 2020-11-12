using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_06112020.Migrations
{
    public partial class search : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"Create PROCEDURE sp_GetEmployeeSearch
            @DisplayLength int,
            @DisplayStart int,
            @SortCol int,
            @SortDir nvarchar(10),
            @Search nvarchar(255) = NULL
          as
          begin
         Declare @FirstRec int, @LastRec int
         Set @FirstRec = @DisplayStart;
         Set @LastRec = @DisplayStart + @DisplayLength;

            With CTE as
            (
             Select ROW_NUMBER() over(order by 
  
                 case when(@SortCol = 0 and @SortDir = 'asc')
                   then Code
                   end asc,
                   case when(@SortCol = 0 and @SortDir = 'desc')           
                   then Code
                   end desc,
             
                  case when(@SortCol = 1 and @SortDir = 'asc')
                   then Name
                   end asc,
                   case when(@SortCol = 1 and @SortDir = 'desc')
                       then Name
                   end desc,
           
                case when(@SortCol = 2 and @SortDir = 'asc')
                       then JoiningDate
                   end asc,
                   case when(@SortCol = 2 and @SortDir = 'desc')
                       then JoiningDate
                   end desc,
           
                case when(@SortCol = 3 and @SortDir = 'asc')
                       then ReleaseDate
                   end asc,
                   case when(@SortCol = 3 and @SortDir = 'desc')
                       then ReleaseDate
                   end desc,
          
                case when(@SortCol = 4 and @SortDir = 'asc')
                       then Skils
                   end asc,
                   case when(@SortCol = 4 and @SortDir = 'desc')
                       then Skils
                   end desc)
             as RowNum,
              COUNT(*) over() as TotalCount,
              Code,
              Name,
              JoiningDate,
              ReleaseDate
              from Employees
              where(@Search IS NULL
                Or Code like '%' + @Search + '%'
                Or Name like '%' + @Search + '%'
                Or JoiningDate like '%' + @Search + '%'
                Or ReleaseDate like '%' + @Search + '%'
                Or Skils like '%' + @Search + '%')
 )
 Select*
 from CTE
 where RowNum > @FirstRec and RowNum <= @LastRec
end";
            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"Drop Procedure sp_GetEmployeeSearch";
            migrationBuilder.Sql(sp);

        }
    }
}
