using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysAnatomy
    {
        private static LoadKeysAnatomy _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysAnatomy()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


        }

        public static LoadKeysAnatomy Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysAnatomy();
            }

            return _instance;
        }
    }
}