using ProektIT_193238.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ProektIT_193238.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.loginSuccess = TempData["login"];
            ViewBag.registerSuccess = TempData["register"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(Email model)
        {
            using (MailMessage mm = new MailMessage(model.UserEmail, "computermadness02@gmail.com"))
            {
                mm.Subject = model.Subject;
                mm.Body = model.Body;

                mm.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;

                    NetworkCredential cred = new NetworkCredential(model.UserEmail, model.Password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = cred;
                    smtp.Port = 587;


                    try
                    {
                        smtp.Send(mm);
                        ViewBag.Message = "Email Sent. We will get back to you as soon as we can.";
                    }
                    catch (Exception e)
                    {
                        var msg = "Something went wrong, make sure you entered valid google email!";
                        ViewBag.errorMessage = msg;
                    }
                }
            }
            return View();
        }
    }
}