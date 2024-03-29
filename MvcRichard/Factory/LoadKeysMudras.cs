﻿using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMudras
    {
        private static LoadKeysMudras _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMudras()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            


        }

        public static LoadKeysMudras Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMudras();
            }

            return _instance;
        }
    }
}