using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using MvcRichard.Factory;

namespace MvcRichard.Controllers
{
    public class CD2020Controller : Controller
    {
        public ActionResult CD72()
        {
            String Path = Server.MapPath("/Audio/CD/CD72");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD72\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD72/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD72\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD72/" + fullname));
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

        public ActionResult CD73()
        {
            String Path = Server.MapPath("/Audio/CD/CD73");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD73\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD73/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD73\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD73/" + fullname));
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

        public ActionResult CD74()
        {
            String Path = Server.MapPath("/Audio/CD/CD74");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD74\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD74/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD74\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD74/" + fullname));
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

        public ActionResult CD75()
        {
            String Path = Server.MapPath("/Audio/CD/CD75");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD75\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD75/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD75\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD75/" + fullname));
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

        public ActionResult CD76()
        {
            String Path = Server.MapPath("/Audio/CD/CD76");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD76\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD76/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD76\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD76/" + fullname));
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

        public ActionResult CD77()
        {
            String Path = Server.MapPath("/Audio/CD/CD77");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD77\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD77/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD77\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD77/" + fullname));
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


        public ActionResult CD78()
        {
            String Path = Server.MapPath("/Audio/CD/CD78");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD78\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD78/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD78\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD78/" + fullname));
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

        public ActionResult CD79()
        {
            String Path = Server.MapPath("/Audio/CD/CD79");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD79\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD79/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD79\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD79/" + fullname));
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

        public ActionResult CD80()
        {
            String Path = Server.MapPath("/Audio/CD/CD80");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD80\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD80/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD80\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD80/" + fullname));
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

        public ActionResult CD81()
        {
            String Path = Server.MapPath("/Audio/CD/CD81");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD81\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD81/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD81\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD81/" + fullname));
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

        public ActionResult CD82()
        {
            String Path = Server.MapPath("/Audio/CD/CD82");
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD82\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD82/" + fullname));
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
                    list.Add(new DocumentModel(fullname, shortname, "\\Audio\\CD\\CD82\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/CD/CD82/" + fullname));
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
