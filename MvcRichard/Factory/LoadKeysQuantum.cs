using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysQuantum
    {
        private static LoadKeysQuantum _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysQuantum()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Mind and Body"));
            list.Add(new BookModel(counter++, "Emotions"));
            list.Add(new BookModel(counter++, "New Thought"));
            list.Add(new BookModel(counter++, "New Concepts"));
            list.Add(new BookModel(counter++, "New Wiring"));

            list.Add(new BookModel(counter++, "New Personality"));
            list.Add(new BookModel(counter++, "New Human"));
            list.Add(new BookModel(counter++, "You Are Closer Than You Think "));



            list.Add(new BookModel(counter++, "Mindfulness")); // where is this
            list.Add(new BookModel(counter++, "Where Do These Memories Come From"));
            list.Add(new BookModel(counter++, "Chakras"));
            list.Add(new BookModel(counter++, "Endocrine System"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Putting Into Practice"));
            list.Add(new BookModel(counter++, "Concentrate On Positive Emotions"));
            list.Add(new BookModel(counter++, "Sitting Down Meditation"));






            list.Add(new BookModel(counter++, "Phase 1"));
            list.Add(new BookModel(counter++, "Phase 2"));
            list.Add(new BookModel(counter++, "Phase 3"));
            list.Add(new BookModel(counter++, "Phase 3 Meditation"));
            list.Add(new BookModel(counter++, "Walking Meditation"));
            list.Add(new BookModel(counter++, "Sleeping Meditation"));
            list.Add(new BookModel(counter++, "Monitoring Your Thoughts And Emotions"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysQuantum Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysQuantum();
            }

            return _instance;
        }
    }
}