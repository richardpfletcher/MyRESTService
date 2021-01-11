using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysHarmony
    {
        private static LoadKeysHarmony _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysHarmony()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Harmony"));

            list.Add(new BookModel(counter++, "Depression and PTSD"));
            list.Add(new BookModel(counter++, "Burned Out"));
            list.Add(new BookModel(counter++, "Intuition And Synchronicity"));
            list.Add(new BookModel(counter++, "Harmony Health"));
            list.Add(new BookModel(counter++, "Dialogue Vs Flaming"));
            list.Add(new BookModel(counter++, "The Quantum Field"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Chakras"));
            list.Add(new BookModel(counter++, "A Good Night Sleep"));
            list.Add(new BookModel(counter++, "Silence"));
            list.Add(new BookModel(counter++, "Cultivating The Mind"));
            list.Add(new BookModel(counter++, "Ego Vs Humility"));
            list.Add(new BookModel(counter++, "The Mind Of God"));
            list.Add(new BookModel(counter++, "Think Outside Of The Box"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysHarmony Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysHarmony();
            }

            return _instance;
        }
    }
}