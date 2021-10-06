using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StudentiIspitiZadatak.ViewModels;
using System.Collections;
using StudentiIspitiZadatak.Models;

namespace StudentiIspitiZadatak.Controllers
{
    [HandleError]
    public class IspitiController : Controller
    {

        private StudentiIspitiDbContext _context;

        public IspitiController()
        {
            _context = new StudentiIspitiDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Ispiti
        public ActionResult Index()
        {
            var model = new IspitiViewModel
            {
                Ispiti = _context.IspitDbSet.Include(i=>i.Student).Include(i=>i.Predmet).Include(i=>i.IspitniRok).ToList(),
            };

            return View(model);
        }

   
        // GET: Ispiti/Details/5
        public ActionResult Details(int id)
        {
            var ispit = _context.IspitDbSet.SingleOrDefault(s => s.Id == id);
            var viewModel = new IspitiViewModel
            {
                Predmet = _context.PredmetDbSet.Single(s => s.Sifra == ispit.PredmetID),
                Student = _context.StudentDbSet.Single(s=>s.BrIndexa == ispit.StudentID),
                IspitniRok = _context.IspitniRokDbSet.Single(s=>s.OznakaRoka == ispit.IspitniRokID),
                BodoviRoka = ispit.BodoviRoka,
                DatumRoka = ispit.DatumRoka

            };
            return View(viewModel);
        }

        // GET: Ispiti/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Ispiti/Create
        [HttpPost]
        public ActionResult Create(Ispit ispit)
        {
            if (!ModelState.IsValid)
            {
                return View(ispit);
            }
            _context.IspitDbSet.Add(ispit);
            _context.SaveChanges();
            return RedirectToAction("Index", ispit);
        }

        // GET: Ispiti/Edit/5
        public ActionResult Edit(int id)
        {
           var ispit = _context.IspitDbSet.SingleOrDefault(s => s.Id == id);
            if (ispit == null)
                return HttpNotFound();
            var viewModel = new IspitIzmenaViewModel
            {
                DatumRoka = ispit.DatumRoka,
                BodoviRoka = ispit.BodoviRoka,
                StudentID = ispit.StudentID,
                PredmetID = ispit.PredmetID,
                IspitniRokID = ispit.IspitniRokID,


                StudentiDL = _context.StudentDbSet.ToList(),
                PredmetiDL = _context.PredmetDbSet.ToList(),
                IspitniRokoviDL = _context.IspitniRokDbSet.ToList()
            };

            return View(viewModel);
        }

        // POST: Ispiti/Edit/5
        [HttpPost]
        public ActionResult Edit(Ispit ispit)
        {
            if (!ModelState.IsValid)
            {
                return View(ispit);
            }
            else
            {
                var ispitDB = _context.IspitDbSet.SingleOrDefault(i => i.Id == ispit.Id);
                ispitDB.PredmetID = ispit.PredmetID;
                ispitDB.IspitniRokID = ispit.IspitniRokID;
                ispitDB.BodoviRoka = ispit.BodoviRoka;
                ispitDB.DatumRoka = ispit.DatumRoka;
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Ispiti");
           
        }

        // GET: Ispiti/Delete/5
        public ActionResult Delete(int id)
        {
            var ispit = _context.IspitDbSet.SingleOrDefault(i => i.Id == id);
            var viewModel = new IspitIzmenaViewModel
            {
                PredmetID = ispit.PredmetID,
                StudentID = ispit.StudentID,
                IspitniRokID = ispit.IspitniRokID,
                BodoviRoka = ispit.BodoviRoka,
                DatumRoka = ispit.DatumRoka
            };
            return View(viewModel);
        }

        // POST: Ispiti/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            var ispit = _context.IspitDbSet.SingleOrDefault(i=>i.Id==id);
            if(!ModelState.IsValid)
            {
                return View(ispit);
            }
            _context.IspitDbSet.Remove(ispit);
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}
