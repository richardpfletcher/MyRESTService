using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRichard.Factory;
using MvcRichard.Models;

namespace MvcRichard.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        private void LogEntry(string text)
        {
            //var folder = @"C:\Users\Richard\Google Drive\projects\SlideShow\WebApplication2\App_Data";
            var folder = @"C:\Users\Richard\Google Drive\WebSites\EvolutionDeploy\App_Data";
            var logfilename = $@"{folder}\logs.txt";
            if (System.IO.Directory.Exists(folder))
                System.IO.File.AppendAllText(logfilename, $"{DateTime.Now}\t{text}\r\n");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTitle(int id)
        {
            LogEntry("GetTitle"+id);
            return View();
        }

        


        public ActionResult SlideFinal(FormCollection form)
        {
            string Category = base.Request.Form["Category"];
            //string contentAll = base.Request.Form["contentAll"];
            string Theme = base.Request.Form["Theme"];


            string mode = "save";
            Session["Mode"] = mode;

            //string modeContent = contentAll;
            //Session["contentAll"] = modeContent;

            string modeCategory = Category;
            Session["modeCategory"] = modeCategory;

            string modeTheme = Theme;
            if(modeTheme=="")
            {
                modeTheme = "0";
            }
            Session["modeTheme"] = modeTheme;

            LogEntry("slideFinal");
            LogEntry("modeCategory"+ modeCategory);
            


            return RedirectToAction("Slideshow", "Search");


        }

        public ActionResult Slideshow()
        {

            var Mode = "";


            try
            {
                Mode = Session["Mode"] as string;

                string mode = "";
                Session["Mode"] = mode;

            }
            catch (Exception ex)
            {
                Mode = "";
            }



            try
            {

           
            DropdownModel model = new DropdownModel();
            GetLookups myGetLookups1 = new GetLookups();

            model = myGetLookups1.GetCategory();
            ViewData["CategoryData"] = model.items;



            //response myresoonse = new response();

            //GetPartOfAlbum myGetPartOfAlbum = new GetPartOfAlbum();
            //myresoonse = myGetPartOfAlbum.GetAll(1);


            response items1 = new response();

            GetPartOfAlbum myGetLookups = new GetPartOfAlbum();

            if(Mode == "")
            {
               items1 = myGetLookups.GetAll(1,0);

                    for (int i = 0; i < model.items.Count(); i++)
                    {

                        //modelDish.items[i].Value

                        if (model.items[i].Value == "1")
                        {
                            model.items[i].Selected = true;
                        }

                    }

                    ViewData["Title"] = 0;
                }
            else
            {
                    string contentAll = Session["modeCategory"] as string;
                    int iContent = Convert.ToInt16(contentAll);
                    string themeAll = Session["modeTheme"] as string;
                    int iTheme = Convert.ToInt16(themeAll);

                    items1 = myGetLookups.GetAll(iContent, iTheme);
                    LogEntry("Slideshow modeCategory" + iContent);

                    for (int i = 0; i < model.items.Count(); i++)
                    {

                        //modelDish.items[i].Value

                        if (model.items[i].Value == contentAll)
                        {
                            model.items[i].Selected = true;
                        }

                    }


                }




            CategoryListall MyFavoritesModel = new CategoryListall();

            //var x = items1.data[0];
            MyFavoritesModel = items1.data[0] as CategoryListall;

            List<CategoryListall> myList = new List<CategoryListall>();
            CategoryListall list = new CategoryListall();

                LogEntry("We found "+ MyFavoritesModel.categoryListsall.Count);//replace with something like Serilog

                for (int i = 0; i < MyFavoritesModel.categoryListsall.Count; i++)
            {
                categoryall myanimalType = new categoryall();
                myanimalType.RECEIPTNO = MyFavoritesModel.categoryListsall[i].RECEIPTNO;
                myanimalType.Title = MyFavoritesModel.categoryListsall[i].Title;
                myanimalType.Comments = MyFavoritesModel.categoryListsall[i].Comments;
                myanimalType.Picture = MyFavoritesModel.categoryListsall[i].Picture;
                myanimalType.url = MyFavoritesModel.categoryListsall[i].url;
                list.categoryListsall.Add(myanimalType);
            }

                ViewData["MyFavortiesData"] = list;
                LogEntry("calling view");

            }
            catch (Exception ex)
            {
                LogEntry(ex.ToString());//replace with something like Serilog
                throw;
            }

            DropdownModel modelContent = new DropdownModel();

            //modelDay.items.Add(new SelectListItem { Text = "Please Select", Value = "0" });

            string[] content = { "PDF", "Audio"};


            for (int i = 0; i < content.Length; i++)
            {

                modelContent.items.Add(new SelectListItem { Text = content[i], Value = content[i] });
            }

            ViewData["contentAll"] = modelContent.items;

            GetLookups myGetTheme = new GetLookups();
            DropdownModel modelTheme = new DropdownModel();
            modelTheme = myGetTheme.GetTheme();

            string modeTheme = "";

            try
            {
                modeTheme =Session["modeTheme"] as string;

               
            }
            catch (Exception ex)
            {
                modeTheme = "";
            }

            for (int i = 0; i < modelTheme.items.Count(); i++)
            {

                //modelDish.items[i].Value

                if (modelTheme.items[i].Value == modeTheme)
                {
                    modelTheme.items[i].Selected = true;
                }

            }

            ViewData["themeData"] = modelTheme.items;

            return View();
        }

    }
}
