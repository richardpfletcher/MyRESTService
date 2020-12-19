using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysJatakaTales
    {
        private static LoadKeysJatakaTales _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysJatakaTales()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Intro Richard"));



            list.Add(new BookModel(counter++, "Fast Foreword 49 years"));

            list.Add(new BookModel(counter++, "Surfing Experience In France"));

            list.Add(new BookModel(counter++, "Indian Pakistan War"));

            list.Add(new BookModel(counter++, "First Day In India"));

            list.Add(new BookModel(counter++, "Initiation"));

            list.Add(new BookModel(counter++, "Finding Bombay Ashram"));

            list.Add(new BookModel(counter++, "Asokananda Incident"));

            list.Add(new BookModel(counter++, "Getting Drunk On Water"));

            list.Add(new BookModel(counter++, "Where they came from"));

            list.Add(new BookModel(counter++, "Buddha and the drunk elephant"));

            list.Add(new BookModel(counter++, "The Deer King of the Banyan"));

            list.Add(new BookModel(counter++, "The Golden Plate"));

            list.Add(new BookModel(counter++, "Beauty and Grey"));

            list.Add(new BookModel(counter++, "The Wind and the Moon"));

            list.Add(new BookModel(counter++, "Two Stupid Children"));

            list.Add(new BookModel(counter++, "The Tree That Acted Like a Hunter"));

            list.Add(new BookModel(counter++, "The Magic Priest and the Kidnapper Gang"));

            list.Add(new BookModel(counter++, "Watering the Garden"));

            list.Add(new BookModel(counter++, "The Bull Called Delightful"));

            list.Add(new BookModel(counter++, "Buried Treasure"));

            list.Add(new BookModel(counter++, "The Birth of a Banyan Tree"));

            list.Add(new BookModel(counter++, "The Fawn Who Played Hooky"));

            list.Add(new BookModel(counter++, "Finding a New Spring"));

            list.Add(new BookModel(counter++, "Best Friends"));

            list.Add(new BookModel(counter++, "The Baby Quail Who Could Not Fly Away"));

            list.Add(new BookModel(counter++, "The Mouse Merchant"));

            list.Add(new BookModel(counter++, "The Fortunate Fish"));

            list.Add(new BookModel(counter++, "Bamboo's Father"));

            list.Add(new BookModel(counter++, "Big Red, Little Red and No - squeal"));

            list.Add(new BookModel(counter++, "The Crane and the Crab"));

            list.Add(new BookModel(counter++, "Salty Liquor"));

            list.Add(new BookModel(counter++, "Little Prince No - father"));

            list.Add(new BookModel(counter++, "The Silent Buddha"));

            list.Add(new BookModel(counter++, "Demons in the Desert"));




        }

        public static LoadKeysJatakaTales Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysJatakaTales();
            }

            return _instance;
        }
    }
}