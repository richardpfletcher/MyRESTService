using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MvcRichard.Models;

namespace MvcRichard.Controllers
{
    public class Sayings2021Controller : Controller
    {

        public ActionResult Sayings27()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings27");
            String[] FileNames = Directory.GetFiles(Path);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname.ToUpper() != "ALBUM" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings25\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings27/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }

    }
}
