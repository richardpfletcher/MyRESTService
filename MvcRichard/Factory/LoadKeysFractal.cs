using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysFractal
    {
        private static LoadKeysFractal _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysFractal()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Web of Life"));
            list.Add(new BookModel(counter++, "SURFING"));
            list.Add(new BookModel(counter++, "Mark McClellan"));
            list.Add(new BookModel(counter++, "Cookie Monster"));

            list.Add(new BookModel(counter++, "House Of The Future"));
            list.Add(new BookModel(counter++, "Jokesters"));
            list.Add(new BookModel(counter++, "Take Me To Your Leader"));
            list.Add(new BookModel(counter++, "PROPHESY"));
            list.Add(new BookModel(counter++, "Saving The Kitten"));
            list.Add(new BookModel(counter++, "Learning How To Ride A Bicycle"));
            list.Add(new BookModel(counter++, "Follow The Recipe"));


            list.Add(new BookModel(counter++, "Church"));
            list.Add(new BookModel(counter++, "Altar Boys"));
            list.Add(new BookModel(counter++, "EUROPE IN GRADE SCHOOL"));
            list.Add(new BookModel(counter++, "My father teaching us exercises"));
            list.Add(new BookModel(counter++, "HIGH SCHOOL"));
            list.Add(new BookModel(counter++, "Joyce Caldwell"));

            list.Add(new BookModel(counter++, "Mentors"));


            list.Add(new BookModel(counter++, "The boat and the whale"));
            list.Add(new BookModel(counter++, "Mark Blackburn"));
            list.Add(new BookModel(counter++, "Paul Cohen"));
            list.Add(new BookModel(counter++, "DRUGS AND ALCOHOL"));
            list.Add(new BookModel(counter++, "South American Travels")); //not found

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
            list.Add(new BookModel(counter++, "Chris Parker"));
            list.Add(new BookModel(counter++, "Joe Lopez"));
            list.Add(new BookModel(counter++, "Mark and Geraldine"));
            
            list.Add(new BookModel(counter++, "Back to the States"));
            list.Add(new BookModel(counter++, "Spaced out"));
            list.Add(new BookModel(counter++, "My first girl friend"));
            list.Add(new BookModel(counter++, "Santa Fe New Mexico"));
            

            list.Add(new BookModel(counter++, "SEARCH FOR ONESELF"));
            list.Add(new BookModel(counter++, "MEDITATION 10 HOURS A DAY"));
            list.Add(new BookModel(counter++, "Katharita Parsons Lamoza"));
            list.Add(new BookModel(counter++, "Kali Rodriguez"));
            list.Add(new BookModel(counter++, "Kathleen Cook"));
            list.Add(new BookModel(counter++, "WORKING IN THIS WORLD"));

            list.Add(new BookModel(counter++, "Eighties"));
            list.Add(new BookModel(counter++, "ENDLESS SUMMER"));
            list.Add(new BookModel(counter++, "NICK ROTH"));
            list.Add(new BookModel(counter++, "RIDDING THE INNER WAVE DOLPHINS"));
            list.Add(new BookModel(counter++, "LORD MICHAEL"));
            list.Add(new BookModel(counter++, "MONROE INSTITUTE"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));



            list.Add(new BookModel(counter++, "Monroe Adventure")); // where is this
            list.Add(new BookModel(counter++, "John Baier"));
            list.Add(new BookModel(counter++, "john and rick"));
            list.Add(new BookModel(counter++, "john and rick side 2"));
            list.Add(new BookModel(counter++, "David Schweizer"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "PAUL Mcclain"));
            list.Add(new BookModel(counter++, "Layla Masant"));
            list.Add(new BookModel(counter++, "Passing away"));
            list.Add(new BookModel(counter++, "COMPUTERS"));
            list.Add(new BookModel(counter++, "QUESTIONS"));
            list.Add(new BookModel(counter++, "MAFU MALIDAC INCIDENT FLYING ON SWANS"));
            list.Add(new BookModel(counter++, "SANDS OF ARUANA"));

            list.Add(new BookModel(counter++, "SEDONA"));
            list.Add(new BookModel(counter++, "FIRE WALKING"));
            list.Add(new BookModel(counter++, "FIRST TIME MEETING ZORAN"));
            list.Add(new BookModel(counter++, "Zoran 5 - 2 - 87 side a"));
            list.Add(new BookModel(counter++, "Zoran 5 - 2 - 87 side b"));



            list.Add(new BookModel(counter++, "SPACE RIDE -ZORAN"));

            list.Add(new BookModel(counter++, "INFINITE OCEAN OF BLUE MEANIES"));
            list.Add(new BookModel(counter++, "SAI BABA DREAM"));
            list.Add(new BookModel(counter++, "MEETING BARBARA"));
            list.Add(new BookModel(counter++, "San Diego"));
            list.Add(new BookModel(counter++, "1 SPLIT SECOND GOT IT DRIVING CAR"));
            list.Add(new BookModel(counter++, "Kundalini snake experience"));
            list.Add(new BookModel(counter++, "Naval special warfare -meeting alien"));

            list.Add(new BookModel(counter++, "Nineties"));
            list.Add(new BookModel(counter++, "OnMaui"));


            list.Add(new BookModel(counter++, "Zoran May 20 1990 side a")); //not yet included
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side b")); //not yet included
            list.Add(new BookModel(counter++, "REDISCOVER YOURSELF")); //need to make 
            list.Add(new BookModel(counter++, "I CAN'T SEE IT SO IT CAN'T BE REAL"));
            list.Add(new BookModel(counter++, "WORLD POLITICS"));
            list.Add(new BookModel(counter++, "WISDOM"));
            list.Add(new BookModel(counter++, "BEING FANATICAL WRONG ENERGY"));
            list.Add(new BookModel(counter++, "GOING HOME (FOREVER)"));
            list.Add(new BookModel(counter++, "THE MIRACLE OF LIFE"));
            list.Add(new BookModel(counter++, "DON'T SETTLE FOR mediocrity"));
            list.Add(new BookModel(counter++, "COMPASSION"));
            list.Add(new BookModel(counter++, "YOUR INNER TEACHER"));
            list.Add(new BookModel(counter++, "THE GREAT WHITE BROTHERHOOD"));
            list.Add(new BookModel(counter++, "Maharishi Mahesh Yogi"));
            list.Add(new BookModel(counter++, "BE HERE NOW"));

            list.Add(new BookModel(counter++, "DON'T MAKE A MOUNTAIN FROM A MOLEHILL"));
            list.Add(new BookModel(counter++, "THE WORLD IS NOT FLAT"));
            list.Add(new BookModel(counter++, "GO BEYOND YOUR BOOKS"));
            list.Add(new BookModel(counter++, "HEAVEN ON EARTH -STATE OF MIND"));
            list.Add(new BookModel(counter++, "DREAMS -YOUR SUBCONSCIOUS IS TELLING YOU SOMETHING"));
            list.Add(new BookModel(counter++, "ON YOUR OWN"));
            list.Add(new BookModel(counter++, "Arizona Light 3-7-87"));
            list.Add(new BookModel(counter++, "HEALTH"));
            list.Add(new BookModel(counter++, "PAUL SIDES"));
            list.Add(new BookModel(counter++, "GOALS AND DREAMS"));
            list.Add(new BookModel(counter++, "DREAMS"));
            list.Add(new BookModel(counter++, "BE LIKE A CHILD (INNOCENT AND OPEN)"));
            list.Add(new BookModel(counter++, "RAISING A FAMILY"));

            list.Add(new BookModel(counter++, "2000+"));
            list.Add(new BookModel(counter++, "Charles Schwab"));
            list.Add(new BookModel(counter++, "Plexis and Stillhead"));
            list.Add(new BookModel(counter++, "USDA RMA"));
            list.Add(new BookModel(counter++, "Heartland crop insurance"));
            list.Add(new BookModel(counter++, "USDA-Booz Allen"));
            list.Add(new BookModel(counter++, "whatscookingtreasures"));
            list.Add(new BookModel(counter++, "Getting laid off"));
            list.Add(new BookModel(counter++, "Nelson Art Museum"));
            list.Add(new BookModel(counter++, "Arboretum"));
            list.Add(new BookModel(counter++, "Kryon"));
            list.Add(new BookModel(counter++, "Ancestors"));




            list.Add(new BookModel(counter++, "Where Do We Come From"));
            list.Add(new BookModel(counter++, "Pleasant surprise"));
            list.Add(new BookModel(counter++, "Randy Stabler"));

            




        }

        public static LoadKeysFractal Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysFractal();
            }

            return _instance;
        }
    }
}