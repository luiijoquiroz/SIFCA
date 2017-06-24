using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class MetododePagoesController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: MetododePagoes
        public ActionResult Index()
        {
            return View(db.MetododePagoes.ToList());
        }

        // GET: MetododePagoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetododePago metododePago = db.MetododePagoes.Find(id);
            if (metododePago == null)
            {
                return HttpNotFound();
            }
            return View(metododePago);
        }

        // GET: MetododePagoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MetododePagoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODMTD,DESCPR,MNTOMX,USRCRE,FCHCRE,USRACT,FCHACT")] MetododePago metododePago)
        {
            if (ModelState.IsValid)
            {
                metododePago.FCHCRE = DateTime.Now;
                db.MetododePagoes.Add(metododePago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metododePago);
        }

        // GET: MetododePagoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetododePago metododePago = db.MetododePagoes.Find(id);
            if (metododePago == null)
            {
                return HttpNotFound();
            }
            return View(metododePago);
        }

        // POST: MetododePagoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODMTD,DESCPR,MNTOMX,USRCRE,FCHCRE,USRACT,FCHACT")] MetododePago metododePago)
        {
            if (ModelState.IsValid)
            {
                metododePago.FCHACT = DateTime.Now;
                db.Entry(metododePago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metododePago);
        }

        // GET: MetododePagoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MetododePago metododePago = db.MetododePagoes.Find(id);
            if (metododePago == null)
            {
                return HttpNotFound();
            }
            return View(metododePago);
        }

        // POST: MetododePagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MetododePago metododePago = db.MetododePagoes.Find(id);
            db.MetododePagoes.Remove(metododePago);
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
