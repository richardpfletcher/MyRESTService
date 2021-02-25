using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysEconomics
    {
        private static LoadKeysEconomics _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysEconomics()
        {
            int counter = 0;
           

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Mediation"));
            list.Add(new BookModel(counter++, "Empty Trinkets Of Life"));
            list.Add(new BookModel(counter++, "Conscious"));
            list.Add(new BookModel(counter++, "Fourteen Video Game Stages Of Spiritual Development"));
            list.Add(new BookModel(counter++, "Economics"));
            list.Add(new BookModel(counter++, "Indigenous Americans Spirituality and Ecos"));
            list.Add(new BookModel(counter++, "Aboriginal"));
            list.Add(new BookModel(counter++, "Apathy"));
            list.Add(new BookModel(counter++, "Chop Down The Trees"));
            list.Add(new BookModel(counter++, "Gaia -Message5"));
            list.Add(new BookModel(counter++, "Gaia -Message10"));
            list.Add(new BookModel(counter++, "Children Working In Mines"));
            list.Add(new BookModel(counter++, "Global Prosperity For All"));
            list.Add(new BookModel(counter++, "I Can't See It So It Can't Be Real"));
            list.Add(new BookModel(counter++, "Magnets Are The Future"));
            list.Add(new BookModel(counter++, "Man Vision Of Paradise"));
            list.Add(new BookModel(counter++, "Non -violence in economy"));
            list.Add(new BookModel(counter++, "Ten Million Years From Now"));
            list.Add(new BookModel(counter++, "Recalibration"));
            list.Add(new BookModel(counter++, "Reset Button"));
            list.Add(new BookModel(counter++, "The Law Of Calibration"));
            list.Add(new BookModel(counter++, "The Revolution Is Here"));
            list.Add(new BookModel(counter++, "The Wise Man Just Simply Smiles"));
            list.Add(new BookModel(counter++, "To Be Spiritual Is To Be Practical"));
            list.Add(new BookModel(counter++, "We Decide The Outcome"));
            list.Add(new BookModel(counter++, "Wisdom From Your Ancestors"));
            list.Add(new BookModel(counter++, "You Are Closer Than You Think"));
            list.Add(new BookModel(counter++, "3/16/2018 Panpsychism"));
            list.Add(new BookModel(counter++, "4/28/2018 Chicken"));
            list.Add(new BookModel(counter++, "Closing"));


        }

        public static LoadKeysEconomics Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysEconomics();
            }

            return _instance;
        }
    }
}