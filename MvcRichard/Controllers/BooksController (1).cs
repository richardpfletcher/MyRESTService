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

        public ActionResult BooksMenu()
        {
            return View();
        }

        public ActionResult Actions()
        {
            LoadKeysActions s1 = LoadKeysActions.Instance();
            List<BookModel> items = LoadKeysActions.list;

            String Path = Server.MapPath("/Audio/Books/Actions");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Actions\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Actions/" + fullname));
                        break;
                    }
                }
            }

           



            ViewData["orderData"] = list;

            return View();
        }


        public ActionResult Auto()
        {
            LoadKeysAuto s1 = LoadKeysAuto.Instance();
            List<BookModel> items = LoadKeysAuto.list;

            String Path = Server.MapPath("/Audio/Books/Auto");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Auto\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Auto/" + fullname));
                        break;
                    }
                }
            }

          

            ViewData["orderData"] = list;

            return View();
        }




        public ActionResult Universe()
        {
            LoadKeysUniverse s1 = LoadKeysUniverse.Instance();
            List<BookModel> items = LoadKeysUniverse.list;

            String Path = Server.MapPath("/Audio/Books/Universe");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Universe\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Universe/" + fullname));
                        break;
                    }
                }
            }

           

            ViewData["orderData"] = list;

            return View();
        }



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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Laws\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Laws/" + fullname));
                        break;
                    }
                }
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

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Kids()
        {

            LoadKeysDragoms s1 = LoadKeysDragoms.Instance();
            List<BookModel> items = LoadKeysDragoms.list;

            String Path = Server.MapPath("/Audio/Books/Kids");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Kids\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Kids/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
           
        }

        public ActionResult StarDust()
        {

            LoadKeysStarDust s1 = LoadKeysStarDust.Instance();
            List<BookModel> items = LoadKeysStarDust.list;

            String Path = Server.MapPath("/Audio/Books/StarDust");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\StarDust\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/StarDust/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult Kindness()
        {

            LoadKeysKindness s1 = LoadKeysKindness.Instance();
            List<BookModel> items = LoadKeysKindness.list;

            String Path = Server.MapPath("/Audio/Books/Kindness");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Kindness\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Kindness/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Journey()
        {

            LoadKeysJourney s1 = LoadKeysJourney.Instance();
            List<BookModel> items = LoadKeysJourney.list;

            String Path = Server.MapPath("/Audio/Books/Journey");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Journey\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Journey/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Swan()
        {

            LoadKeysSwan s1 = LoadKeysSwan.Instance();
            List<BookModel> items = LoadKeysSwan.list;

            String Path = Server.MapPath("/Audio/Books/Swan");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Swan\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Swan/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult FromMeToWe()
        {

            LoadKeysFromMeToWe s1 = LoadKeysFromMeToWe.Instance();
            List<BookModel> items = LoadKeysFromMeToWe.list;

            String Path = Server.MapPath("/Audio/Books/FromMeToWe");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\FromMeToWe\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/FromMeToWe/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Gaia()
        {

            LoadKeysGaia s1 = LoadKeysGaia.Instance();
            List<BookModel> items = LoadKeysGaia.list;

            String Path = Server.MapPath("/Audio/Books/Gaia");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Gaia\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Gaia/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Garden()
        {

            LoadKeysGarden s1 = LoadKeysGarden.Instance();
            List<BookModel> items = LoadKeysGarden.list;

            String Path = Server.MapPath("/Audio/Books/Garden");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Garden\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Garden/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Meditation()
        {

            LoadKeysMeditation s1 = LoadKeysMeditation.Instance();
            List<BookModel> items = LoadKeysMeditation.list;

            String Path = Server.MapPath("/Audio/Books/Meditation");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Meditation\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Meditation/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Fractal()
        {

            LoadKeysFractal s1 = LoadKeysFractal.Instance();
            List<BookModel> items = LoadKeysFractal.list;

            String Path = Server.MapPath("/Audio/Books/Fractal");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Fractal\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Fractal/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Surfing()
        {

            LoadKeysSurfing s1 = LoadKeysSurfing.Instance();
            List<BookModel> items = LoadKeysSurfing.list;

            String Path = Server.MapPath("/Audio/Books/Surfing");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Surfing\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Surfing/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Family()
        {

            LoadKeysFamily s1 = LoadKeysFamily.Instance();
            List<BookModel> items = LoadKeysFamily.list;

            String Path = Server.MapPath("/Audio/Books/Family");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Family\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Family/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult Happiness()
        {

            LoadKeysHappiness s1 = LoadKeysHappiness.Instance();
            List<BookModel> items = LoadKeysHappiness.list;

            String Path = Server.MapPath("/Audio/Books/Happiness");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Happiness\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Happiness/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Politics()
        {

            LoadKeysPolitics s1 = LoadKeysPolitics.Instance();
            List<BookModel> items = LoadKeysPolitics.list;

            String Path = Server.MapPath("/Audio/Books/Politics");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Politics\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Politics/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Death()
        {

            LoadKeysDeath s1 = LoadKeysDeath.Instance();
            List<BookModel> items = LoadKeysDeath.list;

            String Path = Server.MapPath("/Audio/Books/Death");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Death\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Death/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Human()
        {

            LoadKeysHuman s1 = LoadKeysHuman.Instance();
            List<BookModel> items = LoadKeysHuman.list;

            String Path = Server.MapPath("/Audio/Books/Human");
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

                    if (shortname.ToUpper() == data.Chapter.ToUpper())
                    {
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Human\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Human/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

    }
}