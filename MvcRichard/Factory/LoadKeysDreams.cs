using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDreams
    {
        private static LoadKeysDreams _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDreams()
        {
            int counter = 0;
            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "What Is A Dream"));
            list.Add(new BookModel(counter++, "What Is Real"));
            list.Add(new BookModel(counter++, "What Is The Difference Between A Dream And An Outside Event"));
            list.Add(new BookModel(counter++, "9 to 5 Existence"));
            list.Add(new BookModel(counter++, "You Are A Genie"));
            list.Add(new BookModel(counter++, "You Are Living On Remote Control"));
            list.Add(new BookModel(counter++, "Dreams Do Come True"));
            list.Add(new BookModel(counter++, "From Thought To Energy To Matter"));
            list.Add(new BookModel(counter++, "Tapping"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "Meditating Upon Your Dreams"));
            list.Add(new BookModel(counter++, "Closing"));
           


        }

        public static LoadKeysDreams Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDreams();
            }

            return _instance;
        }
    }
}