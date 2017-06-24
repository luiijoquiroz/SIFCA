using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class CondiciondePagosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: CondiciondePagos
        public ActionResult Index()
        {
            return View(db.CondiciondePagoes.ToList());
        }

        // GET: CondiciondePagos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CondiciondePago condiciondePago = db.CondiciondePagoes.Find(id);
            if (condiciondePago == null)
            {
                return HttpNotFound();
            }
            return View(condiciondePago);
        }

        // GET: CondiciondePagos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CondiciondePagos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODCDP,DESCPR,PRDOPG,DESCTO,USRCRE,FCHCRE,USRACT,FCHACT")] CondiciondePago condiciondePago)
        {
            if (ModelState.IsValid)
            {
                db.CondiciondePagoes.Add(condiciondePago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(condiciondePago);
        }

        // GET: CondiciondePagos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CondiciondePago condiciondePago = db.CondiciondePagoes.Find(id);
            if (condiciondePago == null)
            {
                return HttpNotFound();
            }
            return View(condiciondePago);
        }

        // POST: CondiciondePagos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODCDP,DESCPR,PRDOPG,DESCTO,USRCRE,FCHCRE,USRACT,FCHACT")] CondiciondePago condiciondePago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(condiciondePago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(condiciondePago);
        }

        // GET: CondiciondePagos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CondiciondePago condiciondePago = db.CondiciondePagoes.Find(id);
            if (condiciondePago == null)
            {
                return HttpNotFound();
            }
            return View(condiciondePago);
        }

        // POST: CondiciondePagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CondiciondePago condiciondePago = db.CondiciondePagoes.Find(id);
            db.CondiciondePagoes.Remove(condiciondePago);
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
