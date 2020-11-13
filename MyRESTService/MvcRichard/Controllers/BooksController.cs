using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        public ActionResult Laws()
        {
            LoadKeys s1 = LoadKeys.Instance();
            List<BookModel> items = LoadKeys.list;

            String Path = Server.MapPath("/Audio/Books/Laws");
            String[] FileNames = Directory.GetFiles(Path);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (var data in items) //iterate the file list
            {
                foreach (string path in FileNames) //iterate the file list
                {
                    string x = path;

                    // Find the last occurrence of N.
                    int index1 = x.LastIndexOf('\\');
                    string fullname = x.Substring(index1 + 1);

                    string shortname = fullname.Substring(0, fullname.Length - 4);

                    if (shortname == data.Chapter)
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Laws\\" + fullname));
                        break;
                    }
                }
            }

            ViewData["orderData"] = list;

            return View();
        }
    }
}