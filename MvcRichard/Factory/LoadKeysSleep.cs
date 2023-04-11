using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSleep
    {
        private static LoadKeysSleep _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSleep()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Sleepl"));
            list.Add(new BookModel(counter++, "Can’t Go Back To Sleep"));
            list.Add(new BookModel(counter++, "Sleep is a mental factor"));
            list.Add(new BookModel(counter++, "Sleeping Meditationl"));
            list.Add(new BookModel(counter++, "Rumi - Because I cannot sleep"));
            list.Add(new BookModel(counter++, "Rumi - I am part of the load"));
            list.Add(new BookModel(counter++, "Rabia Basri - Dream Fable"));
            list.Add(new BookModel(counter++, "Attar of Nishapur-Looking for your own face"));
            list.Add(new BookModel(counter++, "Kahlil Gibran - The Sleep - "));
            list.Add(new BookModel(counter++, "The Sun Is Always Shinning We Just Fall Asleep"));
            list.Add(new BookModel(counter++, "A Good Night Sleep"));
            list.Add(new BookModel(counter++, " Like To Sleep Well At "));
            list.Add(new BookModel(counter++, "Children and Sleep"));
            list.Add(new BookModel(counter++, " Meditation for Sleep"));
            list.Add(new BookModel(counter++, "Are You Meditating or Sleeping"));
            list.Add(new BookModel(counter++, "Meditation vs "));
            list.Add(new BookModel(counter++, " You Need to Catch Up On Sleep, Is Meditation The Answer"));
            list.Add(new BookModel(counter++, "Why Sleep Meditation Works for Kids"));
            list.Add(new BookModel(counter++, "Clear Your Head With Sleep Meditation"));
            list.Add(new BookModel(counter++, "Tips for Getting a Good Night’s Sleep"));
            list.Add(new BookModel(counter++, "How Functional Foods May Improve Sleep and Immune Health"));
            list.Add(new BookModel(counter++, "Best Foods that Help You Sleep"));
            list.Add(new BookModel(counter++, "How Foods May Affect Our Sleep"));
            list.Add(new BookModel(counter++, "How Lack of Sleep Affects Junk Food "));
            list.Add(new BookModel(counter++, "Does Junk Food Cause Insomnia"));
            list.Add(new BookModel(counter++, "What to Do Before Bed"));
            list.Add(new BookModel(counter++, "When Is the Best Time To Go to Sleep"));
            list.Add(new BookModel(counter++, "What’s the Best Time to "));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysSleep Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSleep();
            }

            return _instance;
        }
    }
}