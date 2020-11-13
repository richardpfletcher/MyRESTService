using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSuperBowl
    {
        private static LoadKeysSuperBowl _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSuperBowl()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Fans"));
            list.Add(new BookModel(counter++, "Archetype Symbols"));
            list.Add(new BookModel(counter++, "Quantum Field"));
            list.Add(new BookModel(counter++, "Patterns"));
            list.Add(new BookModel(counter++, "Conscious Chessboard"));
            list.Add(new BookModel(counter++, "Unlimited Possibilities"));
            list.Add(new BookModel(counter++, "Football Aikido"));
            list.Add(new BookModel(counter++, "Going Vegan"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Anger And Brain Waves"));
            list.Add(new BookModel(counter++, "Sleep"));
            list.Add(new BookModel(counter++, "Cold Water Therapy"));
            list.Add(new BookModel(counter++, "Injuries"));
            list.Add(new BookModel(counter++, "Hatha Yoga"));
            list.Add(new BookModel(counter++, "Chi Gong"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Monitoring Your Thoughts And Emotions"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "Closing"));
            


        }

        public static LoadKeysSuperBowl Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSuperBowl();
            }

            return _instance;
        }
    }
}