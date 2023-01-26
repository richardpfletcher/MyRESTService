using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysCentralSun
    {
        private static LoadKeysCentralSun _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysCentralSun()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Sine waves"));
            list.Add(new BookModel(counter++, "Meditate constantly"));
            list.Add(new BookModel(counter++, "How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "God is a cosmic surfer"));
            list.Add(new BookModel(counter++, "Sri Yukteswar Intro Holy Science"));
            list.Add(new BookModel(counter++, "Sri Yukteswar Reasoning Behind The Cycles of Time"));
            list.Add(new BookModel(counter++, "The Yuga Cycles & Yogic "));
            list.Add(new BookModel(counter++, "The Science of Sirius Mythology"));
            list.Add(new BookModel(counter++, "Binary Stars"));
            list.Add(new BookModel(counter++, "The Great Central Sun"));
            list.Add(new BookModel(counter++, "The central sun"));
            list.Add(new BookModel(counter++, "Darkness Before Dawn"));
            list.Add(new BookModel(counter++, "Think Outside Of The Box"));
            list.Add(new BookModel(counter++, "Take off your mask"));
            list.Add(new BookModel(counter++, "We See Only 1 % Of The Light Spectrum"));
            list.Add(new BookModel(counter++, "Closing"));

        }

        public static LoadKeysCentralSun Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysCentralSun();
            }

            return _instance;
        }
    }
}