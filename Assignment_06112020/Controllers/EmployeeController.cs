﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment_06112020.Models;
using System;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_06112020.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EFDataContext context;

        public EmployeeController(EFDataContext _context)
        {
            context = _context;
        }

        // GET: Employee
        public ActionResult List(string searchBy, string search, int? page, string sort)
        {
            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "descending Name" : "";
            ViewBag.SortByJoiningDate = sort == "JoiningDate" ? "descending JoiningDate" : "JoiningDate";
            ViewBag.SortByReleaseDate = sort == "ReleaseDate" ? " ReleadescendingseDate" : "ReleaseDate";
            ViewBag.SortBySkils = sort == "Skils" ? "descending Skils" : "Skils";

           var records= (from t in context.Employees
             select new Employee
             {
                 Code=t.Code,
                 Name = t.Name,
                 JoiningDate = t.JoiningDate,
                 ReleaseDate = t.ReleaseDate,
                 Skils = (from a in context.Skills where a.ID == t.ID select a.SkilName).FirstOrDefault()
             }).AsQueryable();

            if (searchBy == "Skils")
            {
                records = records.Where(x => x.Skils == search || search == null);
            }
            else
            {
                records = records.Where(x => x.Name == search || search == null);
            }

            switch (sort)
            {

                case "descending Name":
                    records = records.OrderByDescending(x => x.Name);
                    break;

                case "descending JoiningDate":
                    records = records.OrderByDescending(x => x.JoiningDate);
                    break;

                case "descending ReleaseDate":
                    records = records.OrderByDescending(x => x.ReleaseDate);
                    break;

                case "descending Skils":
                    records = records.OrderByDescending(x => x.Skils);
                    break;

                case "JoiningDate":
                    records = records.OrderBy(x => x.JoiningDate);
                    break;

                case "ReleaseDate":
                    records = records.OrderBy(x => x.ReleaseDate);
                    break;

                case "Skils":
                    records = records.OrderBy(x => x.Skils);
                    break;

                default:
                    records = records.OrderBy(x => x.Name);
                    break;
                    
            }
            return View(records.ToPagedList(page ?? 1, 3));
        }
        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var employee = context.Employees.FromSqlRaw("sp_GetEmployeeById {0}", id).ToList().FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee emp = new Employee();
            var skilList = context.Skills.ToList();
            emp.SkilList = new SelectList(skilList, "ID", "SkillName");
            return View(emp);
        }

        // POST: Employee/Create     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name,JoiningDate,ReleaseDate,ID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Database.ExecuteSqlRaw("sp_AddEmployee {0},{1},{2},{3}", employee.Name,
                employee.JoiningDate, employee.ReleaseDate, employee.ID);
                return RedirectToAction(nameof(List));
            }
            return Create();
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var employee = context.Employees.Find(id);
            var skilList = context.Skills.ToList();
            employee.SkilList = new SelectList(skilList, "ID", "SkillName");
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( [Bind("Code,Name,JoiningDate,ReleaseDate,ID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Database.ExecuteSqlRaw("sp_UpdateEmployee {0},{1},{2},{3},{4}", employee.Code, employee.Name,
                    employee.JoiningDate, employee.ReleaseDate, employee.ID);

                }
                catch (Exception)
                {
                    if (!EmployeeExists(employee.Code))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return Create();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var emp = context.Database.ExecuteSqlRaw("sp_DeleteEmployee {0}", id);
            return RedirectToAction(nameof(List));
        }

        private bool EmployeeExists(int id)
        {
            return context.Employees.Any(e => e.Code == id);
        }
    }
}
