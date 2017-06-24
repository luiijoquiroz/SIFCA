using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class PersonalesSociosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: PersonalesSocios
        public ActionResult Index()
        {
            return View(db.PersonalesSocios.ToList());
        }

        // GET: PersonalesSocios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalesSocio personalesSocio = db.PersonalesSocios.Find(id);
            if (personalesSocio == null)
            {
                return HttpNotFound();
            }
            return View(personalesSocio);
        }

        // GET: PersonalesSocios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonalesSocios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDSOC,CISOC,APLLDO,NOMBRE,FHCNAC,EDOCVL,CODDIR,USRCRE,FCHCRE,USRACT,FCHACT")] PersonalesSocio personalesSocio)
        {
            if (ModelState.IsValid)
            {
                personalesSocio.FCHCRE = DateTime.Now;
                db.PersonalesSocios.Add(personalesSocio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalesSocio);
        }

        // GET: PersonalesSocios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalesSocio personalesSocio = db.PersonalesSocios.Find(id);
            if (personalesSocio == null)
            {
                return HttpNotFound();
            }
            return View(personalesSocio);
        }

        // POST: PersonalesSocios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDSOC,CISOC,APLLDO,NOMBRE,FHCNAC,EDOCVL,CODDIR,USRCRE,FCHCRE,USRACT,FCHACT")] PersonalesSocio personalesSocio)
        {
            if (ModelState.IsValid)
            {
                personalesSocio.FCHACT = DateTime.Now;
                db.Entry(personalesSocio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personalesSocio);
        }

        // GET: PersonalesSocios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalesSocio personalesSocio = db.PersonalesSocios.Find(id);
            if (personalesSocio == null)
            {
                return HttpNotFound();
            }
            return View(personalesSocio);
        }

        // POST: PersonalesSocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalesSocio personalesSocio = db.PersonalesSocios.Find(id);
            db.PersonalesSocios.Remove(personalesSocio);
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
