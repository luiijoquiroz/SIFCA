using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class CatalogodeCuentasController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: CatalogodeCuentas
        public ActionResult Index()
        {
            return View(db.CatalogodeCuentas.ToList());
        }

        // GET: CatalogodeCuentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatalogodeCuenta catalogodeCuenta = db.CatalogodeCuentas.Find(id);
            if (catalogodeCuenta == null)
            {
                return HttpNotFound();
            }
            return View(catalogodeCuenta);
        }

        // GET: CatalogodeCuentas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatalogodeCuentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CTABCO,DESCPR,SUBNVL,TIPCTA,INDCDH")] CatalogodeCuenta catalogodeCuenta)
        {
            if (ModelState.IsValid)
            {
                db.CatalogodeCuentas.Add(catalogodeCuenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catalogodeCuenta);
        }

        // GET: CatalogodeCuentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatalogodeCuenta catalogodeCuenta = db.CatalogodeCuentas.Find(id);
            if (catalogodeCuenta == null)
            {
                return HttpNotFound();
            }
            return View(catalogodeCuenta);
        }

        // POST: CatalogodeCuentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CTABCO,DESCPR,SUBNVL,TIPCTA,INDCDH")] CatalogodeCuenta catalogodeCuenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catalogodeCuenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catalogodeCuenta);
        }

        // GET: CatalogodeCuentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatalogodeCuenta catalogodeCuenta = db.CatalogodeCuentas.Find(id);
            if (catalogodeCuenta == null)
            {
                return HttpNotFound();
            }
            return View(catalogodeCuenta);
        }

        // POST: CatalogodeCuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CatalogodeCuenta catalogodeCuenta = db.CatalogodeCuentas.Find(id);
            db.CatalogodeCuentas.Remove(catalogodeCuenta);
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
