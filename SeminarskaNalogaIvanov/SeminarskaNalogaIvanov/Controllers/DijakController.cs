using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarskaNalogaIvanov.Controllers
{
    public class DijakController : Controller
    {
        // GET: Dijak
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Dijak/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dijak/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dijak/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dijak/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dijak/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dijak/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dijak/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
