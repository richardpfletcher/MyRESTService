using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysKnowthySelf
    {
        private static LoadKeysKnowthySelf _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysKnowthySelf()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "The palace in the sky"));
            list.Add(new BookModel(counter++, "Brahmanand-Palace in the sky"));
            list.Add(new BookModel(counter++, "You Can Take A Horse To Water"));
            list.Add(new BookModel(counter++, "Stories-The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "Stories-Planting The Seeds"));

            list.Add(new BookModel(counter++, "Stories-Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Stories-The Frog in The Well"));
            list.Add(new BookModel(counter++, "Stories-Signposts Are All Around"));
            list.Add(new BookModel(counter++, "Stories-Fellow Wizards Advice")); // where is this
            list.Add(new BookModel(counter++, "Stories-Wizards Handbook"));
            list.Add(new BookModel(counter++, "Stories-The Fight of Two Wolves Within You"));
            list.Add(new BookModel(counter++, "Stories-Follow The Recipe"));
            list.Add(new BookModel(counter++, "Stories-3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Stories-The Mirror"));
            list.Add(new BookModel(counter++, "Stories-The Ugly Duckling"));
            list.Add(new BookModel(counter++, "Stories-The Sun And The Wind"));
            list.Add(new BookModel(counter++, "Stories-Initiation"));
            list.Add(new BookModel(counter++, "Stories-Mediation Ganges)"));
            list.Add(new BookModel(counter++, "Stories-Kundalini Snake Experience"));
            list.Add(new BookModel(counter++, "Is This From A Mystic Or A Sceintist"));
            list.Add(new BookModel(counter++, "In The Beginning Was The Word"));
            
            list.Add(new BookModel(counter++, "Can You Experience God While You Are Alive?"));
            list.Add(new BookModel(counter++, "Silence"));
            list.Add(new BookModel(counter++, "The Cosmic Merry Go Round"));
            list.Add(new BookModel(counter++, "The Wheel Of Life"));
            list.Add(new BookModel(counter++, "How Did The Master Become The Master?"));
            list.Add(new BookModel(counter++, "You Are Made Of The Same Stuff As the Universe")); // where is this
            list.Add(new BookModel(counter++, "Kingdom Of Heaven"));
            list.Add(new BookModel(counter++, "The field ripples everywhere"));
            list.Add(new BookModel(counter++, "We See Only one percent Of The Light Spectrum"));


            list.Add(new BookModel(counter++, "Dragon world-The jeweler and the thief"));
            list.Add(new BookModel(counter++, "Dragon world-Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Dragon world-Master Chemists"));
            list.Add(new BookModel(counter++, "Dragon world-The Frog in The Well"));
            list.Add(new BookModel(counter++, "Dragon world insight-Signposts Are All Around"));
            list.Add(new BookModel(counter++, "Dragon world insight-Fellow Wizards Advice"));
            list.Add(new BookModel(counter++, "Dragon world insight-Wizards Handbook"));
            list.Add(new BookModel(counter++, "Dragon world insight-The Fight of Two Wolves Within You"));
            list.Add(new BookModel(counter++, "Dragon world insight-Follow The Recipe"));
            list.Add(new BookModel(counter++, "Dragon world insight-3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Dragon world insight-The Mirror"));
            list.Add(new BookModel(counter++, "Dragon world insight-The Ugly Duckling"));
            list.Add(new BookModel(counter++, "Dragon world insight-The Sun And The Wind"));
            list.Add(new BookModel(counter++, "Dragon world insight-The Sun And Darkness"));
            list.Add(new BookModel(counter++, "Dragon world insight-Initiation"));
            list.Add(new BookModel(counter++, "Closing"));

            

        }

        public static LoadKeysKnowthySelf Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysKnowthySelf();
            }

            return _instance;
        }
    }
}