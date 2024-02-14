using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MvcRichard.Factory;


namespace MvcRichard.Controllers
{
    public class JohnsMusicController : Controller
    {
        public ActionResult JohnsMusicMenu()
        {
            return View();
        }


        public ActionResult Series110()
        {
            String Path = Server.MapPath("/Audio/JohnsMusic/Series110");
            String[] FileNames = Directory.GetFiles(Path);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of N.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname == "Intro")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\JohnsMusic\\Series110\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/JohnsMusic/Series110/" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "Intro" && shortname != "album")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\JohnsMusic\\Series110\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/JohnsMusic/Series110/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

    }
}
