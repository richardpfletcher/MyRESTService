using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysGita
    {
        private static LoadKeysGita _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysGita()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            


        }

        public static LoadKeysGita Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysGita();
            }

            return _instance;
        }
    }
}