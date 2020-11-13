using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;


namespace MvcRichard.Controllers
{
    public class Sayings2019Controller : Controller
    {

        public ActionResult Sayings20()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings20");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings20\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings20/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings21()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings21");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings21\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings21/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings22()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings22");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings22\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings22/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings23()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings23");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings23\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings23/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }





    }
}
