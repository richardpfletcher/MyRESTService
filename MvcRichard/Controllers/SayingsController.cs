using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class SayingsController : Controller
    {
        //
        // GET: /Sayings/
        public ActionResult SayingsMenu()
        {
            return View();
        }

        


        public ActionResult Sayings15()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings15");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings15\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings15/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }




        public ActionResult Sayings14()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings14");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings14\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings14/" + fullname));
                }
            }


            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }



        public ActionResult Sayings13()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings13");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings13\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings13/" + fullname));
            }

           
            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);



            ViewData["orderData"] = list;

            return View();
        }




        public ActionResult Sayings12()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings12");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings12\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings12/" + fullname));
            }

            // comment out later
            // run as visual studio administor
            //convert all words to upper
            //foreach (string path in FileNames) //iterate the file list
            //{
            //    string x = path;

            //    // Find the last occurrence of \.
            //    int index1 = x.LastIndexOf('\\');
            //    string fullname = x.Substring(index1 + 1);

            //    string shortname = fullname.Substring(0, fullname.Length - 4);

            //    //string upperCase = UppercaseFirsts.ConvertFirst(shortname)+"1"+".mp3";

            //    // copy 1 back to
            //    string upperCase = UppercaseFirsts.ConvertFirst(shortname) + ".mp3";
            //    upperCase = upperCase.Substring(0, upperCase.Length - 5) + ".mp3"; ;

            //    if (System.IO.File.Exists(path))
            //    {
            //        Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(path, upperCase);
            //    }
            //}

           



            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings2()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings2");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings2\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings2/" + fullname));
            }

           

            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings3()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings3");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings3\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings3/" + fullname));
            }

           

            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings4()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings4");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings4\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings4/" + fullname));
            }


         

            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings5()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings5");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings5\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings5/" + fullname));
            }

            


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings6()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings6");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings6\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings6/" + fullname));
            }


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings7()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings7");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings7\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings7/" + fullname));
            }




            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings8()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings8");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings8\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings8/" + fullname));
            }


            

            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings9()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings9");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings9\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings9/" + fullname));
            }

          


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings10()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings10");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings10\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings10/" + fullname));
            }

           
            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Sayings11()
        {
            String Path = Server.MapPath("/Audio/Sayings/Sayings11");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings11\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Sayings/Sayings11/" + fullname));
            }

          

            ViewData["orderData"] = list;

            



            return View();
        }
    }
}