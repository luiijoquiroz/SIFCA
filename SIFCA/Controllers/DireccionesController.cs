using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class DireccionesController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: Direcciones
        public ActionResult Index()
        {
            return View(db.Direcciones.ToList());
        }

        // GET: Direcciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direcciones direcciones = db.Direcciones.Find(id);
            if (direcciones == null)
            {
                return HttpNotFound();
            }
            return View(direcciones);
        }

        // GET: Direcciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Direcciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODDIR,DRCCN1,DRCCN2,NUMERO,CODEDO,CIUDAD,CDPSTL,TELMOV,TELHAB,TELOFI,USRCRE,FCHCRE,USRACT,FCHACT")] Direcciones direcciones)
        {
            if (ModelState.IsValid)
            {
                direcciones.FCHCRE = DateTime.Now;
                db.Direcciones.Add(direcciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(direcciones);
        }

        // GET: Direcciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direcciones direcciones = db.Direcciones.Find(id);
            if (direcciones == null)
            {
                return HttpNotFound();
            }
            return View(direcciones);
        }

        // POST: Direcciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODDIR,DRCCN1,DRCCN2,NUMERO,CODEDO,CIUDAD,CDPSTL,TELMOV,TELHAB,TELOFI,USRCRE,FCHCRE,USRACT,FCHACT")] Direcciones direcciones)
        {
            if (ModelState.IsValid)
            {
                direcciones.FCHACT = DateTime.Now;
                db.Entry(direcciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(direcciones);
        }

        // GET: Direcciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direcciones direcciones = db.Direcciones.Find(id);
            if (direcciones == null)
            {
                return HttpNotFound();
            }
            return View(direcciones);
        }

        // POST: Direcciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Direcciones direcciones = db.Direcciones.Find(id);
            db.Direcciones.Remove(direcciones);
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
