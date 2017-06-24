using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class MetododePagoporBancosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: MetododePagoporBancos
        public ActionResult Index()
        {
            return View(db.MetododePagoporBancoes.ToList());
        }

        // GET: MetododePagoporBancos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetododePagoporBanco metododePagoporBanco = db.MetododePagoporBancoes.Find(id);
            if (metododePagoporBanco == null)
            {
                return HttpNotFound();
            }
            return View(metododePagoporBanco);
        }

        // GET: MetododePagoporBancos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetododePagoporBancos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODMTD,CODBCO,CPTOCTB,CODCTA,USRCRE,FCHCRE,USRACT,FCHACT")] MetododePagoporBanco metododePagoporBanco)
        {
            if (ModelState.IsValid)
            {
                metododePagoporBanco.FCHCRE = DateTime.Now;
                db.MetododePagoporBancoes.Add(metododePagoporBanco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metododePagoporBanco);
        }

        // GET: MetododePagoporBancos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetododePagoporBanco metododePagoporBanco = db.MetododePagoporBancoes.Find(id);
            if (metododePagoporBanco == null)
            {
                return HttpNotFound();
            }
            return View(metododePagoporBanco);
        }

        // POST: MetododePagoporBancos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODMTD,CODBCO,CPTOCTB,CODCTA,USRCRE,FCHCRE,USRACT,FCHACT")] MetododePagoporBanco metododePagoporBanco)
        {
            if (ModelState.IsValid)
            {
                metododePagoporBanco.FCHACT = DateTime.Now;
                db.Entry(metododePagoporBanco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metododePagoporBanco);
        }

        // GET: MetododePagoporBancos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetododePagoporBanco metododePagoporBanco = db.MetododePagoporBancoes.Find(id);
            if (metododePagoporBanco == null)
            {
                return HttpNotFound();
            }
            return View(metododePagoporBanco);
        }

        // POST: MetododePagoporBancos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MetododePagoporBanco metododePagoporBanco = db.MetododePagoporBancoes.Find(id);
            db.MetododePagoporBancoes.Remove(metododePagoporBanco);
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
