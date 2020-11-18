using Microsoft.EntityFrameworkCore;
using System;
namespace Assignment_06112020.Models
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpProject> EmpProjects { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Code = 1, Name = "John", JoiningDate = DateTime.ParseExact("10/03/2019", "dd/mm/yyyy", null), ReleaseDate = DateTime.ParseExact("12/05/2021", "dd/mm/yyyy", null), Skils = ".NET" },
                new Employee() { Code = 2, Name = "Chris", JoiningDate = DateTime.ParseExact("05/02/2020", "dd/mm/yyyy", null), ReleaseDate = DateTime.ParseExact("10/08/2021", "dd/mm/yyyy", null), Skils = "Angular" },
                new Employee() { Code = 3, Name = "Mukesh", JoiningDate = DateTime.ParseExact("07/03/2019", "dd/mm/yyyy", null), ReleaseDate = DateTime.ParseExact("02/04/2022", "dd/mm/yyyy", null), Skils = "React" });

            modelBuilder.Entity<Skill>().HasData(
                new Skill() { ID = 1, SkilName = ".NET" },
                new Skill() { ID = 2, SkilName = "Angular" },
                new Skill() { ID = 3, SkilName = "React" });

            modelBuilder.Entity<EmpProject>().HasData(
                new EmpProject() { Code = 1, Name = "John", StartDate = DateTime.ParseExact("10/03/2019", "dd/mm/yyyy", null), EndDate = DateTime.ParseExact("12/05/2021", "dd/mm/yyyy", null), Technologies = ".NET" },
                new EmpProject() { Code = 2, Name = "Chris", StartDate = DateTime.ParseExact("05/02/2020", "dd/mm/yyyy", null), EndDate = DateTime.ParseExact("18/08/2021", "dd/mm/yyyy", null), Technologies = "Angular" },
                new EmpProject() { Code = 3, Name = "Mukesh", StartDate = DateTime.ParseExact("07/03/2019", "dd/mm/yyyy", null), EndDate = DateTime.ParseExact("20/04/2022", "dd/mm/yyyy", null), Technologies = "React" });
        }
    }
}


