using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
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

        public ActionResult Hardwired()
        {

            LoadKeysHardwired s1 = LoadKeysHardwired.Instance();
            List<BookModel> items = LoadKeysHardwired.list;

            String Path = Server.MapPath("/Audio/Books/Hardwired");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Hardwired\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Hardwired/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Quantum()
        {

            LoadKeysQuantum s1 = LoadKeysQuantum.Instance();
            List<BookModel> items = LoadKeysQuantum.list;

            String Path = Server.MapPath("/Audio/Books/Quantum");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Quantum\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Quantum/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Dreams()
        {

            LoadKeysDreams s1 = LoadKeysDreams.Instance();
            List<BookModel> items = LoadKeysDreams.list;

            String Path = Server.MapPath("/Audio/Books/Dreams");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Dreams\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Dreams/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Dragons2()
        {

            LoadKeysZoran1 s1 = LoadKeysZoran1.Instance();
            List<BookModel> items = LoadKeysZoran1.list;

            String Path = Server.MapPath("/Audio/Books/Dragons2");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Dragons2\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Dragons2/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Cloudy()
        {

            LoadKeysCloudy s1 = LoadKeysCloudy.Instance();
            List<BookModel> items = LoadKeysCloudy.list;

            String Path = Server.MapPath("/Audio/Books/Cloudy");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Cloudy\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Cloudy/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }



        public ActionResult OverTheHill()
        {

            LoadKeysOverTheHill s1 = LoadKeysOverTheHill.Instance();
            List<BookModel> items = LoadKeysOverTheHill.list;

            String Path = Server.MapPath("/Audio/Books/OverTheHill");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\OverTheHill\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/OverTheHill/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Kabbalah()
        {

            LoadKeysKabbalah s1 = LoadKeysKabbalah.Instance();
            List<BookModel> items = LoadKeysKabbalah.list;

            String Path = Server.MapPath("/Audio/Books/Kabbalah");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Kabbalah\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Kabbalah/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult SuperBowl()
        {

            LoadKeysSuperBowl s1 = LoadKeysSuperBowl.Instance();
            List<BookModel> items = LoadKeysSuperBowl.list;

            String Path = Server.MapPath("/Audio/Books/SuperBowl");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\SuperBowl\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/SuperBowl/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Corona()
        {

            LoadKeysCorona s1 = LoadKeysCorona.Instance();
            List<BookModel> items = LoadKeysCorona.list;

            String Path = Server.MapPath("/Audio/Books/Corona");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Corona\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Corona/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }
        public ActionResult TheWay()
        {

            LoadKeysTheWay s1 = LoadKeysTheWay.Instance();
            List<BookModel> items = LoadKeysTheWay.list;

            String Path = Server.MapPath("/Audio/Books/TheWay");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\TheWay\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/TheWay/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        [Route("/{chapter}")]

        //Please Select one

        public ActionResult HeartOfGold(string chapter)
        {


            string[] AgeRagne = new string[] { "Please Select one", "Indian Mystics", "Sufi", "Islam", "Jewish", "Western", "Hindu", "Sikh", "Taoist", "Jainism", "Buddhist", "Science", "Current", "Indigenous" };


            List<SelectListItem> itemsAge = new List<SelectListItem>();
            for (int i = 0; i < AgeRagne.Length; i++)
            {


                itemsAge.Add(new SelectListItem { Text = AgeRagne[i], Value = AgeRagne[i] });
            }

            foreach (SelectListItem s in itemsAge)
            {
                if (s.Value == chapter)
                {
                    s.Selected = true;
                }
            }



            ViewData["ethnicData"] = itemsAge;

            string chap = chapter;
            //LoadKeysHeartOfGold s1 = LoadKeysHeartOfGold.Instance(chapter);
            LoadKeysHeartOfGold s1 = new LoadKeysHeartOfGold(chapter);
            //s1.chapter = chapter;
            List<BookModel> items = LoadKeysHeartOfGold.list;

            String Path = Server.MapPath("/Audio/Books/HeartOfGold");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\HeartOfGold\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/HeartOfGold/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            //return View();
            return PartialView("HeartOfGold");

        }

        public ActionResult Creative()
        {

            LoadKeysCreative s1 = LoadKeysCreative.Instance();
            List<BookModel> items = LoadKeysCreative.list;

            String Path = Server.MapPath("/Audio/Books/Creative");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Creative\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Creative/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Yoga()
        {

            LoadKeysYoga s1 = LoadKeysYoga.Instance();
            List<BookModel> items = LoadKeysYoga.list;

            String Path = Server.MapPath("/Audio/Books/Yoga");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Yoga\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Yoga/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult NonViolence()
        {

            LoadKeysNonViolence s1 = LoadKeysNonViolence.Instance();
            List<BookModel> items = LoadKeysNonViolence.list;

            String Path = Server.MapPath("/Audio/Books/NonViolence");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\NonViolence\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/NonViolence/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult KnowthySelf()
        {

            LoadKeysKnowthySelf s1 = LoadKeysKnowthySelf.Instance();
            List<BookModel> items = LoadKeysKnowthySelf.list;

            String Path = Server.MapPath("/Audio/Books/KnowthySelf");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\KnowthySelf\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/KnowthySelf/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult WhoAmI()
        {

            LoadKeysWhoAmI s1 = LoadKeysWhoAmI.Instance();
            List<BookModel> items = LoadKeysWhoAmI.list;

            String Path = Server.MapPath("/Audio/Books/WhoAmI");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\WhoAmI\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/WhoAmI/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Tricks()
        {

            LoadKeysTricks s1 = LoadKeysTricks.Instance();
            List<BookModel> items = LoadKeysTricks.list;

            String Path = Server.MapPath("/Audio/Books/Tricks");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Tricks\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Tricks/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult Shamanism()
        {

            LoadKeysShamanism s1 = LoadKeysShamanism.Instance();
            List<BookModel> items = LoadKeysShamanism.list;

            String Path = Server.MapPath("/Audio/Books/Shamanism");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Shamanism\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Shamanism/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Storytelling()
        {

            LoadKeysStorytelling s1 = LoadKeysStorytelling.Instance();
            List<BookModel> items = LoadKeysStorytelling.list;

            String Path = Server.MapPath("/Audio/Books/Storytelling");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Storytelling\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Storytelling/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult ThePhysicsOfSpirituality()
        {

            LoadKeysThePhysicsOfSpirituality s1 = LoadKeysThePhysicsOfSpirituality.Instance();
            List<BookModel> items = LoadKeysThePhysicsOfSpirituality.list;

            String Path = Server.MapPath("/Audio/Books/ThePhysicsOfSpirituality");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\ThePhysicsOfSpirituality\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/ThePhysicsOfSpirituality/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult KingdomOfHeavenLiesInside()
        {

            LoadKeysKingdomOfHeavenLiesInside s1 = LoadKeysKingdomOfHeavenLiesInside.Instance();
            List<BookModel> items = LoadKeysKingdomOfHeavenLiesInside.list;

            String Path = Server.MapPath("/Audio/Books/KingdomOfHeavenLiesInside");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\KingdomOfHeavenLiesInside\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/KingdomOfHeavenLiesInside/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult JatakaTales()
        {

            LoadKeysJatakaTales s1 = LoadKeysJatakaTales.Instance();
            List<BookModel> items = LoadKeysJatakaTales.list;

            String Path = Server.MapPath("/Audio/Books/JatakaTales");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\JatakaTales\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/JatakaTales/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult SparkTales()
        {

            LoadKeysSparkTales s1 = LoadKeysSparkTales.Instance();
            List<BookModel> items = LoadKeysSparkTales.list;

            String Path = Server.MapPath("/Audio/Books/SparkTales");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\SparkTales\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/SparkTales/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Pandora()
        {

            LoadKeysPandora s1 = LoadKeysPandora.Instance();
            List<BookModel> items = LoadKeysPandora.list;

            String Path = Server.MapPath("/Audio/Books/Pandora");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Pandora\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Pandora/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult JaiJinendra()
        {

            LoadKeysJaiJinendra s1 = LoadKeysJaiJinendra.Instance();
            List<BookModel> items = LoadKeysJaiJinendra.list;

            String Path = Server.MapPath("/Audio/Books/JaiJinendra");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\JaiJinendra\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/JaiJinendra/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Harmony()
        {

            LoadKeysHarmony s1 = LoadKeysHarmony.Instance();
            List<BookModel> items = LoadKeysHarmony.list;

            String Path = Server.MapPath("/Audio/Books/Harmony");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Harmony\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Harmony/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult BrokenRecord()
        {

            LoadKeysBrokenRecord s1 = LoadKeysBrokenRecord.Instance();
            List<BookModel> items = LoadKeysBrokenRecord.list;

            String Path = Server.MapPath("/Audio/Books/BrokenRecord");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\BrokenRecord\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/BrokenRecord/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult MysticalAdventures()
        {

            LoadKeysMysticalAdventures s1 = LoadKeysMysticalAdventures.Instance();
            List<BookModel> items = LoadKeysMysticalAdventures.list;

            String Path = Server.MapPath("/Audio/Books/MysticalAdventures");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\MysticalAdventures\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/MysticalAdventures/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult Economics()
        {

            LoadKeysEconomics s1 = LoadKeysEconomics.Instance();
            List<BookModel> items = LoadKeysEconomics.list;

            String Path = Server.MapPath("/Audio/Books/Economics");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Economics\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Economics/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult DreamTime()
        {

            LoadKeysDreamTime s1 = LoadKeysDreamTime.Instance();
            List<BookModel> items = LoadKeysDreamTime.list;

            String Path = Server.MapPath("/Audio/Books/DreamTime");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\DreamTime\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/DreamTime/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Rumi()
        {

            LoadKeysRumi s1 = LoadKeysRumi.Instance();
            List<BookModel> items = LoadKeysRumi.list;

            String Path = Server.MapPath("/Audio/Books/Rumi");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Rumi\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Rumi/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Recalibration()
        {

            LoadKeysRecalibration s1 = LoadKeysRecalibration.Instance();
            List<BookModel> items = LoadKeysRecalibration.list;

            String Path = Server.MapPath("/Audio/Books/Recalibration");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Recalibration\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Recalibration/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Chemist()
        {

            LoadKeysChemist s1 = LoadKeysChemist.Instance();
            List<BookModel> items = LoadKeysChemist.list;

            String Path = Server.MapPath("/Audio/Books/Chemist");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Chemist\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Chemist/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult Sound()
        {

            LoadKeysSound s1 = LoadKeysSound.Instance();
            List<BookModel> items = LoadKeysSound.list;

            String Path = Server.MapPath("/Audio/Books/Sound");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Sound\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Sound/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Knowledge()
        {

            LoadKeysKnowledge s1 = LoadKeysKnowledge.Instance();
            List<BookModel> items = LoadKeysKnowledge.list;

            String Path = Server.MapPath("/Audio/Books/Knowledge");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Knowledge\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Knowledge/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }




        public ActionResult Naropa()
        {

            LoadKeysNaropa s1 = LoadKeysNaropa.Instance();
            List<BookModel> items = LoadKeysNaropa.list;

            String Path = Server.MapPath("/Audio/Books/Naropa");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Naropa\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Naropa/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult NaropaCommentary()
        {

            LoadKeysNaropaCommentary s1 = LoadKeysNaropaCommentary.Instance();
            List<BookModel> items = LoadKeysNaropaCommentary.list;

            String Path = Server.MapPath("/Audio/Books/NaropaCommentary");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\NaropaCommentary\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/NaropaCommentary/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult Definition()
        {


            LoadKeysDefinition s1 = LoadKeysDefinition.Instance();
            List<BookModel> items = LoadKeysDefinition.list;

            String Path = Server.MapPath("/Audio/Books/Definition");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Definition\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Definition/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Transformation()
        {


            LoadKeysTransformation s1 = LoadKeysTransformation.Instance();
            List<BookModel> items = LoadKeysTransformation.list;

            String Path = Server.MapPath("/Audio/Books/Transformation");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Transformation\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Transformation/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult TeachingsOfTheDragons()
        {


            LoadKeysTeachingsOfTheDragons s1 = LoadKeysTeachingsOfTheDragons.Instance();
            List<BookModel> items = LoadKeysTeachingsOfTheDragons.list;

            String Path = Server.MapPath("/Audio/Books/TeachingsOfTheDragons");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\TeachingsOfTheDragons\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/TeachingsOfTheDragons/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult DragonsNaropa()
        {


            LoadKeysDragonsNaropa s1 = LoadKeysDragonsNaropa.Instance();
            List<BookModel> items = LoadKeysDragonsNaropa.list;

            String Path = Server.MapPath("/Audio/Books/DragonsNaropa");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\DragonsNaropa\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/DragonsNaropa/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Alchemy()
        {


            LoadKeysAlchemy s1 = LoadKeysAlchemy.Instance();
            List<BookModel> items = LoadKeysAlchemy.list;

            String Path = Server.MapPath("/Audio/Books/Alchemy");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Alchemy\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Alchemy/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult DragonsNaropa2()
        {


            LoadKeysDragonsNaropa2 s1 = LoadKeysDragonsNaropa2.Instance();
            List<BookModel> items = LoadKeysDragonsNaropa2.list;

            String Path = Server.MapPath("/Audio/Books/DragonsNaropa2");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\DragonsNaropa2\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/DragonsNaropa2/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Training()
        {


            LoadKeysTraining s1 = LoadKeysTraining.Instance();
            List<BookModel> items = LoadKeysTraining.list;

            String Path = Server.MapPath("/Audio/Books/Training");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Training\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Training/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }


        public ActionResult EsotericTreasures()
        {


            LoadKeysEsotericTreasures s1 = LoadKeysEsotericTreasures.Instance();
            List<BookModel> items = LoadKeysEsotericTreasures.list;

            String Path = Server.MapPath("/Audio/Books/EsotericTreasures");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\EsotericTreasures\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/EsotericTreasures/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult Puzzle()
        {


            LoadKeysPuzzle s1 = LoadKeysPuzzle.Instance();
            List<BookModel> items = LoadKeysPuzzle.list;

            String Path = Server.MapPath("/Audio/Books/Puzzle");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Puzzle\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Puzzle/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult MysticalHistorian()
        {


            LoadKeysMysticalHistorian s1 = LoadKeysMysticalHistorian.Instance();
            List<BookModel> items = LoadKeysMysticalHistorian.list;

            String Path = Server.MapPath("/Audio/Books/MysticalHistorian");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\MysticalHistorian\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/MysticalHistorian/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        public ActionResult War()
        {


            LoadKeysWar s1 = LoadKeysWar.Instance();
            List<BookModel> items = LoadKeysWar.list;

            String Path = Server.MapPath("/Audio/Books/War");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\War\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/War/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();

        }

        //Please Select one
        public ActionResult InnerHarmony(string chapter)
        {


            string[] AgeRagne = new string[] { "Please Select one", "Books before 2023", "Books written 2023", "Books written 2024" };


            List<SelectListItem> itemsAge = new List<SelectListItem>();
            for (int i = 0; i < AgeRagne.Length; i++)
            {


                itemsAge.Add(new SelectListItem { Text = AgeRagne[i], Value = AgeRagne[i] });
            }

            foreach (SelectListItem s in itemsAge)
            {
                if (s.Value == chapter)
                {
                    s.Selected = true;
                }
            }



            ViewData["ethnicData"] = itemsAge;

            string chap = chapter;
            //LoadKeysInnerHarmony s1 = LoadKeysInnerHarmony.Instance(chapter);
            LoadKeysInnerHarmony s1 = new LoadKeysInnerHarmony(chapter);
            //s1.chapter = chapter;
            List<BookModel> items = LoadKeysInnerHarmony.list;

            String Path = Server.MapPath("/Audio/Books/InnerHarmony");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\InnerHarmony\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/InnerHarmony/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            //return View();
            return PartialView("InnerHarmony");

        }

        public ActionResult What()
        {


            LoadKeysWhat s1 = LoadKeysWhat.Instance();
            List<BookModel> items = LoadKeysWhat.list;

            String Path = Server.MapPath("/Audio/Books/What");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\What\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/What/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Once()
        {


            LoadKeysOnce s1 = LoadKeysOnce.Instance();
            List<BookModel> items = LoadKeysOnce.list;

            String Path = Server.MapPath("/Audio/Books/Once");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Once\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Once/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult FamilyCooking()
        {


            LoadKeysFamilyCooking s1 = LoadKeysFamilyCooking.Instance();
            List<BookModel> items = LoadKeysFamilyCooking.list;

            String Path = Server.MapPath("/Audio/Books/FamilyCooking");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\FamilyCooking\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/FamilyCooking/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult FamilyTravels()
        {


            LoadKeysFamilyTravels s1 = LoadKeysFamilyTravels.Instance();
            List<BookModel> items = LoadKeysFamilyTravels.list;

            String Path = Server.MapPath("/Audio/Books/FamilyTravels");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\FamilyTravels\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/FamilyTravels/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult LifeOfKai()
        {


            LoadKeysLifeOfKai s1 = LoadKeysLifeOfKai.Instance();
            List<BookModel> items = LoadKeysLifeOfKai.list;

            String Path = Server.MapPath("/Audio/Books/LifeOfKai");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\LifeOfKai\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/LifeOfKai/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Breathe()
        {


            LoadKeysBreathe s1 = LoadKeysBreathe.Instance();
            List<BookModel> items = LoadKeysBreathe.list;

            String Path = Server.MapPath("/Audio/Books/Breathe");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Breathe\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Breathe/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Monroe()
        {


            LoadKeysMonroe s1 = LoadKeysMonroe.Instance();
            List<BookModel> items = LoadKeysMonroe.list;

            String Path = Server.MapPath("/Audio/Books/Monroe");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Monroe\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Monroe/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult Music()
        {


            LoadKeysMusic s1 = LoadKeysMusic.Instance();
            List<BookModel> items = LoadKeysMusic.list;

            String Path = Server.MapPath("/Audio/Books/Music");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Music\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Music/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Gita()
        {


            LoadKeysGita s1 = LoadKeysGita.Instance();
            List<BookModel> items = LoadKeysGita.list;

            String Path = Server.MapPath("/Audio/Books/Gita");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Gita\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Gita/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult WestCoast()
        {


            LoadKeysWestCoast s1 = LoadKeysWestCoast.Instance();
            List<BookModel> items = LoadKeysWestCoast.list;

            String Path = Server.MapPath("/Audio/Books/WestCoast");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\WestCoast\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/WestCoast/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Draconis()
        {


            LoadKeysDraconis s1 = LoadKeysDraconis.Instance();
            List<BookModel> items = LoadKeysDraconis.list;

            String Path = Server.MapPath("/Audio/Books/Draconis");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Draconis\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Draconis/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }



        public ActionResult Temper()
        {


            LoadKeysTemper s1 = LoadKeysTemper.Instance();
            List<BookModel> items = LoadKeysTemper.list;

            String Path = Server.MapPath("/Audio/Books/Temper");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Temper\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Temper/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult land()
        {


            LoadKeysland s1 = LoadKeysland.Instance();
            List<BookModel> items = LoadKeysland.list;

            String Path = Server.MapPath("/Audio/Books/land");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\land\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/land/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult CentralSun()
        {


            LoadKeysCentralSun s1 = LoadKeysCentralSun.Instance();
            List<BookModel> items = LoadKeysCentralSun.list;

            String Path = Server.MapPath("/Audio/Books/CentralSun");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\CentralSun\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/CentralSun/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Occam()
        {


            LoadKeysOccam s1 = LoadKeysOccam.Instance();
            List<BookModel> items = LoadKeysOccam.list;

            String Path = Server.MapPath("/Audio/Books/Occam");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Occam\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Occam/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Paryushan2022()
        {


            LoadKeysParyushan2022 s1 = LoadKeysParyushan2022.Instance();
            List<BookModel> items = LoadKeysParyushan2022.list;

            String Path = Server.MapPath("/Audio/Books/Paryushan2022");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Paryushan2022\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Paryushan2022/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Zoran()
        {


            LoadKeysZoran s1 = LoadKeysZoran.Instance();
            List<BookModel> items = LoadKeysZoran.list;

            String Path = Server.MapPath("/Audio/Books/Zoran");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Zoran\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Zoran/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Spinoza()
        {


            LoadKeysSpinoza s1 = LoadKeysSpinoza.Instance();
            List<BookModel> items = LoadKeysSpinoza.list;

            String Path = Server.MapPath("/Audio/Books/Spinoza");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Spinoza\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Spinoza/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Paradoxes()
        {


            LoadKeysParadoxes s1 = LoadKeysParadoxes.Instance();
            List<BookModel> items = LoadKeysParadoxes.list;

            String Path = Server.MapPath("/Audio/Books/Paradoxes");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Paradoxes\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Paradoxes/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Innovators()
        {


            LoadKeysInnovators s1 = LoadKeysInnovators.Instance();
            List<BookModel> items = LoadKeysInnovators.list;

            String Path = Server.MapPath("/Audio/Books/Innovators");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Innovators\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Innovators/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult Sleep()
        {


            LoadKeysSleep s1 = LoadKeysSleep.Instance();
            List<BookModel> items = LoadKeysSleep.list;

            String Path = Server.MapPath("/Audio/Books/Sleep");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Sleep\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Sleep/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Gather()
        {


            LoadKeysGather s1 = LoadKeysGather.Instance();
            List<BookModel> items = LoadKeysGather.list;

            String Path = Server.MapPath("/Audio/Books/Gather");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Gather\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Gather/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
public ActionResult Hacks()
        {


            LoadKeysHacks s1 = LoadKeysHacks.Instance();
            List<BookModel> items = LoadKeysHacks.list;

            String Path = Server.MapPath("/Audio/Books/Hacks");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Hacks\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Hacks/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }



        public ActionResult Beyond()
        {


            LoadKeysBeyond s1 = LoadKeysBeyond.Instance();
            List<BookModel> items = LoadKeysBeyond.list;

            String Path = Server.MapPath("/Audio/Books/Beyond");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Beyond\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Beyond/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Chakrasamvara()
        {


            LoadKeysChakrasamvara s1 = LoadKeysChakrasamvara.Instance();
            List<BookModel> items = LoadKeysChakrasamvara.list;

            String Path = Server.MapPath("/Audio/Books/Chakrasamvara");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Chakrasamvara\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Chakrasamvara/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }



        public ActionResult QuantumComputing()
        {


            LoadKeysQuantumComputing s1 = LoadKeysQuantumComputing.Instance();
            List<BookModel> items = LoadKeysQuantumComputing.list;

            String Path = Server.MapPath("/Audio/Books/QuantumComputing");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\QuantumComputing\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/QuantumComputing/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Mirror()
        {


            LoadKeysMirror s1 = LoadKeysMirror.Instance();
            List<BookModel> items = LoadKeysMirror.list;

            String Path = Server.MapPath("/Audio/Books/Mirror");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Mirror\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Mirror/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Mirror2()
        {


            LoadKeysMirror2 s1 = LoadKeysMirror2.Instance();
            List<BookModel> items = LoadKeysMirror2.list;

            String Path = Server.MapPath("/Audio/Books/Mirror2");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Mirror2\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Mirror2/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult MadisonAvenue()
        {


            LoadKeysMadisonAvenue s1 = LoadKeysMadisonAvenue.Instance();
            List<BookModel> items = LoadKeysMadisonAvenue.list;

            String Path = Server.MapPath("/Audio/Books/MadisonAvenue");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\MadisonAvenue\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/MadisonAvenue/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult LightSpectrum()
        {


            LoadKeysLightSpectrum s1 = LoadKeysLightSpectrum.Instance();
            List<BookModel> items = LoadKeysLightSpectrum.list;

            String Path = Server.MapPath("/Audio/Books/LightSpectrum");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\LightSpectrum\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/LightSpectrum/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult JewelerAndTheTheif()
        {


            LoadKeysJewelerAndTheTheif s1 = LoadKeysJewelerAndTheTheif.Instance();
            List<BookModel> items = LoadKeysJewelerAndTheTheif.list;

            String Path = Server.MapPath("/Audio/Books/JewelerAndTheTheif");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\JewelerAndTheTheif\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/JewelerAndTheTheif/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult CommonSenseIsUncommon()
        {


            LoadKeysCommonSenseIsUncommon s1 = LoadKeysCommonSenseIsUncommon.Instance();
            List<BookModel> items = LoadKeysCommonSenseIsUncommon.list;

            String Path = Server.MapPath("/Audio/Books/CommonSenseIsUncommon");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\CommonSenseIsUncommon\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/CommonSenseIsUncommon/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        //Please Select one
        public ActionResult Sublime(string chapter)
        {


            string[] AgeRagne = new string[] { "Please Select one", "Sublime", "Sublime Kabir and the Sublime", "Hafiz A Master of Persian Poetry and Mysticism", "Sublime Rumi", "Sublime Poets, Mystics and Teachers", "Sublime Elixers that Exist inside of you" };


            List<SelectListItem> itemsAge = new List<SelectListItem>();
            for (int i = 0; i < AgeRagne.Length; i++)
            {


                itemsAge.Add(new SelectListItem { Text = AgeRagne[i], Value = AgeRagne[i] });
            }

            foreach (SelectListItem s in itemsAge)
            {
                if (s.Value == chapter)
                {
                    s.Selected = true;
                }
            }



            ViewData["ethnicData"] = itemsAge;

            string chap = chapter;
            //LoadKeysSublime s1 = LoadKeysSublime.Instance(chapter);
            LoadKeysSublime s1 = new LoadKeysSublime(chapter);
            //s1.chapter = chapter;
            List<BookModel> items = LoadKeysSublime.list;

            String Path = Server.MapPath("/Audio/Books/Sublime");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Sublime\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Sublime/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            //return View();
            return PartialView("Sublime");

        }


        public ActionResult SecretOfTheGoldenFlower()
        {


            LoadKeysSecretOfTheGoldenFlower s1 = LoadKeysSecretOfTheGoldenFlower.Instance();
            List<BookModel> items = LoadKeysSecretOfTheGoldenFlower.list;

            String Path = Server.MapPath("/Audio/Books/SecretOfTheGoldenFlower");
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
 
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\SecretOfTheGoldenFlower\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/SecretOfTheGoldenFlower/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult Longevity()
        {


            LoadKeysLongevity s1 = LoadKeysLongevity.Instance();
            List<BookModel> items = LoadKeysLongevity.list;

            String Path = Server.MapPath("/Audio/Books/Longevity");
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

                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Longevity\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Longevity/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult DragonsQuantum()
        {


            LoadKeysDragonsQuantum s1 = LoadKeysDragonsQuantum.Instance();
            List<BookModel> items = LoadKeysDragonsQuantum.list;

            String Path = Server.MapPath("/Audio/Books/DragonsQuantum");
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

                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\DragonsQuantum\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/DragonsQuantum/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            InsertRecords myInsertRecords = new InsertRecords();
            myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult DragonsShaolin()
        {


            LoadKeysDragonsShaolin s1 = LoadKeysDragonsShaolin.Instance();
            List<BookModel> items = LoadKeysDragonsShaolin.list;

            String Path = Server.MapPath("/Audio/Books/DragonsShaolin");
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

                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\DragonsShaolin\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/DragonsShaolin/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult InnerAlchemy()
        {


            LoadKeysInnerAlchemy s1 = LoadKeysInnerAlchemy.Instance();
            List<BookModel> items = LoadKeysInnerAlchemy.list;

            String Path = Server.MapPath("/Audio/Books/InnerAlchemy");
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

                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\InnerAlchemy\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/InnerAlchemy/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult VagusNerve()
        {


            LoadKeysVagusNerve s1 = LoadKeysVagusNerve.Instance();
            List<BookModel> items = LoadKeysVagusNerve.list;

            String Path = Server.MapPath("/Audio/Books/VagusNerve");
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

                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\VagusNerve\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/VagusNerve/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult SocialSecurity()
        {


            LoadKeysSocialSecurity s1 = LoadKeysSocialSecurity.Instance();
            List<BookModel> items = LoadKeysSocialSecurity.list;

            String Path = Server.MapPath("/Audio/Books/SocialSecurity");
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

                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\SocialSecurity\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/SocialSecurity/" + fullname));
                        //InsertRecords myInsertRecords = new InsertRecords();
                        //myInsertRecords.loadData(list);

                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult Dental()
        {


            LoadKeysDental s1 = LoadKeysDental.Instance();
            List<BookModel> items = LoadKeysDental.list;

            String Path = Server.MapPath("/Audio/Books/Dental");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Dental\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Dental/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult Anatomy()
        {


            LoadKeysAnatomy s1 = LoadKeysAnatomy.Instance();
            List<BookModel> items = LoadKeysAnatomy.list;

            String Path = Server.MapPath("/Audio/Books/Anatomy");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Anatomy\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Anatomy/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult SkyGazing()
        {


            LoadKeysSkyGazing s1 = LoadKeysSkyGazing.Instance();
            List<BookModel> items = LoadKeysSkyGazing.list;

            String Path = Server.MapPath("/Audio/Books/SkyGazing");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\SkyGazing\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/SkyGazing/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }

        public ActionResult Mudras()
        {


            LoadKeysMudras s1 = LoadKeysMudras.Instance();
            List<BookModel> items = LoadKeysMudras.list;

            String Path = Server.MapPath("/Audio/Books/Mudras");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\Mudras\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/Mudras/" + fullname));
                        break;
                    }
                }
            }

            //InsertRecords myInsertRecords = new InsertRecords();
            //myInsertRecords.loadData(list);


            ViewData["orderData"] = list;

            return View();
        }
        public ActionResult LittleDropsOfMercy()
        {


            LoadKeysLittleDropsOfMercy s1 = LoadKeysLittleDropsOfMercy.Instance();
            List<BookModel> items = LoadKeysLittleDropsOfMercy.list;

            String Path = Server.MapPath("/Audio/Books/LittleDropsOfMercy");
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
                        list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Books\\LittleDropsOfMercy\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Books/LittleDropsOfMercy/" + fullname));
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