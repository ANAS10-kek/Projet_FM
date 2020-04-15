using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_FM.Controllers
{
    public class EatDrinkController : Controller
    {
        // GET: EatDrink
        public ActionResult Index()
        {
            return View();
        }

        // GET: EatDrink/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EatDrink/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EatDrink/Create
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

        // GET: EatDrink/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EatDrink/Edit/5
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

        // GET: EatDrink/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EatDrink/Delete/5
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
