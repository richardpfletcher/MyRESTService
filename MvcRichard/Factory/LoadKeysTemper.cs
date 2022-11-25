using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysTemper
    {
        private static LoadKeysTemper _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysTemper()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



        }

        public static LoadKeysTemper Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysTemper();
            }

            return _instance;
        }
    }
}