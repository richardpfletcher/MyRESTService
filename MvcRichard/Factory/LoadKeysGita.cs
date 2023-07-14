using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysGita
    {
        private static LoadKeysGita _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysGita()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Chapter 1 The Sorrow of Arjuna"));
            list.Add(new BookModel(counter++, "Chapter 2 The Yoga of "));
            list.Add(new BookModel(counter++, "Chapter 3 The Yoga of Action"));
            list.Add(new BookModel(counter++, "Chapter 4 The Yoga of Wisdom"));
            list.Add(new BookModel(counter++, "Chapter 5 The Yoga of Renunciation"));
            list.Add(new BookModel(counter++, "Chapter 6 The Yoga of Meditation"));
            list.Add(new BookModel(counter++, "Chapter 7 The Yoga of Wise Understanding"));
            list.Add(new BookModel(counter++, "Chapter 8 The Yoga of Imperishable God"));
            list.Add(new BookModel(counter++, "Chapter 9 The Yoga of Royal Knowledge and Mystery"));
            list.Add(new BookModel(counter++, "Chapter 10 The Yoga of Manifestation"));
            list.Add(new BookModel(counter++, "Chapter 11 Vision of the Universal "));
            list.Add(new BookModel(counter++, "Chapter 12 The Yoga of Devotion"));
            list.Add(new BookModel(counter++, "Chapter 13 Distinguishing the Field and the Knower"));
            list.Add(new BookModel(counter++, "Chapter 14 Distinguishing the Three Qualities"));
            list.Add(new BookModel(counter++, "Chapter 15 The Yoga of the Highest Spirit"));
            list.Add(new BookModel(counter++, "Chapter 16 Distinguishing the Divine and the Demonic"));
            list.Add(new BookModel(counter++, "Chapter 17 Distinguishing Three Kinds of Faith"));
            list.Add(new BookModel(counter++, "Chapter 18 The Yoga of Liberation by Renunciation"));
            list.Add(new BookModel(counter++, "Closing Chapter The Relevance of the Gita Today"));

        }

        public static LoadKeysGita Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysGita();
            }

            return _instance;
        }
    }
}