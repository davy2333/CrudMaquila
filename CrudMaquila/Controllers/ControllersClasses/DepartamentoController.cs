using CrudMaquila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMaquila.Controllers.ControllersClasses
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.departamento.ToList());
            }
        }

        // GET: Departamento/Details/5
        public ActionResult Details(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.departamento.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(departamento Departamento)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.departamento.Add(Departamento);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.departamento.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Departamento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, departamento Departamento)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    context.Entry(Departamento).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            using (maquilaEntities context = new maquilaEntities())
            {
                return View(context.departamento.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Departamento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (maquilaEntities context = new maquilaEntities())
                {
                    departamento Departamento = context.departamento.Where(x => x.id == id).FirstOrDefault();
                    context.departamento.Remove(Departamento);
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
