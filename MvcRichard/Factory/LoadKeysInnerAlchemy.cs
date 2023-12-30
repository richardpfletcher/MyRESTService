using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysInnerAlchemy
    {
        private static LoadKeysInnerAlchemy _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysInnerAlchemy()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

          



        }

        public static LoadKeysInnerAlchemy Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysInnerAlchemy();
            }

            return _instance;
        }
    }
}