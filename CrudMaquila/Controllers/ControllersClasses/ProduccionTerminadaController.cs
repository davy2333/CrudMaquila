using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMaquila.Controllers.ControllersClasses
{
    public class ProduccionTerminadaController : Controller
    {
        // GET: ProduccionTerminada
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProduccionTerminada/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduccionTerminada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduccionTerminada/Create
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

        // GET: ProduccionTerminada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduccionTerminada/Edit/5
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

        // GET: ProduccionTerminada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduccionTerminada/Delete/5
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
