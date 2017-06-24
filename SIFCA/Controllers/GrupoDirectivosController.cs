using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class GrupoDirectivosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: GrupoDirectivos
        public ActionResult Index()
        {
            return View(db.GrupoDirectivos.ToList());
        }

        // GET: GrupoDirectivos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoDirectivos grupoDirectivos = db.GrupoDirectivos.Find(id);
            if (grupoDirectivos == null)
            {
                return HttpNotFound();
            }
            return View(grupoDirectivos);
        }

        // GET: GrupoDirectivos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrupoDirectivos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODGRP,DESCPR,USRCRE,FCHCRE,USRACT,FCHACT")] GrupoDirectivos grupoDirectivos)
        {
            if (ModelState.IsValid)
            {
                grupoDirectivos.FCHCRE = DateTime.Now;
                db.GrupoDirectivos.Add(grupoDirectivos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupoDirectivos);
        }

        // GET: GrupoDirectivos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoDirectivos grupoDirectivos = db.GrupoDirectivos.Find(id);
            if (grupoDirectivos == null)
            {
                return HttpNotFound();
            }
            return View(grupoDirectivos);
        }

        // POST: GrupoDirectivos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODGRP,DESCPR,USRCRE,FCHCRE,USRACT,FCHACT")] GrupoDirectivos grupoDirectivos)
        {
            if (ModelState.IsValid)
            {
                grupoDirectivos.FCHACT = DateTime.Now;
                db.Entry(grupoDirectivos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupoDirectivos);
        }

        // GET: GrupoDirectivos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrupoDirectivos grupoDirectivos = db.GrupoDirectivos.Find(id);
            if (grupoDirectivos == null)
            {
                return HttpNotFound();
            }
            return View(grupoDirectivos);
        }

        // POST: GrupoDirectivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GrupoDirectivos grupoDirectivos = db.GrupoDirectivos.Find(id);
            db.GrupoDirectivos.Remove(grupoDirectivos);
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
