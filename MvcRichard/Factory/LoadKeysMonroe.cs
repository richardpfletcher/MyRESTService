using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMonroe
    {
        private static LoadKeysMonroe _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMonroe()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            //list.Add(new BookModel(counter++, "MONROE INSTITUTE"));
            //list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            //list.Add(new BookModel(counter++, "Monroe Experience Part 2"));



            //list.Add(new BookModel(counter++, "Monroe Adventure")); // where is this


            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1 side a"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2 side a"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3 side a"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 4"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 5"));
            list.Add(new BookModel(counter++, "35 years later"));







        }

        public static LoadKeysMonroe Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMonroe();
            }

            return _instance;
        }
    }
}