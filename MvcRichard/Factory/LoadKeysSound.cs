using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSound
    {
        private static LoadKeysSound _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSound()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            



        }

        public static LoadKeysSound Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSound();
            }

            return _instance;
        }
    }
}