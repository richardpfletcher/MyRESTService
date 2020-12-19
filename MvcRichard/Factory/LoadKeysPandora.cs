using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysPandora
    {
        private static LoadKeysPandora _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysPandora()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Pandora's Box"));



            list.Add(new BookModel(counter++, "Gathering Wisdom"));

            list.Add(new BookModel(counter++, "Behavior Modification Empires"));

            list.Add(new BookModel(counter++, "Behavior Modification Empires 2"));

            list.Add(new BookModel(counter++, "Being a Bully"));

            list.Add(new BookModel(counter++, "Misinformation"));

            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));

            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));

            list.Add(new BookModel(counter++, "Be kind – Don’t be a flame thrower"));

            list.Add(new BookModel(counter++, "Tweet Lies"));

            list.Add(new BookModel(counter++, "Fake people you think are dishing out great advice"));

            list.Add(new BookModel(counter++, "Divide us versus them"));

            list.Add(new BookModel(counter++, "I’m right your wrong"));

            list.Add(new BookModel(counter++, "Numbness"));

            list.Add(new BookModel(counter++, "Politics gone astray"));

            list.Add(new BookModel(counter++, "It's Been There All The Time"));

            list.Add(new BookModel(counter++, "Custom Designed By God"));

            list.Add(new BookModel(counter++, "Custom Designed By God 2"));

            list.Add(new BookModel(counter++, "Mind and Body"));

            list.Add(new BookModel(counter++, "Emotions"));

            list.Add(new BookModel(counter++, "New Thought"));

            list.Add(new BookModel(counter++, "New Concepts"));

            list.Add(new BookModel(counter++, "New Wiring"));

            list.Add(new BookModel(counter++, "New Personality"));

            list.Add(new BookModel(counter++, "New Human"));

            list.Add(new BookModel(counter++, "You Are Closer Than You Think"));

            list.Add(new BookModel(counter++, "Mindfulness"));

            list.Add(new BookModel(counter++, "Tip Of The Iceberg"));




        }

        public static LoadKeysPandora Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysPandora();
            }

            return _instance;
        }
    }
}