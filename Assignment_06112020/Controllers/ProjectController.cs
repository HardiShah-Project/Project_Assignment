using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Assignment_06112020.Models;
using System;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment_06112020.Controllers
{
    public class ProjectController : Controller
    {
        private readonly EFDataContext context;

        public ProjectController(EFDataContext _context)
        {
            context = _context;
        }

        // GET: Project
        public ActionResult List(string searchBy, string search, int? page, string sort)
        {
            ViewBag.SortByName = string.IsNullOrEmpty(sort) ? "descending Name" : "";
            ViewBag.SortByStartDate = sort == "StartDate" ? "descending StartDate" : "StartDate";
            ViewBag.SortByEndDate = sort == "EndDate" ? "descending EndDate" : "EndDate";
            ViewBag.SortByTechnologies = sort == "Technologies" ? "descending Technologies" : "Technologies";
     
            var records = (from t in context.EmpProjects
                           select new EmpProject
                           {
                               Code = t.Code,
                               Name = t.Name,
                               StartDate = t.StartDate,
                               EndDate = t.EndDate,
                               Technologies = (from a in context.Skills where a.ID == t.ID select a.SkilName).FirstOrDefault()
                           }).AsQueryable();
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

        // GET: Project/Details/5
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

        // GET: Project/Create
        public ActionResult Create()
        {
            EmpProject empProject = new EmpProject();
            var technologyList = context.Skills.ToList();
            empProject.TechnologyList = new SelectList(technologyList, "ID", "SkillName");
            return View(empProject);
        }

        // POST: Project/Create       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Name,StartDate,EndDate,ID")] EmpProject empProject)
        {
            if (ModelState.IsValid)
            {
                context.Add(empProject);
                context.SaveChanges();
                return RedirectToAction(nameof(List));
            }
            return Create();         
        }

        // GET: Project/Edit/5
        public  ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var empProject = context.EmpProjects.Find(id);
            var technologyList = context.Skills.ToList();
            empProject.TechnologyList = new SelectList(technologyList, "ID", "SkillName");
            if (empProject == null)
            {
                return NotFound();
            }
            return View(empProject);
        }

        // POST: Project/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( [Bind("Code,Name,StartDate,EndDate,ID")] EmpProject empProject)
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
                    if (!ProjectExists(empProject.Code))
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

        // POST: Project/Delete/5
        [HttpPost]
        
        public ActionResult Delete(int id)
        {
            var empProject = context.EmpProjects.Find(id);
            context.EmpProjects.Remove(empProject);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return context.EmpProjects.Any(e => e.Code == id);
        }
    }
}
