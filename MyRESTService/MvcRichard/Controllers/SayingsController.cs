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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings2\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings3\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings4\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings5\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings6\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings7\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings8\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings9\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings10\\" + fullname));
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

                list.Add(new DocumentModel(fullname, shortname, "\\Audio\\Sayings\\Sayings11\\" + fullname));
            }

            ViewData["orderData"] = list;

            return View();
        }
    }
}