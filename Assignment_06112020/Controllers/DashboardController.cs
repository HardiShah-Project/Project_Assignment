﻿using System.Collections.Generic;
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
        public ActionResult Dashboard(string SearchText)
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
                Skils = (from s in context.Skills where s.ID == c.ID select s.SkilName).FirstOrDefault()
            }).ToList();
            return PartialView(result);
        }
        public ActionResult GetProject()
        {
            List<EmpProject> result = null;
            result = context.EmpProjects.Select(c => new EmpProject
            {
                Name = c.Name,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                Technologies = (from s in context.Skills where s.ID == c.ID select s.SkilName).FirstOrDefault()
            }).ToList();
            return PartialView(result);
        }
        public ActionResult EmployeeSkill()
        {
            List<Employee> emp = null;
            emp = (from t in context.Employees
                   join a in context.Skills on t.Code equals a.ID
                   select new Employee
                   {
                       Name = t.Name,
                       JoiningDate = t.JoiningDate,
                       ReleaseDate = t.ReleaseDate,
                       Skils = (from s in context.Skills where s.ID == t.ID select s.SkilName).FirstOrDefault()
                   }).ToList();
            return PartialView(emp);
        }

        public ActionResult JoiningDate()
        {
            var emp = new List<Employee>();
            emp = (from o in context.Employees
                   group o by new { o.JoiningDate.Month } into g
                   select (new Employee()
                   {
                       Month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month),
                       Count = g.Count()
                   })).ToList();
            return Json(new { result = emp });
        }

        public ActionResult ReleaseDate()
        {
            var emp = new List<Employee>();
            emp = (from o in context.Employees
                   group o by new { o.ReleaseDate.Month } into g
                   select (new Employee()
                   {
                       Month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month),
                       Count = g.Count()
                   })).ToList();
            return Json(new { result = emp });
        }

        public ActionResult ProjectSkill()
        {
            List<EmpProject> prj = null;
            prj = (from p in context.EmpProjects
                   join s in context.Skills on p.Code equals s.ID
                   select new EmpProject
                   {
                       Name = p.Name,
                       StartDate = p.StartDate,
                       EndDate = p.EndDate,
                       Technologies = (from a in context.Skills where a.ID == p.ID select a.SkilName).FirstOrDefault()
                   }).ToList();
            return PartialView(prj);
        }

        public ActionResult StartDate()
        {
            var emp = new List<EmpProject>();
            emp = (from o in context.EmpProjects
                   group o by new { o.StartDate.Month } into g
                   select (new EmpProject()
                   {
                       Month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month),
                       Count = g.Count()
                   })).ToList();
            return Json(new { result = emp });
        }

        public ActionResult EndDate()
        {
            var emp = new List<EmpProject>();
            emp = (from o in context.EmpProjects
                   group o by new { o.EndDate.Month } into g
                   select (new EmpProject()
                   {
                       Month = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.Key.Month),
                       Count = g.Count()
                   })).ToList();
            return Json(new { result = emp });
        }
    }
}
