using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysTricks
    {
        private static LoadKeysTricks _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysTricks()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "3-16-2018 Panpsychism"));
            list.Add(new BookModel(counter++, "4-28-2018 chicken"));
            list.Add(new BookModel(counter++, "A man who knows his true home"));
            list.Add(new BookModel(counter++, "Are There New Rules To Discover God"));
            list.Add(new BookModel(counter++, "When I Returned From India"));
            list.Add(new BookModel(counter++, "Are We Wired For God"));
            list.Add(new BookModel(counter++, "Can You Experience God While You Are Alive"));
            list.Add(new BookModel(counter++, "Five Internal Senses"));
            list.Add(new BookModel(counter++, "Theory Versus Practical"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "I Don’t Know Why People Pass This Up"));
            list.Add(new BookModel(counter++, "There Are Sign Post Of God Everywhere"));
            list.Add(new BookModel(counter++, "The Breath"));
            list.Add(new BookModel(counter++, "Take Care Of Your Body"));
            list.Add(new BookModel(counter++, "Silence"));
            list.Add(new BookModel(counter++, "How Do I Meditate"));
            list.Add(new BookModel(counter++, "If I Could Recommend One Thing"));
            list.Add(new BookModel(counter++, "Why Weren’t We Taught Where To Look For God"));
            list.Add(new BookModel(counter++, "Prison"));
            list.Add(new BookModel(counter++, "Brainwash"));
            list.Add(new BookModel(counter++, "Questions"));
            list.Add(new BookModel(counter++, "Ponder It Over"));
            list.Add(new BookModel(counter++, "I Like The Wine That I Have Been Become"));
            list.Add(new BookModel(counter++, "Does Life Throw You A Curve Ball"));
            list.Add(new BookModel(counter++, "Who Am I"));
            list.Add(new BookModel(counter++, "The Mind Is A Mirror"));
            list.Add(new BookModel(counter++, "Throw Away The Anger"));
            list.Add(new BookModel(counter++, "True Nature Of The Mind"));
            list.Add(new BookModel(counter++, "You Are A Genie"));
            list.Add(new BookModel(counter++, "Take Care Of Your Body 2"));
            list.Add(new BookModel(counter++, "Give Up"));
            list.Add(new BookModel(counter++, "Have You Ever Tries To Meditate"));
            list.Add(new BookModel(counter++, "Eons"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysTricks Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysTricks();
            }

            return _instance;
        }
    }
}