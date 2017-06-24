using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class DependenciasController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: Dependencias
        public ActionResult Index()
        {
            return View(db.Dependencias.ToList());
        }

        // GET: Dependencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependencia dependencia = db.Dependencias.Find(id);
            if (dependencia == null)
            {
                return HttpNotFound();
            }
            return View(dependencia);
        }

        // GET: Dependencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dependencias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODDEP,DESCPR,CODDIR,USRCRE,FCHCRE,USRACT,FCHACT")] Dependencia dependencia)
        {
            if (ModelState.IsValid)
            {
                db.Dependencias.Add(dependencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dependencia);
        }

        // GET: Dependencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependencia dependencia = db.Dependencias.Find(id);
            if (dependencia == null)
            {
                return HttpNotFound();
            }
            return View(dependencia);
        }

        // POST: Dependencias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODDEP,DESCPR,CODDIR,USRCRE,FCHCRE,USRACT,FCHACT")] Dependencia dependencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dependencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dependencia);
        }

        // GET: Dependencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dependencia dependencia = db.Dependencias.Find(id);
            if (dependencia == null)
            {
                return HttpNotFound();
            }
            return View(dependencia);
        }

        // POST: Dependencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dependencia dependencia = db.Dependencias.Find(id);
            db.Dependencias.Remove(dependencia);
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
