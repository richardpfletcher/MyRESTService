using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysOverTheHill
    {
        private static LoadKeysOverTheHill _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysOverTheHill()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Age Is Timeless"));
            list.Add(new BookModel(counter++, "Age Is Timeless Part 2"));
            list.Add(new BookModel(counter++, "Taking Care Of Your Body"));
            list.Add(new BookModel(counter++, "State Of Mind"));
            list.Add(new BookModel(counter++, "Gathering Wisdom"));
            list.Add(new BookModel(counter++, "Being Grandparents"));
            list.Add(new BookModel(counter++, "Keep Your Smile"));
            list.Add(new BookModel(counter++, "Don’t Take Life So Seriously"));
            list.Add(new BookModel(counter++, "Life Is An Adventure"));
            list.Add(new BookModel(counter++, "Discover The Jewel Within"));
            list.Add(new BookModel(counter++, "This World Needs Kindness"));
            list.Add(new BookModel(counter++, "Now You See It Now You Don’t"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysOverTheHill Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysOverTheHill();
            }

            return _instance;
        }
    }
}