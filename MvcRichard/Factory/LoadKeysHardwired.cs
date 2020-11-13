using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysHardwired
    {
        private static LoadKeysHardwired _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysHardwired()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "The palace in the sky"));
            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));
            list.Add(new BookModel(counter++, "Chakras"));
            list.Add(new BookModel(counter++, "David The Dragon"));

            list.Add(new BookModel(counter++, "MONROE INSTITUTE"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));



            list.Add(new BookModel(counter++, "Monroe Adventure")); // where is this
            list.Add(new BookModel(counter++, "The World Is a Drama"));
            list.Add(new BookModel(counter++, "What Is Panpsychism 3-16-2018"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Constant Meditation"));
            list.Add(new BookModel(counter++, "Tip Of The Iceberg"));
            list.Add(new BookModel(counter++, "Closing"));






            list.Add(new BookModel(counter++, "The Mirror"));
            list.Add(new BookModel(counter++, "Chapter9)"));
            list.Add(new BookModel(counter++, "The Ugly Duckling"));
            list.Add(new BookModel(counter++, "The Sun And The Wind"));
            list.Add(new BookModel(counter++, "The Sun And Darkness"));
            list.Add(new BookModel(counter++, "Chapter13"));
            list.Add(new BookModel(counter++, "Chapter14"));
            list.Add(new BookModel(counter++, "Chapter15"));



        }

        public static LoadKeysHardwired Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysHardwired();
            }

            return _instance;
        }
    }
}