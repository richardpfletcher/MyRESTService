using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class ChannelController : Controller
    {
        //
        // GET: /Channel/

        public ActionResult Index()
        {

            String Path = Server.MapPath("/Audio/Channel/JohnAndRick");
            String[] FileNames = Directory.GetFiles(Path);

            List<DocumentModel> list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Channel\\JohnAndRick\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Channel/JohnAndRick/" + fullname));
            }

            ViewData["JohnAndRickData"] = list;


            //Mafu

            Path = Server.MapPath("/Audio/Channel/Mafu");
            FileNames = Directory.GetFiles(Path);

            list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Channel\\Mafu\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Channel/Mafu/" + fullname));
            }

            ViewData["MafuData"] = list;

            //Monroe
            Path = Server.MapPath("/Audio/Channel/Monroe");
            FileNames = Directory.GetFiles(Path);

            list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Channel\\Monroe\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Channel/Monroe/" + fullname));
            }

            ViewData["MonroeData"] = list;

            //Paul

            Path = Server.MapPath("/Audio/Channel/Paul");
            FileNames = Directory.GetFiles(Path);

            list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Channel\\Paul\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Channel/Paul/" + fullname));
            }

            ViewData["PaulData"] = list;

            //Zoran

            Path = Server.MapPath("/Audio/Channel/Zoran");
            FileNames = Directory.GetFiles(Path);

            list = new List<DocumentModel>();

            foreach (string path in FileNames) //iterate the file list
            {
                string x = path;

                // Find the last occurrence of \.
                int index1 = x.LastIndexOf('\\');
                string fullname = x.Substring(index1 + 1);
                string shortname = fullname.Substring(0, fullname.Length - 4);
                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Channel\\Zoran\\" + fullname, "http://www.evolutionrevolutionoflove.com/Audio/Channel/Zoran/" + fullname));
            }

            ViewData["ZoranData"] = list;



            
            return View();
        }

    }
}
