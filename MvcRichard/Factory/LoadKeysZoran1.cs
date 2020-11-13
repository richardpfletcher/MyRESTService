using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysZoran1
    {
        private static LoadKeysZoran1 _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysZoran1()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Good Night- Sweet Dreams"));
            list.Add(new BookModel(counter++, "Now You See Them Now You Don’t"));
            list.Add(new BookModel(counter++, "Where Did They Go"));
            list.Add(new BookModel(counter++, "They all came back "));
            list.Add(new BookModel(counter++, "Shamballa Was A Grand Experiment"));
            list.Add(new BookModel(counter++, "The Great White Brotherhood"));

            list.Add(new BookModel(counter++, "Little Ricky And Little Johnny"));
            list.Add(new BookModel(counter++, "Childhood (House Of The Future)"));
            list.Add(new BookModel(counter++, "Jokesters"));



            list.Add(new BookModel(counter++, "Take Me To Your Leader")); // where is this
            list.Add(new BookModel(counter++, "Learning How To Ride A Bicycle"));
            list.Add(new BookModel(counter++, "Follow The Recipe"));
            list.Add(new BookModel(counter++, "Saving The Kitten"));
            list.Add(new BookModel(counter++, "Europe In Grade School "));
            list.Add(new BookModel(counter++, "The Boat And The Whale"));
            list.Add(new BookModel(counter++, "18 TRAVEL AROUND THE WORD"));
            list.Add(new BookModel(counter++, "Surfing Experience In France"));






            list.Add(new BookModel(counter++, "Initiation"));
            list.Add(new BookModel(counter++, "Asokananda Incident"));
            list.Add(new BookModel(counter++, "Zambia"));
            list.Add(new BookModel(counter++, "South Africa"));
            list.Add(new BookModel(counter++, "Lord Michael"));
            list.Add(new BookModel(counter++, "Michah"));
            list.Add(new BookModel(counter++, "First Time Meeting Zoran"));
            list.Add(new BookModel(counter++, "Space Ride -Zora"));

            list.Add(new BookModel(counter++, "Zoran Prophesying About Barbara"));
            list.Add(new BookModel(counter++, "Meeting Barbara"));
            list.Add(new BookModel(counter++, "San Diego"));
            list.Add(new BookModel(counter++, "1 Split Second Got It Driving Car"));
            list.Add(new BookModel(counter++, "Kundalini Snake Experience"));
            list.Add(new BookModel(counter++, "Naval Special Warfare -Meeting Alien"));
            list.Add(new BookModel(counter++, "Be Like A Child (Innocent And Open"));
            list.Add(new BookModel(counter++, "Nineties"));

            list.Add(new BookModel(counter++, "OnMaui"));
            list.Add(new BookModel(counter++, "Shay Clayton"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "John Baier"));
            list.Add(new BookModel(counter++, "Kali Rodriguez"));
            list.Add(new BookModel(counter++, "Kathleen Cook"));
            list.Add(new BookModel(counter++, "Andrea"));

            list.Add(new BookModel(counter++, "Kathy from Maui "));
            list.Add(new BookModel(counter++, "Hum look at the similarities"));
           


        }

        public static LoadKeysZoran1 Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysZoran1();
            }

            return _instance;
        }
    }
}