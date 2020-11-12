using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment_06112020.Models;
using System;
using X.PagedList;


namespace Assignment_06112020.Controllers
{
    public class EmpProjectController : Controller
    {
        private readonly EFDataContext context;

        public EmpProjectController(EFDataContext _context)
        {
            context = _context;
        }

        // GET: EmpProject
        public ActionResult Index(string searchBy, string search, int? page, string sort)
        {
            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "descending Name" : "";
            ViewBag.SortByStartDate = sort == "StartDate" ? "descending StartDate" : "StartDate";
            ViewBag.SortByEndDate = sort == "EndDate" ? "descending EndDate" : "EndDate";
            ViewBag.SortByTechnologies = sort == "Technologies" ? "descending Technologies" : "Technologies";
     
            var records = context.EmpProjects.AsQueryable();
            if (searchBy == "Technologies")
            {
                records = records.Where(x => x.Technologies == search || search == null);
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

                case "descending StartDate":
                    records = records.OrderByDescending(x => x.StartDate);
                    break;

                case "descending EndDate":
                    records = records.OrderByDescending(x => x.EndDate);
                    break;

                case "descending Technologies":
                    records = records.OrderByDescending(x => x.Technologies);
                    break;

                case "StartDate":
                    records = records.OrderBy(x => x.StartDate);
                    break;

                case "EndDate":
                    records = records.OrderBy(x => x.EndDate);
                    break;

                case "Technologies":
                    records = records.OrderBy(x => x.Technologies);
                    break;

                default:
                    records = records.OrderBy(x => x.Name);
                    break;

            }
            return View(records.ToPagedList(page ?? 1, 3));
           
        }

        // GET: EmpProject/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var empProject = context.EmpProjects.FirstOrDefault(m => m.Code == id);
            if (empProject == null)
            {
                return NotFound();
            }

            return View(empProject);
        }

        // GET: EmpProject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpProject/Create       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name,StartDate,EndDate,Technologies")] EmpProject empProject)
        {
            if (ModelState.IsValid)
            {
                context.Add(empProject);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(empProject);         
        }

        // GET: EmpProject/Edit/5
        public  ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var empProject = context.EmpProjects.Find(id);
            if (empProject == null)
            {
                return NotFound();
            }
            return View(empProject);
        }

        // POST: EmpProject/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( [Bind("Code,Name,StartDate,EndDate,Technologies")] EmpProject empProject)
        {
           
            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(empProject);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    if (!EmpProjectExists(empProject.Code))
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
            return View(empProject);
        }

        // POST: EmpProject/Delete/5
        [HttpPost]
        
        public ActionResult Delete(int id)
        {
            var empProject = context.EmpProjects.Find(id);
            context.EmpProjects.Remove(empProject);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpProjectExists(int id)
        {
            return context.EmpProjects.Any(e => e.Code == id);
        }
    }
}
