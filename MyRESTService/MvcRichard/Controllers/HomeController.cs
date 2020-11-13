using MvcRichard.Models;
using System.Net.Mail;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Links()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }


        public ActionResult Comments(EmailModel model)
        {
            string emailLoggedIn = "";

            //try
            //{
            //    if (Request.IsAuthenticated)
            //    {
            //        //MembershipUser mu = Membership.GetUser();
            //        //emailLoggedIn = mu.UserName;
            //        emailLoggedIn = User.Identity.Name;
            //        model.Email = emailLoggedIn;
            //    }
            //}
            //catch
            //{
            //    emailLoggedIn = ""; //user logged in
            //    //return View(); //user not logeed in
            //}
            emailLoggedIn = ""; //user logged in

            ViewData["emailLoggedIn"] = emailLoggedIn;

            ViewData["message"] = "";

            if (ModelState.IsValid)
            {
                CommentsPost(model);
            }

            return this.View(model);
        }

        public ActionResult CommentsPost(EmailModel model)
        {
            SmtpClient smtpClient = new SmtpClient();
            string EmailFrom = model.Email;
            string EmailTo = "richardpfletcher@gmail.com";

            try
            {
                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    using (var message = new MailMessage(EmailFrom, EmailTo))
                    {
                        message.Subject = "Comments from user " + model.Email;
                        message.Body = model.Comments;
                        MailAddress bcc = new MailAddress(EmailFrom);
                        message.CC.Add(bcc);

                        message.IsBodyHtml = true;

                        //client.Credentials = new System.Net.NetworkCredential("whatscookingtreasures@gmail.com", "Barbara_2222");
                        client.Credentials = new System.Net.NetworkCredential("evolutionrevolutionoflove@gmail.com", "Chanda_1111");
                        client.EnableSsl = true;
                        client.Send(message);
                    };
                };
            }
            catch
            {
            }

            ViewData["message"] = "Email is sent";

            return RedirectToAction("Index", "Home");
        }
    }
}