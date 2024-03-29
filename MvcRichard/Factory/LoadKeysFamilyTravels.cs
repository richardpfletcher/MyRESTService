﻿using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysFamilyTravels
    {
        private static LoadKeysFamilyTravels _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysFamilyTravels()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            


        }

        public static LoadKeysFamilyTravels Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysFamilyTravels();
            }

            return _instance;
        }
    }
}