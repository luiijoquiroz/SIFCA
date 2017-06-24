using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class EjercicioFiscalsController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: EjercicioFiscals
        public ActionResult Index()
        {
            return View(db.EjercicioFiscals.ToList());
        }

        // GET: EjercicioFiscals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EjercicioFiscal ejercicioFiscal = db.EjercicioFiscals.Find(id);
            if (ejercicioFiscal == null)
            {
                return HttpNotFound();
            }
            return View(ejercicioFiscal);
        }

        // GET: EjercicioFiscals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EjercicioFiscals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODEJERC,DESCPR,FCHINI,FCHFIN,USRCRE,FCHCRE,USRACT,FCHACT")] EjercicioFiscal ejercicioFiscal)
        {
            if (ModelState.IsValid)
            {   //Paso Fecha
                ejercicioFiscal.FCHCRE = DateTime.Now;
                db.EjercicioFiscals.Add(ejercicioFiscal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ejercicioFiscal);
        }

        // GET: EjercicioFiscals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EjercicioFiscal ejercicioFiscal = db.EjercicioFiscals.Find(id);
            if (ejercicioFiscal == null)
            {
                return HttpNotFound();
            }
            return View(ejercicioFiscal);
        }

        // POST: EjercicioFiscals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODEJERC,DESCPR,FCHINI,FCHFIN,USRCRE,FCHCRE,USRACT,FCHACT")] EjercicioFiscal ejercicioFiscal)
        {
            if (ModelState.IsValid)
            {   
                //Paso fecha
                ejercicioFiscal.FCHACT = DateTime.Now;
                db.Entry(ejercicioFiscal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ejercicioFiscal);
        }

        // GET: EjercicioFiscals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EjercicioFiscal ejercicioFiscal = db.EjercicioFiscals.Find(id);
            if (ejercicioFiscal == null)
            {
                return HttpNotFound();
            }
            return View(ejercicioFiscal);
        }

        // POST: EjercicioFiscals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EjercicioFiscal ejercicioFiscal = db.EjercicioFiscals.Find(id);
            db.EjercicioFiscals.Remove(ejercicioFiscal);
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
