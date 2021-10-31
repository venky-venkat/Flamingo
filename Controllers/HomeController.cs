using Flamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Flamingo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Services()
        {
            return View();
        }
        public ActionResult _CountryView()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult SendMail(ResponsesModel resp)
        {
            try
            {
                resp.Id = Guid.NewGuid();               
                string from = "admin@promisinghearts.com";
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(from);
                message.To.Add(new MailAddress("ravikiran1312@gmail.com"));
                message.Subject = resp.Subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = resp.Message;
                smtp.Port = 587;
                smtp.Host = "promisinghearts.com"; //for gmail host  
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from, "pheart#132");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                using (var context = new ResponseContext())
                {

                    context.Responses.Add(resp);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {                
            }
            return Content("ok");
        }
    }
}