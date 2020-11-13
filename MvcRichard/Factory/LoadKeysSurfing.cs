using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSurfing
    {
        private static LoadKeysSurfing _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSurfing()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "SURFING"));
            list.Add(new BookModel(counter++, "EUROPE IN GRADE SCHOOL"));
            list.Add(new BookModel(counter++, "My father teaching us exercises"));
            list.Add(new BookModel(counter++, "HIGH SCHOOL"));
            list.Add(new BookModel(counter++, "Joyce Caldwell"));
            list.Add(new BookModel(counter++, "The boat and the whale"));
            list.Add(new BookModel(counter++, "DRUGS AND ALCOHOL"));
            list.Add(new BookModel(counter++, "South American Travels"));
            list.Add(new BookModel(counter++, "18 TRAVEL AROUND THE WORD"));
            list.Add(new BookModel(counter++, "Craig Perkins"));
            list.Add(new BookModel(counter++, "SURFING EXPERIENCE IN FRANCE"));
            list.Add(new BookModel(counter++, "INDIAN PAKISTAN WAR"));
            list.Add(new BookModel(counter++, "FIRST DAY IN INDIA"));
            list.Add(new BookModel(counter++, "Initiation"));
            list.Add(new BookModel(counter++, "MEDIATION GANGES"));
            list.Add(new BookModel(counter++, "FINDING BOMBAY ASHRAM"));
            list.Add(new BookModel(counter++, "ASOKANANDA INCIDENT"));
            list.Add(new BookModel(counter++, "GETTING DRUNK ON WATER"));
            list.Add(new BookModel(counter++, "TRAVELS IN AFRICA"));
            list.Add(new BookModel(counter++, "SEEING MAHARAJ JI ON TELEPHONE WIRES"));
            list.Add(new BookModel(counter++, "ZAMBIA"));
            list.Add(new BookModel(counter++, "SOUTH AFRICA"));
            list.Add(new BookModel(counter++, "ENDLESS SUMMER"));
            list.Add(new BookModel(counter++, "NICK ROTH"));
            list.Add(new BookModel(counter++, "RIDDING THE INNER WAVE DOLPHINS"));
            list.Add(new BookModel(counter++, "SEDONA"));
            list.Add(new BookModel(counter++, "FIRE WALKING"));
            list.Add(new BookModel(counter++, "San Diego"));
            list.Add(new BookModel(counter++, "1 SPLIT SECOND GOT IT DRIVING CAR"));
            list.Add(new BookModel(counter++, "Kundalini snake experience"));
            list.Add(new BookModel(counter++, "Naval special warfare -meeting alien"));
            list.Add(new BookModel(counter++, "Nineties"));
            list.Add(new BookModel(counter++, "PAUL SIDES"));
            list.Add(new BookModel(counter++, "Pleasant surprise"));
            list.Add(new BookModel(counter++, "Randy Stabler"));
            list.Add(new BookModel(counter++, "Paddle out"));
            list.Add(new BookModel(counter++, "Paradise"));
            list.Add(new BookModel(counter++, "Focus"));
            list.Add(new BookModel(counter++, "How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "Adventure"));
            list.Add(new BookModel(counter++, "The Thrill Of Surfing"));
            list.Add(new BookModel(counter++, "The Surfboard"));
            list.Add(new BookModel(counter++, "Surfer Lost At Sea"));
            list.Add(new BookModel(counter++, "Aloha"));
            list.Add(new BookModel(counter++, "Be In The Moment"));
            list.Add(new BookModel(counter++, "Confident Man"));
            list.Add(new BookModel(counter++, "Day Of Grace"));
            list.Add(new BookModel(counter++, "I Feel So Much Love"));
            list.Add(new BookModel(counter++, "If Death Approaches You"));
            list.Add(new BookModel(counter++, "Life Is So Beautiful"));
            list.Add(new BookModel(counter++, "So Many Flavors"));
            list.Add(new BookModel(counter++, "Steve Hudson RIP"));
            list.Add(new BookModel(counter++, "That Ultimate Feeling"));
            list.Add(new BookModel(counter++, "The Best Is Yet To Come"));
            list.Add(new BookModel(counter++, "The Island Of Bali"));
            list.Add(new BookModel(counter++, "The Lyrics Of The Song"));
            list.Add(new BookModel(counter++, "The Perils Of Being Young"));























        }

        public static LoadKeysSurfing Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSurfing();
            }

            return _instance;
        }
    }
}