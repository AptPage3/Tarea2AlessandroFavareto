using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tarea2AlessandroFavareto.Data;
using Tarea2AlessandroFavareto.Models;

namespace Tarea2AlessandroFavareto.Controllers
{
    public class GridsController : Controller
    {
        private Tarea2AlessandroFavaretoContext db = new Tarea2AlessandroFavaretoContext();

        // GET: Grids
        public ActionResult Index()
        {
            return View(db.Grids.ToList());
        }

        // GET: Grids/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grid grid = db.Grids.Find(id);
            if (grid == null)
            {
                return HttpNotFound();
            }
            return View(grid);
        }

        // GET: Grids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grids/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Posicion,Nombre,Clasificacion,Porcentaje")] Grid grid)
        {
            if (ModelState.IsValid)
            {
                db.Grids.Add(grid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grid);
        }

        // GET: Grids/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grid grid = db.Grids.Find(id);
            if (grid == null)
            {
                return HttpNotFound();
            }
            return View(grid);
        }

        // POST: Grids/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Posicion,Nombre,Clasificacion,Porcentaje")] Grid grid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grid);
        }

        // GET: Grids/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grid grid = db.Grids.Find(id);
            if (grid == null)
            {
                return HttpNotFound();
            }
            return View(grid);
        }

        // POST: Grids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grid grid = db.Grids.Find(id);
            db.Grids.Remove(grid);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
