using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysShamanism
    {
        private static LoadKeysShamanism _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysShamanism()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Message1"));
            list.Add(new BookModel(counter++, "Message2"));
            list.Add(new BookModel(counter++, "Message3"));
            list.Add(new BookModel(counter++, "Message4"));
            list.Add(new BookModel(counter++, "Message5"));
            list.Add(new BookModel(counter++, "Message6"));
            list.Add(new BookModel(counter++, "Message7"));
            list.Add(new BookModel(counter++, "Message8"));
            list.Add(new BookModel(counter++, "Message9)"));
            list.Add(new BookModel(counter++, "Message10"));
            list.Add(new BookModel(counter++, "Message11"));
            list.Add(new BookModel(counter++, "Message12"));
            list.Add(new BookModel(counter++, "Message13"));
            list.Add(new BookModel(counter++, "Message14"));
            list.Add(new BookModel(counter++, "Message15"));



            list.Add(new BookModel(counter++, "We Say We Are Intelligent But Are We"));


            list.Add(new BookModel(counter++, "Life’s mystery"));
            list.Add(new BookModel(counter++, "Indigenous People"));
            list.Add(new BookModel(counter++, "Indigenous People 2"));
            list.Add(new BookModel(counter++, "Indigenous People 3"));
            list.Add(new BookModel(counter++, "Gaia Intro"));
            list.Add(new BookModel(counter++, "From Me to We Intro"));
            list.Add(new BookModel(counter++, "Chapter1"));
            list.Add(new BookModel(counter++, "Chapter2"));
            list.Add(new BookModel(counter++, "Chapter3"));
            list.Add(new BookModel(counter++, "Chapter4"));
            list.Add(new BookModel(counter++, "Chapter5"));
            list.Add(new BookModel(counter++, "Chapter6"));
            list.Add(new BookModel(counter++, "Chapter7"));
            list.Add(new BookModel(counter++, "Chapter8"));
            list.Add(new BookModel(counter++, "Chapter9"));
            list.Add(new BookModel(counter++, "Chapter10"));
            list.Add(new BookModel(counter++, "Chapter11"));
            list.Add(new BookModel(counter++, "Carlos Castaneda - Quotes 1"));
            list.Add(new BookModel(counter++, "Carlos Castaneda - Quotes 2"));
            list.Add(new BookModel(counter++, "Angaangaq"));
            list.Add(new BookModel(counter++, "Aboriginal -Quotes 1"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 4"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 5"));
            list.Add(new BookModel(counter++, "John Baier"));
            list.Add(new BookModel(counter++, "John And Rick"));
            list.Add(new BookModel(counter++, "John And Rick Side 2"));
            list.Add(new BookModel(counter++, "David Schweizer"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "Paul Mcclain"));
            list.Add(new BookModel(counter++, "House Of The Future"));
            list.Add(new BookModel(counter++, "Jokesters"));
            list.Add(new BookModel(counter++, "Take Me To Your Leader"));
            list.Add(new BookModel(counter++, "1 Split Second Got It Driving Car"));
            list.Add(new BookModel(counter++, "Kundalini Snake Experience"));
            list.Add(new BookModel(counter++, "Initiation"));
            list.Add(new BookModel(counter++, "Mediation Ganges"));
            list.Add(new BookModel(counter++, "First Time Meeting Zoran"));
            list.Add(new BookModel(counter++, "Space Ride - Zoran"));
            list.Add(new BookModel(counter++, "Infinite Ocean Of Blue Meanies"));
            list.Add(new BookModel(counter++, "Sai Baba Dream"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Concentrate On Positive Emotions"));
            list.Add(new BookModel(counter++, "Sitting Down Meditation"));
            list.Add(new BookModel(counter++, "Phase 1"));
            list.Add(new BookModel(counter++, "Phase 2"));
            list.Add(new BookModel(counter++, "Phase 3"));
            list.Add(new BookModel(counter++, "Phase 3 Meditation"));
            list.Add(new BookModel(counter++, "Walking Meditation"));
            list.Add(new BookModel(counter++, "Monitoring Your Thoughts And Emotions"));





        }

        public static LoadKeysShamanism Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysShamanism();
            }

            return _instance;
        }
    }
}