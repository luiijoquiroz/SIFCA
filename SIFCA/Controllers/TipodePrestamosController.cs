using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
  
{
    public class TipodePrestamosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: TipodePrestamos
        public ActionResult Index()
        {
            var tipodePrestamos = db.TipodePrestamos.Include(t => t.UnidaddeTiempos);
            return View(tipodePrestamos.ToList());
        }

        // GET: TipodePrestamos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodePrestamos tipodePrestamos = db.TipodePrestamos.Find(id);
            if (tipodePrestamos == null)
            {
                return HttpNotFound();
            }
            return View(tipodePrestamos);
        }

        // GET: TipodePrestamos/Create
        public ActionResult Create()
        {
            ViewBag.CODUND = new SelectList(db.UnidaddeTiempoes, "CODUND", "CAPTION");
            
            return View();
        }

        // POST: TipodePrestamos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODTIP,DESCPR,TSAPMO,CANTMP,CODUND,CTAPMO,CTAINT,USRCRE,FCHCRE,USRACT,FCHACT,STATUS")] TipodePrestamos tipodePrestamos)
        {
            if (ModelState.IsValid)
            {
                db.TipodePrestamos.Add(tipodePrestamos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CODUND = new SelectList(db.UnidaddeTiempoes, "CODUND", "CAPTION", tipodePrestamos.CODUND);
            return View(tipodePrestamos);
        }

        // GET: TipodePrestamos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodePrestamos tipodePrestamos = db.TipodePrestamos.Find(id);
            if (tipodePrestamos == null)
            {
                return HttpNotFound();
            }
            ViewBag.CODUND = new SelectList(db.UnidaddeTiempoes, "CODUND", "CAPTION", tipodePrestamos.CODUND);
            return View(tipodePrestamos);
        }

        // POST: TipodePrestamos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODTIP,DESCPR,TSAPMO,CANTMP,CODUND,CTAPMO,CTAINT,USRCRE,FCHCRE,USRACT,FCHACT,STATUS")] TipodePrestamos tipodePrestamos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodePrestamos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CODUND = new SelectList(db.UnidaddeTiempoes, "CODUND", "CAPTION",  tipodePrestamos.CODUND);
            return View(tipodePrestamos);
        }

        // GET: TipodePrestamos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodePrestamos tipodePrestamos = db.TipodePrestamos.Find(id);
            if (tipodePrestamos == null)
            {
                return HttpNotFound();
            }
            return View(tipodePrestamos);
        }

        // POST: TipodePrestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipodePrestamos tipodePrestamos = db.TipodePrestamos.Find(id);
            db.TipodePrestamos.Remove(tipodePrestamos);
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
