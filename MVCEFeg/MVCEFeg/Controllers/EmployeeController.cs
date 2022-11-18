using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCEFeg.Models;

namespace MVCEFeg.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EurofinsDBContext db;
        public EmployeeController(EurofinsDBContext _db)
        {
            db = _db;
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Index()
        {
            var result = db.Employees.Include(x=>x.Dept);
            return View(result.ToList());
            //return View(db.Employees.ToList());
        }

        public IActionResult Create()
        {
            var result = db.Departments.ToList();
            ViewBag.Deptid = new SelectList(result, "Did", "Dname");
            return View();
        }

        [HttpPost]

        public IActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(e);
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Employee e = db.Employees.Find(id);
            return View(e);
        }

        public IActionResult Edit(int id)
        {
            Employee e = db.Employees.Find(id);
            var result = db.Departments.ToList();
            ViewBag.Deptid = new SelectList(result, "Did", "Dname");
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Employee e)
        {
            db.Employees.Update(e);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            Employee e = db.Employees.Find(id);
            return View(e);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(Employee e)
        {
            db.Employees.Remove(e);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
