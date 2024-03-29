﻿using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSkyGazing
    {
        private static LoadKeysSkyGazing _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSkyGazing()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


        }

        public static LoadKeysSkyGazing Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSkyGazing();
            }

            return _instance;
        }
    }
}