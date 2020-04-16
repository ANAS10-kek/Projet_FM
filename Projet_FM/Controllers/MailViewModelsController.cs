using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projet_FM.Models;

namespace Projet_FM.Controllers
{
    public class MailViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MailViewModels
        public ActionResult Index()
        {
            return View(db.Mails.ToList());
        }

        // GET: MailViewModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MailViewModel mailViewModel = db.Mails.Find(id);
            if (mailViewModel == null)
            {
                return HttpNotFound();
            }
            return View(mailViewModel);
        }

        // GET: MailViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MailViewModels/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Name,Subject,Message")] MailViewModel mailViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Mails.Add(mailViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mailViewModel);
        }

        // GET: MailViewModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MailViewModel mailViewModel = db.Mails.Find(id);
            if (mailViewModel == null)
            {
                return HttpNotFound();
            }
            return View(mailViewModel);
        }

        // POST: MailViewModels/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Name,Subject,Message")] MailViewModel mailViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mailViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mailViewModel);
        }

        // GET: MailViewModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MailViewModel mailViewModel = db.Mails.Find(id);
            if (mailViewModel == null)
            {
                return HttpNotFound();
            }
            return View(mailViewModel);
        }

        // POST: MailViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MailViewModel mailViewModel = db.Mails.Find(id);
            db.Mails.Remove(mailViewModel);
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
