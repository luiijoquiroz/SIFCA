using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class SectoresEconomicosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: SectoresEconomicos
        public ActionResult Index()
        {
            return View(db.SectoresEconomicos.ToList());
        }

        // GET: SectoresEconomicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectorEconomico sectoresEconomicos = db.SectoresEconomicos.Find(id);
            if (sectoresEconomicos == null)
            {
                return HttpNotFound();
            }
            return View(sectoresEconomicos);
        }

        // GET: SectoresEconomicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SectoresEconomicos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODSEC,DESCPR,USRCRE,FCHCRE,USRACT,FCHACT")] SectorEconomico sectoresEconomicos)
        {
            if (ModelState.IsValid)
            {
                sectoresEconomicos.FCHCRE = DateTime.Now;
                db.SectoresEconomicos.Add(sectoresEconomicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sectoresEconomicos);
        }

        // GET: SectoresEconomicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectorEconomico sectoresEconomicos = db.SectoresEconomicos.Find(id);
            if (sectoresEconomicos == null)
            {
                return HttpNotFound();
            }
            return View(sectoresEconomicos);
        }

        // POST: SectoresEconomicos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODSEC,DESCPR,USRCRE,FCHCRE,USRACT,FCHACT")] SectorEconomico sectoresEconomicos)
        {
            if (ModelState.IsValid)
            {
                sectoresEconomicos.FCHACT = DateTime.Now;
                db.Entry(sectoresEconomicos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sectoresEconomicos);
        }

        // GET: SectoresEconomicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectorEconomico sectoresEconomicos = db.SectoresEconomicos.Find(id);
            if (sectoresEconomicos == null)
            {
                return HttpNotFound();
            }
            return View(sectoresEconomicos);
        }

        // POST: SectoresEconomicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SectorEconomico sectoresEconomicos = db.SectoresEconomicos.Find(id);
            db.SectoresEconomicos.Remove(sectoresEconomicos);
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
