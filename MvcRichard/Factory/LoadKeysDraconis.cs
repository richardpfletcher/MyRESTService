using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDraconis
    {
        private static LoadKeysDraconis _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDraconis()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



        }

        public static LoadKeysDraconis Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDraconis();
            }

            return _instance;
        }
    }
}