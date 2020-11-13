using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class CDController : Controller
    {
        //
        // GET: /CD/

        public ActionResult CD(int id)
        {
            String Path = Server.MapPath("/Audio/CD");
            String[] FileNames = Directory.GetFiles(Path);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of N.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname == "intro")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "intro")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\" + fullname));
                }
            }

            ViewData["orderData"] = list;

            return View();
        }
    }
}