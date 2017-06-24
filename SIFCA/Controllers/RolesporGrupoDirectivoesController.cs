using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class RolesporGrupoDirectivoesController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: RolesporGrupoDirectivoes
        public ActionResult Index()
        {
            return View(db.RolesporGrupoDirectivoes.ToList());
        }

        // GET: RolesporGrupoDirectivoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolesporGrupoDirectivo rolesporGrupoDirectivo = db.RolesporGrupoDirectivoes.Find(id);
            if (rolesporGrupoDirectivo == null)
            {
                return HttpNotFound();
            }
            return View(rolesporGrupoDirectivo);
        }

        // GET: RolesporGrupoDirectivoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolesporGrupoDirectivoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CDRLGR,CODGRP,CODROL,REFRNC,USRCRE,FCHCRE,USRACT,FCHACT")] RolesporGrupoDirectivo rolesporGrupoDirectivo)
        {
            if (ModelState.IsValid)
            {
                rolesporGrupoDirectivo.FCHCRE = DateTime.Now;
                db.RolesporGrupoDirectivoes.Add(rolesporGrupoDirectivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rolesporGrupoDirectivo);
        }

        // GET: RolesporGrupoDirectivoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolesporGrupoDirectivo rolesporGrupoDirectivo = db.RolesporGrupoDirectivoes.Find(id);
            if (rolesporGrupoDirectivo == null)
            {
                return HttpNotFound();
            }
            return View(rolesporGrupoDirectivo);
        }

        // POST: RolesporGrupoDirectivoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CDRLGR,CODGRP,CODROL,REFRNC,USRCRE,FCHCRE,USRACT,FCHACT")] RolesporGrupoDirectivo rolesporGrupoDirectivo)
        {
            if (ModelState.IsValid)
            {
                rolesporGrupoDirectivo.FCHACT = DateTime.Now;
                db.Entry(rolesporGrupoDirectivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rolesporGrupoDirectivo);
        }

        // GET: RolesporGrupoDirectivoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolesporGrupoDirectivo rolesporGrupoDirectivo = db.RolesporGrupoDirectivoes.Find(id);
            if (rolesporGrupoDirectivo == null)
            {
                return HttpNotFound();
            }
            return View(rolesporGrupoDirectivo);
        }

        // POST: RolesporGrupoDirectivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RolesporGrupoDirectivo rolesporGrupoDirectivo = db.RolesporGrupoDirectivoes.Find(id);
            db.RolesporGrupoDirectivoes.Remove(rolesporGrupoDirectivo);
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
