using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MvcRichard.Factory;


namespace MvcRichard.Controllers
{
    public class TalksController : Controller
    {
        //
        // GET: /Talks/

        public ActionResult TalksMenu()
        {
            return View();
        }

        public ActionResult Talks2017()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2017");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                { 
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2017\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2017/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }

        public ActionResult Talks2018()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2018");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2018\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2018/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }

        public ActionResult Talks2019()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2019");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2019\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2019/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }
        public ActionResult Talks2020()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2020");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2020\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2020/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }

        public ActionResult Talks2021()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2021");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2021\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2021/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }

        public ActionResult Talks2022()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2022");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2022\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2022/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }

        public ActionResult Talks2023()
        {
            String Path = Server.MapPath("/Audio/Talks/Talks2023");
            String[] FileNames = Directory.GetFiles(Path);
            Array.Reverse(FileNames);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                if (shortname != "Intro" && shortname != "album" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Talks\\Talks2023\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Talks/Talks2023/" + fullname));
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;
            return View();
        }


    }
}