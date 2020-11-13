using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDeath
    {
        private static LoadKeysDeath _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDeath()
        {
            int counter = 0;

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "5 Minutes To Heaven"));
            list.Add(new BookModel(counter++, "All Things Must Pass"));
            list.Add(new BookModel(counter++, "Awareness"));
            list.Add(new BookModel(counter++, "Baby Grace"));
            list.Add(new BookModel(counter++, "Castles In The Sand"));
            list.Add(new BookModel(counter++, "Christ And Death"));
            list.Add(new BookModel(counter++, "Cross The Bridge"));
            list.Add(new BookModel(counter++, "Dad"));
            list.Add(new BookModel(counter++, "Did Christ Meditate"));
            list.Add(new BookModel(counter++, "Eduardo Pena RIP"));

           
            list.Add(new BookModel(counter++, "Enlightenment"));

            list.Add(new BookModel(counter++, "Fireworks In The Sky"));
            list.Add(new BookModel(counter++, "Five Internal Senses"));
            list.Add(new BookModel(counter++, "Follow Me On This Train Of Thought"));
            list.Add(new BookModel(counter++, "Generator, Operator, Destroyer"));
            list.Add(new BookModel(counter++, "God Released You"));
            list.Add(new BookModel(counter++, "Grandma Thais and Grandpa Bert"));

            
            list.Add(new BookModel(counter++, "Heaven or Hell"));
            list.Add(new BookModel(counter++, "If Death Approaches You"));
            list.Add(new BookModel(counter++, "If We Are Immortal"));
            list.Add(new BookModel(counter++, "In The Beginning Was The Word"));


            list.Add(new BookModel(counter++, "Is Life Like A Page Break"));
            list.Add(new BookModel(counter++, "Last Breath"));
            list.Add(new BookModel(counter++, "Last Dance"));
            list.Add(new BookModel(counter++, "Little Drops Of Mercy"));
            list.Add(new BookModel(counter++, "Mahatma Rajeshwar"));
            list.Add(new BookModel(counter++, "Mary Beth Jackson Lovett"));
            list.Add(new BookModel(counter++, "Martin Dale"));
            list.Add(new BookModel(counter++, "My Grandmother Josie"));

            
            list.Add(new BookModel(counter++, "Our Days Here Are Numbered"));
            list.Add(new BookModel(counter++, "Paul Sides"));


            
            list.Add(new BookModel(counter++, "Plug Into The Source"));
            list.Add(new BookModel(counter++, "Questions"));
            list.Add(new BookModel(counter++, "Randy Stabler"));
            list.Add(new BookModel(counter++, "Richie RIP"));
            list.Add(new BookModel(counter++, "Sat Chit Ananda"));
            list.Add(new BookModel(counter++, "Pleasant surprise"));
            list.Add(new BookModel(counter++, "Steve Hudson RIP"));
            list.Add(new BookModel(counter++, "Take off your mask"));

            list.Add(new BookModel(counter++, "The Book Of Llife"));
            list.Add(new BookModel(counter++, "The Cosmic Merry Go Round"));
            list.Add(new BookModel(counter++, "The Door"));
            list.Add(new BookModel(counter++, "The Ferris Wheels Of Life"));
            list.Add(new BookModel(counter++, "The Human Body"));







            list.Add(new BookModel(counter++, "The Lotus Flower"));
            list.Add(new BookModel(counter++, "The Party"));
            list.Add(new BookModel(counter++, "The Rapture"));
            list.Add(new BookModel(counter++, "The Ringing In My Ears"));
            list.Add(new BookModel(counter++, "The Shepherd"));
            list.Add(new BookModel(counter++, "The Universe Is Supporting You"));

            list.Add(new BookModel(counter++, "The Wheel Of Life"));
            list.Add(new BookModel(counter++, "The Word"));
            list.Add(new BookModel(counter++, "The World Is a Drama"));
            list.Add(new BookModel(counter++, "Time Passes Every Breath"));
            list.Add(new BookModel(counter++, "Want To Go Back Home"));


            list.Add(new BookModel(counter++, "We Are All Actors In Life"));
            list.Add(new BookModel(counter++, "What Is An Angel"));
            list.Add(new BookModel(counter++, "Who Were You Before You Were Born"));
            list.Add(new BookModel(counter++, "Why Were We Never Told"));
            list.Add(new BookModel(counter++, "You Are You Own Creator"));
            list.Add(new BookModel(counter++, "6-13-2017"));

            list.Add(new BookModel(counter++, "10-03-2018 John Mors"));
            list.Add(new BookModel(counter++, "02-28-2019 The Body Only Dies"));

            list.Add(new BookModel(counter++, "Layla Masant"));
            list.Add(new BookModel(counter++, "Passing Away"));
            list.Add(new BookModel(counter++, "RIP Ishwara Devi"));

            









        }

        public static LoadKeysDeath Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDeath();
            }

            return _instance;
        }
    }
}