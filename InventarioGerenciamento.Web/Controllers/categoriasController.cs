using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventarioGerenciamento.Web.Models.DAL;

namespace InventarioGerenciamento.Web.Controllers
{
    public class categoriasController : Controller
    {
        private InventarioGerenciamentoEntities db = new InventarioGerenciamentoEntities();

        // GET: categorias
        public ActionResult Index()
        {
            return View(db.categorias.ToList());
        }

        // GET: categorias/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorias categorias = db.categorias.Find(id);
            if (categorias == null)
            {
                return HttpNotFound();
            }
            return View(categorias);
        }

        // GET: categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: categorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cat_Id,cat_Nome,cat_Status")] categorias categorias)
        {
            if (ModelState.IsValid)
            {
                db.categorias.Add(categorias);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorias);
        }

        // GET: categorias/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorias categorias = db.categorias.Find(id);
            if (categorias == null)
            {
                return HttpNotFound();
            }
            return View(categorias);
        }

        // POST: categorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cat_Id,cat_Nome,cat_Status")] categorias categorias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorias).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorias);
        }

        // GET: categorias/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categorias categorias = db.categorias.Find(id);
            if (categorias == null)
            {
                return HttpNotFound();
            }
            return View(categorias);
        }

        // POST: categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            categorias categorias = db.categorias.Find(id);
            db.categorias.Remove(categorias);
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
