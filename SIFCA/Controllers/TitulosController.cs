using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class TitulosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: Titulos
        public ActionResult Index()
        {
            return View(db.Titulos.ToList());
        }

        // GET: Titulos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titulos titulos = db.Titulos.Find(id);
            if (titulos == null)
            {
                return HttpNotFound();
            }
            return View(titulos);
        }

        // GET: Titulos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Titulos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODTTL,DESCPR,USRCRE,FCHCRE,USRACT,FCHACT")] Titulos titulos)
        {
            if (ModelState.IsValid)
            {
                titulos.FCHCRE = DateTime.Now;
                db.Titulos.Add(titulos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(titulos);
        }

        // GET: Titulos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titulos titulos = db.Titulos.Find(id);
            if (titulos == null)
            {
                return HttpNotFound();
            }
            return View(titulos);
        }

        // POST: Titulos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODTTL,DESCPR,USRCRE,FCHCRE,USRACT,FCHACT")] Titulos titulos)
        {
            if (ModelState.IsValid)
            {
                titulos.FCHACT = DateTime.Now;
                db.Entry(titulos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(titulos);
        }

        // GET: Titulos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Titulos titulos = db.Titulos.Find(id);
            if (titulos == null)
            {
                return HttpNotFound();
            }
            return View(titulos);
        }

        // POST: Titulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Titulos titulos = db.Titulos.Find(id);
            db.Titulos.Remove(titulos);
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
