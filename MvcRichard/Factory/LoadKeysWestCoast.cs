using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysWestCoast
    {
        private static LoadKeysWestCoast _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysWestCoast()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



        }

        public static LoadKeysWestCoast Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysWestCoast();
            }

            return _instance;
        }
    }
}