using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;

namespace PPCRental.Controllers
{
    public class ContactUsController : Controller
    {
        PPCEntities db = new PPCEntities();
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string name, string phone, string email, string subject, string message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string content = System.IO.File.ReadAllText(Server.MapPath("~/Sendmail.html"));
                    content = content.Replace("{{name}}", name);
                    content = content.Replace("{{phone}}", phone);
                    content = content.Replace("{{email}}", email);
                    content = content.Replace("{{noidung}}", message);
                    content = content.Replace("{{tieude}}", subject);
                    var senderemail = new MailAddress("PPCRental2017t3@gmail.com", "Yêu cầu hỗ trợ từ: " + name);
                    var receiveremail = new MailAddress("infoppcrental@gmail.com", "Công ty PPC Rental");
                    var password = "a12345678b";
                    var sub = subject;
                    var body = content;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderemail.Address, password)
                    };

                    using (var mess = new MailMessage(senderemail, receiveremail)
                    {
                        Subject = subject,
                        IsBodyHtml = true,
                        Body = body
                    }
                    )
                    {
                        smtp.Send(mess);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Lỗi";
            }
            return View();
        }
    }
}