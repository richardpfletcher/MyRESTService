using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysCorona
    {
        private static LoadKeysCorona _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysCorona()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Reset Button"));
            list.Add(new BookModel(counter++, "Dear Family"));
            list.Add(new BookModel(counter++, "The Law Of Free Will"));
            list.Add(new BookModel(counter++, "The Law Of Unity"));
            list.Add(new BookModel(counter++, "The Law Of Kindness"));
            list.Add(new BookModel(counter++, "The Law Of Practice"));
            list.Add(new BookModel(counter++, "The Law Of Calibration"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));
            list.Add(new BookModel(counter++, "Cultivating The Mind"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "What Is Panpsychism"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Gratitude"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysCorona Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysCorona();
            }

            return _instance;
        }
    }
}