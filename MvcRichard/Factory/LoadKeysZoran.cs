using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysZoran
    {
        private static LoadKeysZoran _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysZoran()
        {
            int counter = 0;
            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Problems"));
            list.Add(new BookModel(counter++, "Chapter1"));
            list.Add(new BookModel(counter++, "Chapter2"));
            list.Add(new BookModel(counter++, "Chapter3"));
            list.Add(new BookModel(counter++, "Chapter4"));
            list.Add(new BookModel(counter++, "Chapter5"));
            list.Add(new BookModel(counter++, "chapter6"));
            list.Add(new BookModel(counter++, "Chapter7"));
            list.Add(new BookModel(counter++, "Chapter8"));
            list.Add(new BookModel(counter++, "Chapter9"));
            list.Add(new BookModel(counter++, "Chapter10"));
            list.Add(new BookModel(counter++, "Chapter11"));
            list.Add(new BookModel(counter++, "David Schweizer"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "First Time Meeting Zoran"));
            list.Add(new BookModel(counter++, "Zoran And Friends"));
            list.Add(new BookModel(counter++, "Space Ride -Zoran"));
            list.Add(new BookModel(counter++, "Meeting Barbara"));
            list.Add(new BookModel(counter++, "Naval Special Warfare - Meeting Alien"));
            list.Add(new BookModel(counter++, "Michah"));
            list.Add(new BookModel(counter++, "On Your Own"));
            list.Add(new BookModel(counter++, "Stargate"));
            list.Add(new BookModel(counter++, "Fragments Of Truth"));
            list.Add(new BookModel(counter++, "pleasant - surprise"));
            list.Add(new BookModel(counter++, " 5-2-87 side a"));
            list.Add(new BookModel(counter++, "Zoran 5-2-87 side b"));
            list.Add(new BookModel(counter++, "Zoran Seminars"));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 1 side a"));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 1 side b"));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 2 side b"));
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side a"));
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side b"));
            list.Add(new BookModel(counter++, "We see through many different lenses"));





        }

        public static LoadKeysZoran Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysZoran();
            }

            return _instance;
        }
    }
}
