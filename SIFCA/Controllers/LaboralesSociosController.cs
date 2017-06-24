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
    public class LaboralesSociosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: LaboralesSocios
        public ActionResult Index()
        {
            return View(db.DatosLaboralesSocios.ToList());
        }

        // GET: LaboralesSocios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaboralesSocio laboralesSocio = db.DatosLaboralesSocios.Find(id);
            if (laboralesSocio == null)
            {
                return HttpNotFound();
            }
            return View(laboralesSocio);
        }

        // GET: LaboralesSocios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LaboralesSocios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CISOC,CODNOM,CODDEP,CODCRG,FINEMP,FINCAH,SUELDO,APRTCA,TIPSOC,CODBCO,CTABCO,STATUS,CODDIR,USRCRE,FCHCRE,USRACT,FCHACT")] LaboralesSocio laboralesSocio)
        {
            if (ModelState.IsValid)
            {
                laboralesSocio.FCHCRE = DateTime.Now;
                laboralesSocio.FCHACT = DateTime.Now;
                db.DatosLaboralesSocios.Add(laboralesSocio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(laboralesSocio);
        }

        // GET: LaboralesSocios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaboralesSocio laboralesSocio = db.DatosLaboralesSocios.Find(id);
            if (laboralesSocio == null)
            {
                return HttpNotFound();
            }
            return View(laboralesSocio);
        }

        // POST: LaboralesSocios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CISOC,CODNOM,CODDEP,CODCRG,FINEMP,FINCAH,SUELDO,APRTCA,TIPSOC,CODBCO,CTABCO,STATUS,CODDIR,USRCRE,FCHCRE,USRACT,FCHACT")] LaboralesSocio laboralesSocio)
        {
            if (ModelState.IsValid)
            {
                laboralesSocio.FCHACT = DateTime.Now;
                db.Entry(laboralesSocio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laboralesSocio);
        }

        // GET: LaboralesSocios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaboralesSocio laboralesSocio = db.DatosLaboralesSocios.Find(id);
            if (laboralesSocio == null)
            {
                return HttpNotFound();
            }
            return View(laboralesSocio);
        }

        // POST: LaboralesSocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LaboralesSocio laboralesSocio = db.DatosLaboralesSocios.Find(id);
            db.DatosLaboralesSocios.Remove(laboralesSocio);
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
