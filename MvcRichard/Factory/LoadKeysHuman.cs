using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysHuman
    {
        private static LoadKeysHuman _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysHuman()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "The Fight of Two Wolves Within You"));
            list.Add(new BookModel(counter++, "Conscious Politics"));
            list.Add(new BookModel(counter++, "Kindness In Politics"));
            list.Add(new BookModel(counter++, "Mothers"));
            list.Add(new BookModel(counter++, "Politics hold your emotions"));
            list.Add(new BookModel(counter++, "Got To Tell You"));
            list.Add(new BookModel(counter++, "Heart Of Gold"));
            list.Add(new BookModel(counter++, "If Death Approaches You"));

            

            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "The Frog in The Well"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Close Your Eyes"));

           






            list.Add(new BookModel(counter++, "The New Human In Sports"));
            list.Add(new BookModel(counter++, "The New Human In Entertainment"));
            list.Add(new BookModel(counter++, "The New Human In Health"));
            list.Add(new BookModel(counter++, "The New Human In Society"));

            


            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));





            list.Add(new BookModel(counter++, "From Me To We"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));

            list.Add(new BookModel(counter++, "Brotherhood Sisterhood of Light"));
            list.Add(new BookModel(counter++, "Signposts Are All  Around"));
            list.Add(new BookModel(counter++, "Fellow Wizards Advice"));
            list.Add(new BookModel(counter++, "Wizards Handbook"));
            list.Add(new BookModel(counter++, "Message15"));


            list.Add(new BookModel(counter++, "Message11"));
            list.Add(new BookModel(counter++, "Message12"));
            list.Add(new BookModel(counter++, "Where We Are Going"));
            list.Add(new BookModel(counter++, "One Million Years From Now"));
            list.Add(new BookModel(counter++, "Ten Million Years From Now"));




        }

        public static LoadKeysHuman Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysHuman();
            }

            return _instance;
        }
    }
}