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
    public class funcaosController : Controller
    {
        private InventarioGerenciamentoEntities db = new InventarioGerenciamentoEntities();

        // GET: funcaos
        public ActionResult Index()
        {
            return View(db.funcao.ToList());
        }

        // GET: funcaos/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            funcao funcao = db.funcao.Find(id);
            if (funcao == null)
            {
                return HttpNotFound();
            }
            return View(funcao);
        }

        // GET: funcaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: funcaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "f_Id,f_Nome,f_Status")] funcao funcao)
        {
            if (ModelState.IsValid)
            {
                db.funcao.Add(funcao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcao);
        }

        // GET: funcaos/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            funcao funcao = db.funcao.Find(id);
            if (funcao == null)
            {
                return HttpNotFound();
            }
            return View(funcao);
        }

        // POST: funcaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "f_Id,f_Nome,f_Status")] funcao funcao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcao);
        }

        // GET: funcaos/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            funcao funcao = db.funcao.Find(id);
            if (funcao == null)
            {
                return HttpNotFound();
            }
            return View(funcao);
        }

        // POST: funcaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            funcao funcao = db.funcao.Find(id);
            db.funcao.Remove(funcao);
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
