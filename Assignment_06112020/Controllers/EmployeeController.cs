using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment_06112020.Models;
using System;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

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
        public ActionResult Index(string searchBy, string search, int? page, string sort)
        {
            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "descending Name" : "";
            ViewBag.SortByJoiningDate = sort == "JoiningDate" ? "descending JoiningDate" : "JoiningDate";
            ViewBag.SortByReleaseDate = sort == "ReleaseDate" ? "descending ReleaseDate" : "ReleaseDate";
            ViewBag.SortBySkils = sort == "Skils" ? "descending Skils" : "Skils";

            var records = context.Employees.AsQueryable();
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

           // return View(context.Employees.FromSqlRaw("sp_GetEmployee").ToList());
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
            return View();
        }

        // POST: Employee/Create     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name,JoiningDate,ReleaseDate,Skils")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Database.ExecuteSqlRaw("sp_AddEmployee {0},{1},{2},{3}", employee.Name,
                employee.JoiningDate, employee.ReleaseDate, employee.Skils);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var employee = context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Code,Name,JoiningDate,ReleaseDate,Skils")] Employee employee)
        {
            if (id != employee.Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Database.ExecuteSqlRaw("sp_UpdateEmployee {0},{1},{2},{3},{4}", employee.Code, employee.Name,
                    employee.JoiningDate, employee.ReleaseDate, employee.Skils);

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
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var emp = context.Database.ExecuteSqlRaw("sp_DeleteEmployee {0}", id);
            return RedirectToAction("Index");
        }

        private bool EmployeeExists(int id)
        {
            return context.Employees.Any(e => e.Code == id);
        }
    }
}
