using MvcRichard.Factory;
using MvcRichard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcRichard.Controllers
{
    public class DreamsController : Controller
    {
        public ActionResult DreamsMenu()
        {
            return View();
        }

        public ActionResult Dreams()
        {
            
            return View();
        }
    }

}
