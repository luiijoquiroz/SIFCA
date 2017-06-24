using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class SociosxGrupoDirectivosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: SociosxGrupoDirectivos
        public ActionResult Index()
        {
            return View(db.SociosxGrupoDirectivoes.ToList());
        }

        // GET: SociosxGrupoDirectivos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SociosxGrupoDirectivo sociosxGrupoDirectivo = db.SociosxGrupoDirectivoes.Find(id);
            if (sociosxGrupoDirectivo == null)
            {
                return HttpNotFound();
            }
            return View(sociosxGrupoDirectivo);
        }

        // GET: SociosxGrupoDirectivos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SociosxGrupoDirectivos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CDRLGR,CODGRP,CODSCO,VGNCIA,REFRNC,USRCRE,FCHCRE,USRACT,FCHACT")] SociosxGrupoDirectivo sociosxGrupoDirectivo)
        {
            if (ModelState.IsValid)
            {
                sociosxGrupoDirectivo.FCHCRE = DateTime.Now;
                db.SociosxGrupoDirectivoes.Add(sociosxGrupoDirectivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sociosxGrupoDirectivo);
        }

        // GET: SociosxGrupoDirectivos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SociosxGrupoDirectivo sociosxGrupoDirectivo = db.SociosxGrupoDirectivoes.Find(id);
            if (sociosxGrupoDirectivo == null)
            {
                return HttpNotFound();
            }
            return View(sociosxGrupoDirectivo);
        }

        // POST: SociosxGrupoDirectivos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CDRLGR,CODGRP,CODSCO,VGNCIA,REFRNC,USRCRE,FCHCRE,USRACT,FCHACT")] SociosxGrupoDirectivo sociosxGrupoDirectivo)
        {
            if (ModelState.IsValid)
            {
                sociosxGrupoDirectivo.FCHACT = DateTime.Now;
                db.Entry(sociosxGrupoDirectivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sociosxGrupoDirectivo);
        }

        // GET: SociosxGrupoDirectivos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SociosxGrupoDirectivo sociosxGrupoDirectivo = db.SociosxGrupoDirectivoes.Find(id);
            if (sociosxGrupoDirectivo == null)
            {
                return HttpNotFound();
            }
            return View(sociosxGrupoDirectivo);
        }

        // POST: SociosxGrupoDirectivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SociosxGrupoDirectivo sociosxGrupoDirectivo = db.SociosxGrupoDirectivoes.Find(id);
            db.SociosxGrupoDirectivoes.Remove(sociosxGrupoDirectivo);
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
