using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class ConceptodeNominasController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: ConceptodeNominas
        public ActionResult Index()
        {
            return View(db.ConceptodeNominas.ToList());
        }

        // GET: ConceptodeNominas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomina conceptodeNomina = db.ConceptodeNominas.Find(id);
            if (conceptodeNomina == null)
            {
                return HttpNotFound();
            }
            return View(conceptodeNomina);
        }

        // GET: ConceptodeNominas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConceptodeNominas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODNOM,DESCPR,TIPMVTO")] Nomina conceptodeNomina)
        {
            if (ModelState.IsValid)
            {
                db.ConceptodeNominas.Add(conceptodeNomina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conceptodeNomina);
        }

        // GET: ConceptodeNominas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomina conceptodeNomina = db.ConceptodeNominas.Find(id);
            if (conceptodeNomina == null)
            {
                return HttpNotFound();
            }
            return View(conceptodeNomina);
        }

        // POST: ConceptodeNominas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODNOM,DESCPR,TIPMVTO")] Nomina conceptodeNomina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conceptodeNomina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conceptodeNomina);
        }

        // GET: ConceptodeNominas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nomina conceptodeNomina = db.ConceptodeNominas.Find(id);
            if (conceptodeNomina == null)
            {
                return HttpNotFound();
            }
            return View(conceptodeNomina);
        }

        // POST: ConceptodeNominas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nomina conceptodeNomina = db.ConceptodeNominas.Find(id);
            db.ConceptodeNominas.Remove(conceptodeNomina);
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
