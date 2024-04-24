using CrudMaquila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMaquila.Controllers.ControllersClasses
{
    public class ProveedoresController : Controller
    {
        // GET: Proveedores
        public ActionResult Index()
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.proveedores.ToList());
            }
        }

        // GET: Proveedores/Details/5
        public ActionResult Details(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.proveedores.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Proveedores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proveedores/Create
        [HttpPost]
        public ActionResult Create(proveedores Proveedores)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.proveedores.Add(Proveedores);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedores/Edit/5
        public ActionResult Edit(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.proveedores.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Proveedores/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, proveedores Proveedores)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.Entry(Proveedores).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedores/Delete/5
        public ActionResult Delete(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.proveedores.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Proveedores/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    proveedores Proveedores = context.proveedores.Where(x => x.id == id).FirstOrDefault();
                    context.proveedores.Remove(Proveedores);
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
