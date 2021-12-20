using System;
using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDragonsNaropa2
    {
        private static LoadKeysDragonsNaropa2 _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDragonsNaropa2()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            



        }

        public static LoadKeysDragonsNaropa2 Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDragonsNaropa2();
            }

            return _instance;
        }
    }
}