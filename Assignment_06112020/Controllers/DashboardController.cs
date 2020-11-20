using System.Collections.Generic;
using System.Linq;
using Assignment_06112020.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_06112020.Controllers
{
    public class DashboardController : Controller
    {
        private readonly EFDataContext context;

        public DashboardController(EFDataContext _context)
        {
            context = _context;
        }
        public ActionResult Dashboard()
        {
            ViewBag.CountEmployees = context.Employees.Count();
            ViewBag.CountProjects = context.EmpProjects.Count();
            return View();
        }
        public ActionResult GetDetails()
        {
            List<Employee> result = null;
            result = context.Employees.Select(c => new Employee
            {
                Name = c.Name,
                JoiningDate = c.JoiningDate,
                ReleaseDate = c.ReleaseDate,
                Skils = c.Skils
            }).ToList();
            return PartialView("~/Views/Dashboard/GetDetails.cshtml", result);
        }
        public ActionResult GetProject()
        {
            List<EmpProject> result = null;
            result = context.EmpProjects.Select(c => new EmpProject
            {
                Name = c.Name,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Technologies = c.Technologies
            }).ToList();
            return PartialView("~/Views/Dashboard/GetProject.cshtml", result);
        }
    }
}
