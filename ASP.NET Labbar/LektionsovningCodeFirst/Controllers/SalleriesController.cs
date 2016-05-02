using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LektionsovningCodeFirst;

namespace LektionsovningCodeFirst.Controllers
{
    public class SalleriesController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: Salleries
        public ActionResult Index()
        {
            return View(db.Salleries.ToList());
        }

        // GET: Salleries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sallery sallery = db.Salleries.Find(id);
            if (sallery == null)
            {
                return HttpNotFound();
            }
            return View(sallery);
        }

        // GET: Salleries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salleries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalleryId,Date,WorkedHours,HoursOfPeriod,MoneyOut")] Sallery sallery)
        {
            if (ModelState.IsValid)
            {
                db.Salleries.Add(sallery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sallery);
        }

        // GET: Salleries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sallery sallery = db.Salleries.Find(id);
            if (sallery == null)
            {
                return HttpNotFound();
            }
            return View(sallery);
        }

        // POST: Salleries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalleryId,Date,WorkedHours,HoursOfPeriod,MoneyOut")] Sallery sallery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sallery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sallery);
        }

        // GET: Salleries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sallery sallery = db.Salleries.Find(id);
            if (sallery == null)
            {
                return HttpNotFound();
            }
            return View(sallery);
        }

        // POST: Salleries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sallery sallery = db.Salleries.Find(id);
            db.Salleries.Remove(sallery);
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
