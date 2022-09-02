using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMusic
    {
        private static LoadKeysMusic _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMusic()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

           
        }

        public static LoadKeysMusic Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMusic();
            }

            return _instance;
        }
    }
}