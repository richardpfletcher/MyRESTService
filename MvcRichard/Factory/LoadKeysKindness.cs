﻿using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysKindness
    {
        private static LoadKeysKindness _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysKindness()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Chapter1"));
            list.Add(new BookModel(counter++, "Chapter2"));
            list.Add(new BookModel(counter++, "Chapter3"));
            list.Add(new BookModel(counter++, "Chapter4"));
            list.Add(new BookModel(counter++, "Chapter5"));
            list.Add(new BookModel(counter++, "Chapter6"));
            list.Add(new BookModel(counter++, "Chapter7"));
            list.Add(new BookModel(counter++, "Chapter8"));
            list.Add(new BookModel(counter++, "Chapter9)"));
            list.Add(new BookModel(counter++, "Chapter10"));
            list.Add(new BookModel(counter++, "Chapter11"));
            list.Add(new BookModel(counter++, "Chapter12"));
            list.Add(new BookModel(counter++, "Chapter13"));
            list.Add(new BookModel(counter++, "Chapter14"));
            list.Add(new BookModel(counter++, "Chapter15"));
            list.Add(new BookModel(counter++, "New Zealand's PM Jacinda Ardern intro"));



        }

        public static LoadKeysKindness Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysKindness();
            }

            return _instance;
        }
    }
}