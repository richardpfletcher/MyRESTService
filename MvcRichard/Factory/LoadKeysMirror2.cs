using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMirror2
    {
        private static LoadKeysMirror2 _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMirror2()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            
list.Add(new BookModel(counter++, "Nonviolence"));
            list.Add(new BookModel(counter++, "Patanjali Yoga Sutras"));
            list.Add(new BookModel(counter++, "Tao Te Ching"));
            list.Add(new BookModel(counter++, "Over the hill Not")); 
            list.Add(new BookModel(counter++, "Cloudy Thinking"));
            list.Add(new BookModel(counter++, "How To Manifest Your Dreams"));
            list.Add(new BookModel(counter++, "How To Use The Quantum Field"));
            list.Add(new BookModel(counter++, "You Are Hardwired To Discover God"));
            list.Add(new BookModel(counter++, "The New Human"));
            list.Add(new BookModel(counter++, "Life & Death"));
            list.Add(new BookModel(counter++, "Happiness"));
            list.Add(new BookModel(counter++, "Kindness"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "The Inner Garden"));
            list.Add(new BookModel(counter++, "Gaia"));
            list.Add(new BookModel(counter++, "Swan Mystical"));
            list.Add(new BookModel(counter++, "The Mystical Journey"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));
            list.Add(new BookModel(counter++, "Mystical Dragons"));
            list.Add(new BookModel(counter++, "Laws Of The Universe"));
            list.Add(new BookModel(counter++, "You Are The Universe"));
            list.Add(new BookModel(counter++, "Your Actions Change The Universe"));
            list.Add(new BookModel(counter++, "It’s A Beautiful Day In The Neighborhood"));
            list.Add(new BookModel(counter++, "Closing"));





        }

        public static LoadKeysMirror2 Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMirror2();
            }

            return _instance;
        }
    }
}