using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class FamiliarSociosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: FamiliarSocios
        public ActionResult Index()
        {
            return View(db.DatosFamiliaresSocios.ToList());
        }

        // GET: FamiliarSocios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamiliarSocio familiarSocio = db.DatosFamiliaresSocios.Find(id);
            if (familiarSocio == null)
            {
                return HttpNotFound();
            }
            return View(familiarSocio);
        }

        // GET: FamiliarSocios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamiliarSocios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDFAM,CIFLIA,CISOC,REGIDX,NOMBRE,FHCNAC,PRNTSC,USRCRE,FCHCRE,USRACT,FCHACT")] FamiliarSocio familiarSocio)
        {
            if (ModelState.IsValid)
            {
                familiarSocio.FCHCRE = DateTime.Now;
                db.DatosFamiliaresSocios.Add(familiarSocio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familiarSocio);
        }

        // GET: FamiliarSocios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamiliarSocio familiarSocio = db.DatosFamiliaresSocios.Find(id);
            if (familiarSocio == null)
            {
                return HttpNotFound();
            }
            return View(familiarSocio);
        }

        // POST: FamiliarSocios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDFAM,CIFLIA,CISOC,REGIDX,NOMBRE,FHCNAC,PRNTSC,USRCRE,FCHCRE,USRACT,FCHACT")] FamiliarSocio familiarSocio)
        {
            if (ModelState.IsValid)
            {
                familiarSocio.FCHACT = DateTime.Now;
                db.Entry(familiarSocio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(familiarSocio);
        }

        // GET: FamiliarSocios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamiliarSocio familiarSocio = db.DatosFamiliaresSocios.Find(id);
            if (familiarSocio == null)
            {
                return HttpNotFound();
            }
            return View(familiarSocio);
        }

        // POST: FamiliarSocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FamiliarSocio familiarSocio = db.DatosFamiliaresSocios.Find(id);
            db.DatosFamiliaresSocios.Remove(familiarSocio);
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
