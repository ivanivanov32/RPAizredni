using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using seminarska.Data;
using seminarska.Models;

namespace seminarska.Controllers
{
    public class IzpitsController : Controller
    {
        private seminarskaContext db = new seminarskaContext();

        // GET: Izpits
        public ActionResult Index()
        {
            return View(db.Izpits.ToList());
        }

        // GET: Izpits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Izpit izpit = db.Izpits.Find(id);
            if (izpit == null)
            {
                return HttpNotFound();
            }
            return View(izpit);
        }

        // GET: Izpits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Izpits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IzpitId,IzpitIme,Ocena")] Izpit izpit)
        {
            if (ModelState.IsValid)
            {
                db.Izpits.Add(izpit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(izpit);
        }

        // GET: Izpits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Izpit izpit = db.Izpits.Find(id);
            if (izpit == null)
            {
                return HttpNotFound();
            }
            return View(izpit);
        }

        // POST: Izpits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IzpitId,IzpitIme,Ocena")] Izpit izpit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(izpit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(izpit);
        }

        // GET: Izpits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Izpit izpit = db.Izpits.Find(id);
            if (izpit == null)
            {
                return HttpNotFound();
            }
            return View(izpit);
        }

        // POST: Izpits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Izpit izpit = db.Izpits.Find(id);
            db.Izpits.Remove(izpit);
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
