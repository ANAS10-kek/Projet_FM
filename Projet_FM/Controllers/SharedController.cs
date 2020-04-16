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
        // GET: Shared
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _OngletContact(string Email, string Subject, string Message, string  Name)
        {

            if (ModelState.IsValid)
            {
                using (MailMessage mm = new MailMessage("test123.Anas@gmail.com", Email))
                {
                    mm.IsBodyHtml = true;
                    mm.Subject = Subject;
                    string body = "  <div style=\"border - top:3px solid #22BCE5\"> </div><span style= \"font-family:Arial;font-size:10pt\" ><b>" +Name + "</b>,</hr>" +Message + " </ span > ";
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
                return RedirectToAction("Index", "Home");
            }
            else
            {

                return RedirectToAction("Index", "Home");
            }
            //}
            //catch (Exception)
            //{
            //    ViewBag.Error = "Some Error";
            //}
        }
    }
}