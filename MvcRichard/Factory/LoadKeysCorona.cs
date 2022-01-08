using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysCorona
    {
        private static LoadKeysCorona _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysCorona()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



            list.Add(new BookModel(counter++, "Reset Button"));
            list.Add(new BookModel(counter++, "Dear Family"));
            list.Add(new BookModel(counter++, "The Law Of Free Will"));
            list.Add(new BookModel(counter++, "The Law Of Unity"));
            list.Add(new BookModel(counter++, "The Law Of Kindness"));
            list.Add(new BookModel(counter++, "The Law Of Practice"));
            list.Add(new BookModel(counter++, "The Law Of Calibration"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));
            list.Add(new BookModel(counter++, "Cultivating The Mind"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "What Is Panpsychism"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Gratitude"));



            list.Add(new BookModel(counter++, "Spring Break"));
            list.Add(new BookModel(counter++, "Close To Home"));
            list.Add(new BookModel(counter++, "Fear"));
            list.Add(new BookModel(counter++, "Can We Change"));
            list.Add(new BookModel(counter++, "Shock Therapy"));
            list.Add(new BookModel(counter++, "The Fight of Two Wolves Within You"));
            list.Add(new BookModel(counter++, "Boredom"));
            list.Add(new BookModel(counter++, "Stop The Noise In My Head"));
            list.Add(new BookModel(counter++, "Word Games"));
            list.Add(new BookModel(counter++, "Online Funerals"));
            list.Add(new BookModel(counter++, "Here's Something Interesting"));
            list.Add(new BookModel(counter++, "Closing"));
            list.Add(new BookModel(counter++, "Family And Friends"));
            list.Add(new BookModel(counter++, "Patience"));
            list.Add(new BookModel(counter++, "Your choice"));
            list.Add(new BookModel(counter++, "The Last Wave"));
            list.Add(new BookModel(counter++, "From Me To We"));
            list.Add(new BookModel(counter++, "Trust"));
            list.Add(new BookModel(counter++, "Wear A Mask"));
            list.Add(new BookModel(counter++, "We Decide The Outcome"));
            list.Add(new BookModel(counter++, "07-05 - 2020 Mt Rushmore"));
            list.Add(new BookModel(counter++, "07-06 - 2020 United States"));
            list.Add(new BookModel(counter++, "Inspire"));
            list.Add(new BookModel(counter++, "11-03-2020 Voting & update on the virus -"));
            list.Add(new BookModel(counter++, "12-05-2020 can’t see family"));
            list.Add(new BookModel(counter++, "12-17-2020 Yea The Vaccine Has Arrived"));
            list.Add(new BookModel(counter++, "Preventive"));
            list.Add(new BookModel(counter++, "01-08-2022 Sawing Off The Branch We Are Sitting On"));

        }

        public static LoadKeysCorona Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysCorona();
            }

            return _instance;
        }
    }
}