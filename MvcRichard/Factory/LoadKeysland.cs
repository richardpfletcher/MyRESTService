using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysland
    {
        private static LoadKeysland _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysland()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



        }

        public static LoadKeysland Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysland();
            }

            return _instance;
        }
    }
}