using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class PatronosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: Patronos
        public ActionResult Index()
        {
            return View(db.Patronoes.ToList());
        }

        // GET: Patronos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrono patrono = db.Patronoes.Find(id);
            if (patrono == null)
            {
                return HttpNotFound();
            }
            return View(patrono);
        }

        // GET: Patronos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patronos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODPTR,REGIDX,NOMBRE,HRAOFI,CODSEC,NRORIF,CODDIR,PAGWEB,CODRDS,DIRLOG,USRCRE,FCHCRE,USRACT,FCHACT")] Patrono patrono)
        {
            if (ModelState.IsValid)
            {
                patrono.FCHCRE = DateTime.Now;
                db.Patronoes.Add(patrono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patrono);
        }

        // GET: Patronos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrono patrono = db.Patronoes.Find(id);
            if (patrono == null)
            {
                return HttpNotFound();
            }
            return View(patrono);
        }

        // POST: Patronos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODPTR,REGIDX,NOMBRE,HRAOFI,CODSEC,NRORIF,CODDIR,PAGWEB,CODRDS,DIRLOG,USRCRE,FCHCRE,USRACT,FCHACT")] Patrono patrono)
        {
            if (ModelState.IsValid)
            {
                patrono.FCHACT = DateTime.Now;
                db.Entry(patrono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patrono);
        }

        // GET: Patronos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patrono patrono = db.Patronoes.Find(id);
            if (patrono == null)
            {
                return HttpNotFound();
            }
            return View(patrono);
        }

        // POST: Patronos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patrono patrono = db.Patronoes.Find(id);
            db.Patronoes.Remove(patrono);
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
