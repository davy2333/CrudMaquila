using CrudMaquila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMaquila.Controllers.ControllersClasses
{
    public class InventarioController : Controller
    {
        // GET: Inventario
        public ActionResult Index()
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.inventario.ToList());
            }
        }

        // GET: Inventario/Details/5
        public ActionResult Details(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.inventario.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Inventario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        public ActionResult Create(inventario Inventario)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.inventario.Add(Inventario);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult Edit(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.inventario.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, inventario Inventario)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.Entry(Inventario).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventario/Delete/5
        public ActionResult Delete(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.inventario.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Inventario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    inventario Inventario = context.inventario.Where(x => x.id == id).FirstOrDefault();
                    context.inventario.Remove(Inventario);
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
