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

        public ActionResult HeartOfGold(string chapter)
        {

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

            return View();

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






    }
}