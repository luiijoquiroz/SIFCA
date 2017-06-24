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
    public class RedesSocialsController : Controller
    {
        private SIFCAContext db = new SIFCAContext();

        // GET: RedesSocials
        public ActionResult Index()
        {
            return View(db.RedesSocials.ToList());
        }

        // GET: RedesSocials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RedesSocial redesSocial = db.RedesSocials.Find(id);
            if (redesSocial == null)
            {
                return HttpNotFound();
            }
            return View(redesSocial);
        }

        // GET: RedesSocials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RedesSocials/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODRDS,DESCPR")] RedesSocial redesSocial)
        {
            if (ModelState.IsValid)
            {
                db.RedesSocials.Add(redesSocial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(redesSocial);
        }

        // GET: RedesSocials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RedesSocial redesSocial = db.RedesSocials.Find(id);
            if (redesSocial == null)
            {
                return HttpNotFound();
            }
            return View(redesSocial);
        }

        // POST: RedesSocials/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODRDS,DESCPR")] RedesSocial redesSocial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(redesSocial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(redesSocial);
        }

        // GET: RedesSocials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RedesSocial redesSocial = db.RedesSocials.Find(id);
            if (redesSocial == null)
            {
                return HttpNotFound();
            }
            return View(redesSocial);
        }

        // POST: RedesSocials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RedesSocial redesSocial = db.RedesSocials.Find(id);
            db.RedesSocials.Remove(redesSocial);
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
