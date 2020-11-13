using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random rand = new Random();
            int randomSayings = rand.Next(1, 11);

            String Path;
            String[] FileNames;

            if (randomSayings == 1)
            {
                Path = Server.MapPath("/Audio/CD");
                FileNames = Directory.GetFiles(Path);
            }
            else
            {
                Path = Server.MapPath("/Audio/Sayings/Sayings" + randomSayings);
                FileNames = Directory.GetFiles(Path);
            }

            List<DocumentModel> list = new List<DocumentModel>();
            int random = 1;
            try
            {
                random = rand.Next(1, FileNames.Length - 1);
            }
            catch (Exception ex)
            {
                random = 1;
            }

            

            int counter = 1;

            foreach (string path in FileNames) //iterate the file list
            {
                if (counter == random)
                {
                    string x = path;

                    // Find the last occurrence of \.
                    int index1 = x.LastIndexOf('\\');
                    string fullname = x.Substring(index1 + 1);

                    string shortname = fullname.Substring(0, fullname.Length - 4);

                    if (randomSayings == 1)
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/" + fullname));
                    }
                    else
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings9\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings" + randomSayings + "/" + fullname));
                    }
                    break;
                }
                counter++;
            }

            ViewData["orderData"] = list;

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
          //string EmailTo = "richardpfletcher@gmail.com";
          string EmailTo = "evolutionrevolutionoflove@gmail.com";


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