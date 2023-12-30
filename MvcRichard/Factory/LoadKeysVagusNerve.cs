using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysVagusNerve
    {
        private static LoadKeysVagusNerve _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysVagusNerve()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));





        }

        public static LoadKeysVagusNerve Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysVagusNerve();
            }

            return _instance;
        }
    }
}