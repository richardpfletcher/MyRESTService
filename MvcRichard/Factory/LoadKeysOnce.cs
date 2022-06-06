using MvcRichard.Models;
using System.Collections.Generic;
   

    namespace MvcRichard.Factory
    {
        internal class LoadKeysOnce
        {
            private static LoadKeysOnce _instance;

            public static List<BookModel> list = new List<BookModel>();

            // Constructor is 'protected'
            protected LoadKeysOnce()
            {
                int counter = 0;
                //talks

                list.Add(new BookModel(counter++, "Intro"));
                list.Add(new BookModel(counter++, "Sound of silence"));

                list.Add(new BookModel(counter++, "Chuck Cook"));

                list.Add(new BookModel(counter++, "Betty Topalion"));

                list.Add(new BookModel(counter++, "Betty Topalion Poetry Assignment"));

                list.Add(new BookModel(counter++, "Ducks splashing in driveway"));

                list.Add(new BookModel(counter++, "Did Jainism Help Shape the American Civil Rights Movementl"));

                list.Add(new BookModel(counter++, "My Trip to the Land of Gandhi"));

                list.Add(new BookModel(counter++, "My Trip to the Land of Gandhi 2"));
                list.Add(new BookModel(counter++, "AUL SIDES"));

                list.Add(new BookModel(counter++, "NICK ROTH"));

                list.Add(new BookModel(counter++, "My Twin Brother"));

                list.Add(new BookModel(counter++, "Joseph Campbell"));

                list.Add(new BookModel(counter++, "MYTHIC DISCOVERY"));

                list.Add(new BookModel(counter++, "PART 2"));

                list.Add(new BookModel(counter++, "Once upon a Time was a man"));

                list.Add(new BookModel(counter++, "The Boat And The Whale"));

                list.Add(new BookModel(counter++, "Mark Blackburn"));

                list.Add(new BookModel(counter++, "Paul Cohen"));

                list.Add(new BookModel(counter++, "The elephant gun"));

                list.Add(new BookModel(counter++, "Being shot at"));

                list.Add(new BookModel(counter++, "Randal Stabler message 1"));

                list.Add(new BookModel(counter++, "Randal Stabler message 2"));

                list.Add(new BookModel(counter++, "Carl Sagan"));

                list.Add(new BookModel(counter++, "Prem Rawat"));

                list.Add(new BookModel(counter++, "Stories to ponder over"));

                list.Add(new BookModel(counter++, "The Jeweler And The Thief"));


                list.Add(new BookModel(counter++, "The Fight of Two Wolves Within You"));

                list.Add(new BookModel(counter++, "Learning How To Ride A Bicycle"));

                list.Add(new BookModel(counter++, "Follow The Recipe"));

                list.Add(new BookModel(counter++, "he Frog in The Well"));

                list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));

                list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));

                list.Add(new BookModel(counter++, "The Mirror"));

                list.Add(new BookModel(counter++, "The Ugly Duckling"));

                list.Add(new BookModel(counter++, "The Sun And The Wind"));
                list.Add(new BookModel(counter++, "The Sun And Darkness"));

                list.Add(new BookModel(counter++, "Buddha and the drunk elephant"));

                list.Add(new BookModel(counter++, "The Deer King of the Banyan"));

                list.Add(new BookModel(counter++, "ig Red, Little Red and No - squeal"));

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

                list.Add(new BookModel(counter++, "Little Prince No-father"));

                list.Add(new BookModel(counter++, "The Silent Buddha"));


                list.Add(new BookModel(counter++, "Demons in the Desert"));









            }

            public static LoadKeysOnce Instance()
            {
                // Uses lazy initialization.
                // Note: this is not thread safe.
                if (_instance == null)
                {
                    _instance = new LoadKeysOnce();
                }

                return _instance;
            }
        }
    }
    