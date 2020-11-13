using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysStarDust
    {
        private static LoadKeysStarDust _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysStarDust()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));
            list.Add(new BookModel(counter++, "Brotherhood Sisterhood of Light"));
            list.Add(new BookModel(counter++, "Signposts Are All  Around"));
            list.Add(new BookModel(counter++, "Fellow Wizards Advice"));
            list.Add(new BookModel(counter++, "Wizards Handbook"));
            list.Add(new BookModel(counter++, "One Million Years From Now"));
            list.Add(new BookModel(counter++, "Ten Million Years From Now"));
            //list.Add(new BookModel(counter++, "Charlie The Dragon"));
            //list.Add(new BookModel(counter++, "From Darkness To Light"));
            //list.Add(new BookModel(counter++, "The Golden Rule"));
            //list.Add(new BookModel(counter++, "The Christ"));
            //list.Add(new BookModel(counter++, "Let’s Have Fun"));
            //list.Add(new BookModel(counter++, "Politics"));
            //list.Add(new BookModel(counter++, "Lao-Tzu"));
            //list.Add(new BookModel(counter++, "Good Night"));



        }

        public static LoadKeysStarDust Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysStarDust();
            }

            return _instance;
        }
    }
}