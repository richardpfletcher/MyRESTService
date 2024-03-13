using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysLittleDropsOfMercy
    {
        private static LoadKeysLittleDropsOfMercy _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysLittleDropsOfMercy()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            


        }

        public static LoadKeysLittleDropsOfMercy Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysLittleDropsOfMercy();
            }

            return _instance;
        }
    }
}