using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MvcRichard.Factory;

namespace MvcRichard.Controllers
{
    public class Sayings2022Controller : Controller
    {

       

        public ActionResult Sayings29()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings29");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings29\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings29/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings30()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings30");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings30\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings30/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }







    }
}
