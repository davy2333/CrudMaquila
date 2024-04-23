using CrudMaquila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMaquila.Controllers.ControllersClasses
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.clientes.ToList());
            }
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.clientes.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(clientes Clientes)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.clientes.Add(Clientes);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.clientes.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, clientes Clientes)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.Entry(Clientes).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.clientes.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    clientes Clientes = context.clientes.Where(x => x.id == id).FirstOrDefault();
                    context.clientes.Remove(Clientes);
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
