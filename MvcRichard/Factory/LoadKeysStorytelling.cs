using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysStorytelling
    {
        private static LoadKeysStorytelling _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysStorytelling()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));



            list.Add(new BookModel(counter++, "The Fight of Two Wolves Within You"));

            list.Add(new BookModel(counter++, "Learning How To Ride A Bicycle"));

            list.Add(new BookModel(counter++, "Follow The Recipe"));

            list.Add(new BookModel(counter++, "The Frog in The Well"));

            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));

            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));

            list.Add(new BookModel(counter++, "The Mirror"));

            list.Add(new BookModel(counter++, "The Ugly Duckling"));

            list.Add(new BookModel(counter++, "The Sun And The Wind"));

            list.Add(new BookModel(counter++, "The Sun And Darkness"));

            list.Add(new BookModel(counter++, "House Of The Future"));

            list.Add(new BookModel(counter++, "Jokesters"));

            list.Add(new BookModel(counter++, "The Boat And The Whale"));

            list.Add(new BookModel(counter++, "Mark McClellan"));

            list.Add(new BookModel(counter++, "NICK ROTH"));

            list.Add(new BookModel(counter++, "Mark Blackburn"));

            list.Add(new BookModel(counter++, "Paul Cohen"));

            list.Add(new BookModel(counter++, "Surfing Adventure"));

            list.Add(new BookModel(counter++, "South American Travels"));

            list.Add(new BookModel(counter++, "Surfing Experience In France"));

            list.Add(new BookModel(counter++, "Indian Pakistan War"));

            list.Add(new BookModel(counter++, "First Day In India"));

            list.Add(new BookModel(counter++, "Initiation"));

            list.Add(new BookModel(counter++, "Mediation Ganges"));

            list.Add(new BookModel(counter++, "The Journey With The Girls"));
            list.Add(new BookModel(counter++, "Bombay Ashram"));

            list.Add(new BookModel(counter++, "Getting Drunk On Water"));

            list.Add(new BookModel(counter++, "Travels In Africa"));

            list.Add(new BookModel(counter++, "Seeing Maharaj Ji On Telephone Wires"));

            list.Add(new BookModel(counter++, "Zambia"));

            list.Add(new BookModel(counter++, "South Africa"));

            list.Add(new BookModel(counter++, "South Africa Friends"));

            list.Add(new BookModel(counter++, "Chris Parker"));

            list.Add(new BookModel(counter++, "Kali Rodriguez"));

            list.Add(new BookModel(counter++, "Kathleen Cook"));

            list.Add(new BookModel(counter++, "Santa Fe New Mexico"));

            list.Add(new BookModel(counter++, "Monroe Institute"));

            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));

            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 4"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 5"));

            list.Add(new BookModel(counter++, "Mentors"));

            list.Add(new BookModel(counter++, "First grade Mrs Ireland"));

            list.Add(new BookModel(counter++, "Second grade Mrs Werner"));

            list.Add(new BookModel(counter++, "Sixth grade Mr Walker"));

            list.Add(new BookModel(counter++, "Seventh grade"));

            list.Add(new BookModel(counter++, "Joan Condon"));

            list.Add(new BookModel(counter++, "Betty Topalion"));

            list.Add(new BookModel(counter++, "Mentors My High School Poetry Teacher"));

            list.Add(new BookModel(counter++, "Betty Topalion Poetry Assignment"));

            list.Add(new BookModel(counter++, "Bob Wentz"));

            list.Add(new BookModel(counter++, "Julia Smart"));

            list.Add(new BookModel(counter++, "Elenore Hodges Spanish"));

            list.Add(new BookModel(counter++, "Jim Hemsley"));

            list.Add(new BookModel(counter++, "Gerald Noser Algebra Teacher"));

            list.Add(new BookModel(counter++, "Coach Bob Halley Biology Teacher"));

            list.Add(new BookModel(counter++, "Coach Robert Donald"));

            list.Add(new BookModel(counter++, "Carroll Tatro"));

            list.Add(new BookModel(counter++, "My First Girl Friend"));

            list.Add(new BookModel(counter++, "Mark And Geraldine"));



        }

        public static LoadKeysStorytelling Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysStorytelling();
            }

            return _instance;
        }
    }
}