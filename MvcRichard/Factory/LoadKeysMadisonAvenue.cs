using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMadisonAvenue
    {
        private static LoadKeysMadisonAvenue _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMadisonAvenue()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
           


        }

        public static LoadKeysMadisonAvenue Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMadisonAvenue();
            }

            return _instance;
        }
    }
}