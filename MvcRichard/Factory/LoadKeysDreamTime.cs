﻿using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDreamTime
    {
        private static LoadKeysDreamTime _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDreamTime()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Message1"));
            list.Add(new BookModel(counter++, "Message2"));
            list.Add(new BookModel(counter++, "Message3"));
            list.Add(new BookModel(counter++, "Message4"));
            list.Add(new BookModel(counter++, "Message5"));
            list.Add(new BookModel(counter++, "Message6"));
            list.Add(new BookModel(counter++, "Message7"));
            list.Add(new BookModel(counter++, "Message8"));
            list.Add(new BookModel(counter++, "Message9)"));
            list.Add(new BookModel(counter++, "Message10"));
            list.Add(new BookModel(counter++, "Message11"));
            list.Add(new BookModel(counter++, "Message12"));
            list.Add(new BookModel(counter++, "Message13"));
            list.Add(new BookModel(counter++, "Message14"));
            list.Add(new BookModel(counter++, "Message15"));



        }

        public static LoadKeysDreamTime Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDreamTime();
            }

            return _instance;
        }
    }
}