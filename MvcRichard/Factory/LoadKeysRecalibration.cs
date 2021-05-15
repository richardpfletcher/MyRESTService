using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysRecalibration
    {
        private static LoadKeysRecalibration _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysRecalibration()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            

        }

        public static LoadKeysRecalibration Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysRecalibration();
            }

            return _instance;
        }
    }
}