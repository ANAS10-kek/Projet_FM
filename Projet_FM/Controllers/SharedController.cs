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
        public ActionResult _OngletContact(string From, string subject, string message, string name)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (MailMessage mm = new MailMessage("test123.Anas@gmail.com", From))
                    {
                        mm.IsBodyHtml = true;
                        mm.Subject = subject;
                        string body = "  <div style=\"border - top:3px solid #22BCE5\"> </div><span style= \"font-family:Arial;font-size:10pt\" ><b>" + name + "</b>,</hr>" + message + " </ span > ";
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
                    return View("Home/Index");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }
    }
}