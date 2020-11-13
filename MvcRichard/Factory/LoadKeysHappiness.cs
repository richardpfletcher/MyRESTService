using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysHappiness
    {
        private static LoadKeysHappiness _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysHappiness()
        {
            int counter = 0;

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "The Ray Of Happiness"));
            list.Add(new BookModel(counter++, "The Ray Of Bliss"));
            list.Add(new BookModel(counter++, "The Ray Of Contentment"));
            list.Add(new BookModel(counter++, "The Ray Of Self Control"));
            list.Add(new BookModel(counter++, "The Ray Of Non-Attachment"));
            list.Add(new BookModel(counter++, "The Ray Of Compassion"));
            list.Add(new BookModel(counter++, "The Ray Of Good-Natured"));
            list.Add(new BookModel(counter++, "The Ray Of Forgiveness"));

            list.Add(new BookModel(counter++, "The Law Of Laughter"));
            list.Add(new BookModel(counter++, "The Law Of Prayer"));
            list.Add(new BookModel(counter++, "The Four Noble Laws (Truths)"));
            list.Add(new BookModel(counter++, "The Law Of Balance"));
            list.Add(new BookModel(counter++, "The Law Of Health"));
            list.Add(new BookModel(counter++, "The Ox Parable"));
            list.Add(new BookModel(counter++, "The Law Of Free Will"));
            list.Add(new BookModel(counter++, "The Law Of Intuition"));
            


            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Empty Trinkets Of Life"));
            list.Add(new BookModel(counter++, "Happiness Lies Inside"));
            list.Add(new BookModel(counter++, "Tune Your Mind")); 
            list.Add(new BookModel(counter++, "Happiness")); 
            list.Add(new BookModel(counter++, "The Carrot On The Stick"));
            list.Add(new BookModel(counter++, "I Don’t Know Why People Pass This Up")); 
            list.Add(new BookModel(counter++, "There Is A Point In Life"));
            list.Add(new BookModel(counter++, "God Is Patient")); 
            list.Add(new BookModel(counter++, "Happiness 2"));
            list.Add(new BookModel(counter++, "Best Of Both Worlds)"));

            list.Add(new BookModel(counter++, "India"));
            list.Add(new BookModel(counter++, "Hey You")); 
            list.Add(new BookModel(counter++, "The Challenges Of Marriage"));
            list.Add(new BookModel(counter++, "The Rip Off Artist"));
            list.Add(new BookModel(counter++, "I Want My MTV"));
            list.Add(new BookModel(counter++, "The Journey"));
            list.Add(new BookModel(counter++, "Cooking Up A Storm"));
            list.Add(new BookModel(counter++, "Feel So Alone"));
            list.Add(new BookModel(counter++, "Fully Alive"));
            list.Add(new BookModel(counter++, "Generator, Operator, Destroyer)"));
            list.Add(new BookModel(counter++, "Hit The Wall"));
            list.Add(new BookModel(counter++, "Imagine The Feeling"));
            list.Add(new BookModel(counter++, "Just Turn On The Music"));
            list.Add(new BookModel(counter++, "Last Breath"));
            list.Add(new BookModel(counter++, "Money Can’t Buy"));  
            list.Add(new BookModel(counter++, "Nothing In This World Last Forever"));

            list.Add(new BookModel(counter++, "State Of Bliss"));
            list.Add(new BookModel(counter++, "Sweet Times"));
            list.Add(new BookModel(counter++, "I Feel"));
            list.Add(new BookModel(counter++, "Best of both worlds"));
            list.Add(new BookModel(counter++, "Heaven Moves With Me"));
           






        }

        public static LoadKeysHappiness Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysHappiness();
            }

            return _instance;
        }
    }
}