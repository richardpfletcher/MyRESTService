using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysOccam
    {
        private static LoadKeysOccam _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysOccam()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Quote 1"));
            list.Add(new BookModel(counter++, "Quote 2"));
            list.Add(new BookModel(counter++, "Quote 3"));
            list.Add(new BookModel(counter++, "Quote 4"));
            


        }

        public static LoadKeysOccam Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysOccam();
            }

            return _instance;
        }
    }
}