using CrudMaquila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.produccion_terminada.ToList());
            }
        }

        // GET: ProduccionTerminada/Details/5
        public ActionResult Details(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.produccion_terminada.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: ProduccionTerminada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduccionTerminada/Create
        [HttpPost]
        public ActionResult Create(produccion_terminada Produccion_Terminada)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.produccion_terminada.Add(Produccion_Terminada);
                    context.SaveChanges();
                }

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
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.produccion_terminada.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: ProduccionTerminada/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, produccion_terminada Produccion_Terminada)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.Entry(Produccion_Terminada).State = EntityState.Modified;
                    context.SaveChanges();
                }

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
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.produccion_terminada.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: ProduccionTerminada/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    produccion_terminada Produccion_Terminada = context.produccion_terminada.Where(x => x.id == id).FirstOrDefault();
                    context.produccion_terminada.Remove(Produccion_Terminada);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
