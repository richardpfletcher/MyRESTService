using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMeditation
    {
        private static LoadKeysMeditation _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMeditation()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Meditation Talk 2-1-2017"));


           
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Meditation Talk 2-13-2017 "));
            
            list.Add(new BookModel(counter++, "The Word"));
            list.Add(new BookModel(counter++, "Meditation Talk 2-14-2017"));

            list.Add(new BookModel(counter++, "The World Is a Drama"));
            list.Add(new BookModel(counter++, "Meditation Talk 2-15-2017 Anima"));
            list.Add(new BookModel(counter++, "Spiritual Life Is Not Boring 2-4-2017"));
            list.Add(new BookModel(counter++, "Meditation Talk 2-5-2017"));
            list.Add(new BookModel(counter++, "Meditation Talk 3-22-2017"));
            list.Add(new BookModel(counter++, "Defination Of A Mystic 4-8-2017"));
            list.Add(new BookModel(counter++, "What Is Panpsychism 3-16-2018"));
            list.Add(new BookModel(counter++, "Bruce Lipton"));
            list.Add(new BookModel(counter++, "DNA"));
            list.Add(new BookModel(counter++, "Chakras"));
            list.Add(new BookModel(counter++, "Closing"));
            


        }

        public static LoadKeysMeditation Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMeditation();
            }

            return _instance;
        }
    }
}