using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysBrokenRecord
    {
        private static LoadKeysBrokenRecord _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysBrokenRecord()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Harmony"));
            list.Add(new BookModel(counter++, "Carl Yung-Quotes 1"));
            list.Add(new BookModel(counter++, "Carl Yung-Quotes 2"));
           
            list.Add(new BookModel(counter++, "Depression and PTSD"));
            list.Add(new BookModel(counter++, "Intuition And Synchronicity"));
            list.Add(new BookModel(counter++, "Cloudy Health"));
            list.Add(new BookModel(counter++, "Dialogue Vs Flaming"));
            list.Add(new BookModel(counter++, "The Quantum Field"));
            list.Add(new BookModel(counter++, "Chakras)"));
            list.Add(new BookModel(counter++, "A Good Night Sleep"));
            list.Add(new BookModel(counter++, "Silence"));
            list.Add(new BookModel(counter++, "Cultivating The Mind"));
            list.Add(new BookModel(counter++, "Ego Vs Humility"));
            list.Add(new BookModel(counter++, "The Mind Of God"));
            list.Add(new BookModel(counter++, "Think Outside Of The Box"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "What Is Panpsychism 3/16/2018"));
            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));
            list.Add(new BookModel(counter++, "Signposts Are All  Around"));
            list.Add(new BookModel(counter++, "Fellow Wizards Advice"));
            list.Add(new BookModel(counter++, "Wizards Handbook"));
            list.Add(new BookModel(counter++, "Closing"));
            




        }

        public static LoadKeysBrokenRecord Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysBrokenRecord();
            }

            return _instance;
        }
    }
}