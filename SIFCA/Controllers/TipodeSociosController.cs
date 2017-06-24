using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class TipodeSociosController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: TipodeSocios
        public ActionResult Index()
        {
            return View(db.TipodeSocios.ToList());
        }

        // GET: TipodeSocios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodeSocio tipodeSocio = db.TipodeSocios.Find(id);
            if (tipodeSocio == null)
            {
                return HttpNotFound();
            }
            return View(tipodeSocio);
        }

        // GET: TipodeSocios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipodeSocios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TIPSOC,DESCPR")] TipodeSocio tipodeSocio)
        {
            if (ModelState.IsValid)
            {
                db.TipodeSocios.Add(tipodeSocio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipodeSocio);
        }

        // GET: TipodeSocios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodeSocio tipodeSocio = db.TipodeSocios.Find(id);
            if (tipodeSocio == null)
            {
                return HttpNotFound();
            }
            return View(tipodeSocio);
        }

        // POST: TipodeSocios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TIPSOC,DESCPR")] TipodeSocio tipodeSocio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipodeSocio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipodeSocio);
        }

        // GET: TipodeSocios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipodeSocio tipodeSocio = db.TipodeSocios.Find(id);
            if (tipodeSocio == null)
            {
                return HttpNotFound();
            }
            return View(tipodeSocio);
        }

        // POST: TipodeSocios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipodeSocio tipodeSocio = db.TipodeSocios.Find(id);
            db.TipodeSocios.Remove(tipodeSocio);
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
