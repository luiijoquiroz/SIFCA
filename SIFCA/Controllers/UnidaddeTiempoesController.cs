using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SIFCA.Models;

namespace SIFCA.Controllers
{
    public class UnidaddeTiempoesController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: UnidaddeTiempoes
        public ActionResult Index()
        {
            return View(db.UnidaddeTiempoes.ToList());
        }

        // GET: UnidaddeTiempoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidaddeTiempo unidaddeTiempo = db.UnidaddeTiempoes.Find(id);
            if (unidaddeTiempo == null)
            {
                return HttpNotFound();
            }
            return View(unidaddeTiempo);
        }

        // GET: UnidaddeTiempoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnidaddeTiempoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODUND,DESCPR,PRIODT,USRCRE,FCHCRE,USRACT,FCHACT")] UnidaddeTiempo unidaddeTiempo)
        {
            if (ModelState.IsValid)
            {
                db.UnidaddeTiempoes.Add(unidaddeTiempo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unidaddeTiempo);
        }

        // GET: UnidaddeTiempoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidaddeTiempo unidaddeTiempo = db.UnidaddeTiempoes.Find(id);
            if (unidaddeTiempo == null)
            {
                return HttpNotFound();
            }
            return View(unidaddeTiempo);
        }

        // POST: UnidaddeTiempoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODUND,DESCPR,PRIODT,USRCRE,FCHCRE,USRACT,FCHACT")] UnidaddeTiempo unidaddeTiempo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unidaddeTiempo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unidaddeTiempo);
        }

        // GET: UnidaddeTiempoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnidaddeTiempo unidaddeTiempo = db.UnidaddeTiempoes.Find(id);
            if (unidaddeTiempo == null)
            {
                return HttpNotFound();
            }
            return View(unidaddeTiempo);
        }

        // POST: UnidaddeTiempoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UnidaddeTiempo unidaddeTiempo = db.UnidaddeTiempoes.Find(id);
            db.UnidaddeTiempoes.Remove(unidaddeTiempo);
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
