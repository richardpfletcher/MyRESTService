using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSwan
    {
        private static LoadKeysSwan _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSwan()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "The Fight of Two Wolves Within You"));
            list.Add(new BookModel(counter++, "Learning How To Ride A Bicycle"));
            list.Add(new BookModel(counter++, "Follow The Recipe"));
            list.Add(new BookModel(counter++, "The Frog in The Well"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "The Mirror"));
            list.Add(new BookModel(counter++, "Chapter9)"));
            list.Add(new BookModel(counter++, "The Ugly Duckling"));
            list.Add(new BookModel(counter++, "The Sun And The Wind"));
            list.Add(new BookModel(counter++, "The Sun And Darkness"));
            list.Add(new BookModel(counter++, "Chapter13"));
            list.Add(new BookModel(counter++, "Chapter14"));
            list.Add(new BookModel(counter++, "Chapter15"));



        }

        public static LoadKeysSwan Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSwan();
            }

            return _instance;
        }
    }
}