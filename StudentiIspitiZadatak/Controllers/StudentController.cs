using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StudentiIspitiZadatak.Models;
using System.Web.Routing;

namespace StudentiIspitiZadatak.Controllers
{
    public class StudentController : Controller
    {
        private StudentiIspitiDbContext _context;
        public StudentController()
        {
            _context = new StudentiIspitiDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Student
        public ActionResult Index()
        {
            var studenti = _context.StudentDbSet.ToList();
            return View(studenti);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var student = _context.StudentDbSet.SingleOrDefault(s => s.BrIndexa == id);
            if (student == null)
                return HttpNotFound();

            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if(!ModelState.IsValid)
            {
                return View(student);
            }
            _context.StudentDbSet.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index", student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var student = _context.StudentDbSet.SingleOrDefault(s => s.BrIndexa == id);
            if (student == null)
                return HttpNotFound();
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student student)
        {
          if(!ModelState.IsValid)
            {
                return View(student);
            }
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var student = _context.StudentDbSet.Single(s => s.BrIndexa == id);
        
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            var student = _context.StudentDbSet.SingleOrDefault(s => s.BrIndexa == id);
            if(!ModelState.IsValid)
            {
                return View(student);
            }
            _context.StudentDbSet.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
          
        }
    }
}
