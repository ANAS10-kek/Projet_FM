using Projet_FM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Projet_FM.Controllers
{
    public class SharedController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Shared
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _OngletContact(string Email_M, string Subject_M, string Message_M, string  Name_M,MailViewModel mailViewModel)
        {

            if (ModelState.IsValid)
            {
                using (MailMessage mm = new MailMessage("test123.Anas@gmail.com", Email_M))
                {
                    mm.IsBodyHtml = true;
                    mm.Subject = Subject_M;
                    string body = "  <div style=\"border - top:3px solid #22BCE5\"> </div><span style= \"font-family:Arial;font-size:10pt\" ><b>" + Name_M + "</b>,</hr>" + Message_M + " </ span > ";
                    mm.Body = body;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("test123.Anas@gmail.com", "essahl1@&");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                }
                mailViewModel.Email_M = Email_M;
                mailViewModel.Message_M = Message_M;
                mailViewModel.Name_M = Name_M;
                mailViewModel.Subject_M = Subject_M;
                db.Mails.Add(mailViewModel);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            else
            {

                return RedirectToAction("Index", "Home");
            }
        }
    }
}