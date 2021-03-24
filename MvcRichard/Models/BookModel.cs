using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcRichard.Models
{
    public class BookModel
    {
        public int IDNO;
        public string Chapter;

        public BookModel(int id, string chapter)
        {
            IDNO = id;
            Chapter = chapter;
        }
    }

    public class DropdownModel
    {

        public int ID { get; set; }
        public List<SelectListItem> items = new List<SelectListItem>();

    }
}