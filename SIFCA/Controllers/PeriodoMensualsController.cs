using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class PeriodoMensualsController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: PeriodoMensuals
        public ActionResult Index()
        {
            return View(db.PeriodoMensuals.ToList());
        }

        // GET: PeriodoMensuals/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeriodoMensual periodoMensual = db.PeriodoMensuals.Find(id);
            if (periodoMensual == null)
            {
                return HttpNotFound();
            }
            return View(periodoMensual);
        }

        // GET: PeriodoMensuals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeriodoMensuals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODPER,CODEJERC,DESCPR,FCHINI,FCHFIN,STATUS,USRCRE,FCHCRE,USRACT,FCHACT")] PeriodoMensual periodoMensual)
        {
            if (ModelState.IsValid)
            {
                periodoMensual.FCHCRE = DateTime.Now;
                db.PeriodoMensuals.Add(periodoMensual);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(periodoMensual);
        }

        // GET: PeriodoMensuals/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeriodoMensual periodoMensual = db.PeriodoMensuals.Find(id);
            if (periodoMensual == null)
            {
                return HttpNotFound();
            }
            return View(periodoMensual);
        }

        // POST: PeriodoMensuals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODPER,CODEJERC,DESCPR,FCHINI,FCHFIN,STATUS,USRCRE,FCHCRE,USRACT,FCHACT")] PeriodoMensual periodoMensual)
        {
            if (ModelState.IsValid)
            {
                periodoMensual.FCHACT = DateTime.Now;
                db.Entry(periodoMensual).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(periodoMensual);
        }

        // GET: PeriodoMensuals/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PeriodoMensual periodoMensual = db.PeriodoMensuals.Find(id);
            if (periodoMensual == null)
            {
                return HttpNotFound();
            }
            return View(periodoMensual);
        }

        // POST: PeriodoMensuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PeriodoMensual periodoMensual = db.PeriodoMensuals.Find(id);
            db.PeriodoMensuals.Remove(periodoMensual);
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
