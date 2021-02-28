using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MvcRichard.Factory;

namespace MvcRichard.Controllers
{
    public class CD2021Controller : Controller
    {
        
        public ActionResult CD83()
        {
            String Path = Server.MapPath("/Audio/CD/CD83");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD83\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD83/" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "Intro" && shortname.ToUpper() != "ALBUM" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD83\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD83/" + fullname));
                }
            }

            //comment this out
            //used only for adding albums when done
            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

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

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;

            return View();
        }


        public ActionResult CD84()
        {
            String Path = Server.MapPath("/Audio/CD/CD84");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD84\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD84/" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "Intro" && shortname.ToUpper() != "ALBUM" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD84\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD84/" + fullname));
                }
            }

            //comment this out
            //used only for adding albums when done
            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

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

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult CD85()
        {
            String Path = Server.MapPath("/Audio/CD/CD85");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD85\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD85/" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "Intro" && shortname.ToUpper() != "ALBUM" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD85\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD85/" + fullname));
                }
            }

            //comment this out
            //used only for adding albums when done
            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

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

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;

            return View();
        }


        public ActionResult CD86()
        {
            String Path = Server.MapPath("/Audio/CD/CD86");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD86\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD86/" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "Intro" && shortname.ToUpper() != "ALBUM" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD86\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD86/" + fullname));
                }
            }

            //comment this out
            //used only for adding albums when done
            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

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

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult CD87()
        {
            String Path = Server.MapPath("/Audio/CD/CD87");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD87\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD87/" + fullname));
                }
            }

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);

                string shortname = fullname.Substring(0, fullname.Length - 4);

                if (shortname != "Intro" && shortname.ToUpper() != "ALBUM" && shortname.ToUpper() != "ORGINAL")
                {
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD87\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD87/" + fullname));
                }
            }

            //comment this out
            //used only for adding albums when done
            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

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

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);

            ViewData["orderData"] = list;

            return View();
        }









    }
}
