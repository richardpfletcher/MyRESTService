using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSpinoza
    {
        private static LoadKeysSpinoza _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSpinoza()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Spinoza and the TAO"));
            list.Add(new BookModel(counter++, "The more attention you pay"));
            list.Add(new BookModel(counter++, "Did Einstein Say He Believed in the Pantheistic God of Baruch Spinoza"));
            list.Add(new BookModel(counter++, "Albert Einsteins Answer about God Pantheism Baruch Spinoza"));
            list.Add(new BookModel(counter++, "When Stephen Hawking spoke of the mind of God, was he referring to Spinoza's God"));
            list.Add(new BookModel(counter++, "The dilemma"));
            list.Add(new BookModel(counter++, "An Animated Introduction to Baruch Spinoza"));
            list.Add(new BookModel(counter++, "PHILOSOPHY Baruch Spinoza"));
            list.Add(new BookModel(counter++, "The wizard of light"));
            list.Add(new BookModel(counter++, "Meditation Magazine’s Interview with Neil deGrasse Tyson"));
            list.Add(new BookModel(counter++, "The Connection Between Religion And Science Has Been Revealed dr Michio Kaku"));
            list.Add(new BookModel(counter++, "Michio Kaku The Mind of Einsteins God AI Podcast Clips"));
            list.Add(new BookModel(counter++, "A New Model of Karma Deep Sleep and Death"));
            list.Add(new BookModel(counter++, "Karma Stop bouncing the ball"));
            list.Add(new BookModel(counter++, "The More You Pay Attention To Something"));
            list.Add(new BookModel(counter++, "The door of life"));
            list.Add(new BookModel(counter++, "The field ripples everywhere"));
            list.Add(new BookModel(counter++, "The Sculpture"));
            list.Add(new BookModel(counter++, "A reason to stop worrying"));
            list.Add(new BookModel(counter++, "Who am I"));
            list.Add(new BookModel(counter++, "Time"));
            list.Add(new BookModel(counter++, "The Floor Drops Underneath You"));
            list.Add(new BookModel(counter++, "Maya"));
            list.Add(new BookModel(counter++, "You are the universe"));
            list.Add(new BookModel(counter++, "Closing"));






        }

        public static LoadKeysSpinoza Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSpinoza();
            }

            return _instance;
        }
    }
}