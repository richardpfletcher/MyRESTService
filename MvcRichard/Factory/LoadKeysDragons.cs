using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDragoms
    {
        private static LoadKeysDragoms _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDragoms()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Dragons"));
            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "Planting The Seeds"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Zoran And Friends"));
            list.Add(new BookModel(counter++, "The Frog in The Well"));
            list.Add(new BookModel(counter++, "Flying With Dragons"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Charlie The Dragon"));
            list.Add(new BookModel(counter++, "From Darkness To Light"));
            list.Add(new BookModel(counter++, "The Golden Rule"));
            list.Add(new BookModel(counter++, "The Christ"));
            list.Add(new BookModel(counter++, "Let’s Have Fun"));
            list.Add(new BookModel(counter++, "Politics"));
            list.Add(new BookModel(counter++, "Lao-Tzu"));
            list.Add(new BookModel(counter++, "Good Night"));

            

        }

        public static LoadKeysDragoms Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDragoms();
            }

            return _instance;
        }
    }
}