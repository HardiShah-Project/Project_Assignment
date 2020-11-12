using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment_06112020.Models;
using System;

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
        public ActionResult Index()
        {
            return View(context.Employees.ToList());
        }
        // GET: Employee/Details/5
        public  ActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var employee =  context.Employees.FirstOrDefault(m => m.Code == id);
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
        public  ActionResult Create([Bind("Name,JoiningDate,ReleaseDate,Skils")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Add(employee);
                context.SaveChanges();
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

            var employee =  context.Employees.Find(id);
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
                    context.Update(employee);
                    context.SaveChanges();
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
            {
                 var emp = context.Employees.Where(val => val.Code == id).FirstOrDefault();
                if (emp != null)
                {
                    context.Employees.Remove(emp);
                    context.SaveChanges();
                }                
            }
            return RedirectToAction("Index");
        }

        private bool EmployeeExists(int id)
        {
            return context.Employees.Any(e => e.Code == id);
        }
    }
}
