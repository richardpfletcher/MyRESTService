using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysBreathe
    {
        private static LoadKeysBreathe _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysBreathe()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            


        }

        public static LoadKeysBreathe Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysBreathe();
            }

            return _instance;
        }
    }
}