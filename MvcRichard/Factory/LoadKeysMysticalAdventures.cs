using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMysticalAdventures
    {
        private static LoadKeysMysticalAdventures _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMysticalAdventures()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



            list.Add(new BookModel(counter++, "Wow!!!"));

            list.Add(new BookModel(counter++, "Take Me To Your Leader"));

            list.Add(new BookModel(counter++, "Prophesy On Maharai Ji Baseball Game"));

            list.Add(new BookModel(counter++, "Learning How To Ride A Bicycle"));

            list.Add(new BookModel(counter++, "My Father Teaching Us Exercises"));

            list.Add(new BookModel(counter++, "The Boat And The Whale"));

            list.Add(new BookModel(counter++, "Surfing Experience In France Something Will Happen In India"));

            list.Add(new BookModel(counter++, "First Day In India"));

            list.Add(new BookModel(counter++, "Initiation"));

            list.Add(new BookModel(counter++, "Asokananda Incident"));

            list.Add(new BookModel(counter++, "Getting Drunk On Water"));

            list.Add(new BookModel(counter++, "Search For Oneself"));

            list.Add(new BookModel(counter++, "Meditation 10 Hours A Day"));

            list.Add(new BookModel(counter++, "Lord Michael"));

            list.Add(new BookModel(counter++, "Monroe Institute"));

            list.Add(new BookModel(counter++, "Monroe Adventure"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1 side a"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2 side a"));

            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3 side a"));

            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));

            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));

            list.Add(new BookModel(counter++, "Mafu Malidac Incident Flying On Swans"));

            list.Add(new BookModel(counter++, "Sands Of Aruana"));

            list.Add(new BookModel(counter++, "Sedona"));

            list.Add(new BookModel(counter++, "Fire Walking"));

            list.Add(new BookModel(counter++, "First Time Meeting Zoran"));

            list.Add(new BookModel(counter++, "Space Ride –Zoran"));

            list.Add(new BookModel(counter++, "Infinite Ocean Of Blue Meanies"));

            list.Add(new BookModel(counter++, "San Diego"));

            list.Add(new BookModel(counter++, "1 Split Second Got It Driving Car"));

            list.Add(new BookModel(counter++, "Kundalini Snake Experience"));

            list.Add(new BookModel(counter++, "Naval Special Warfare - Meeting Alien"));

            list.Add(new BookModel(counter++, "Zoran May 20 1990 side a"));

            list.Add(new BookModel(counter++, "Zoran May 20 1990 side b"));

            list.Add(new BookModel(counter++, "Rediscover Yourself"));

            list.Add(new BookModel(counter++, "I Can't See It So It Can't Be Real"));

            list.Add(new BookModel(counter++, "Being Fanatical Wrong Energy"));

            list.Add(new BookModel(counter++, "Going Home(Forever)"));

            list.Add(new BookModel(counter++, "The Miracle Of Life"));

            list.Add(new BookModel(counter++, "Don't Settle For Mediocrity"));

            list.Add(new BookModel(counter++, "Compassion"));

            list.Add(new BookModel(counter++, "Your Inner Teacher"));

            list.Add(new BookModel(counter++, "The Great White Brotherhood"));

            list.Add(new BookModel(counter++, "Be Here Now"));

            list.Add(new BookModel(counter++, "Don't Make A Mountain From A Molehill."));

            list.Add(new BookModel(counter++, "Dreams - Your Subconscious Is Telling You Something"));

            list.Add(new BookModel(counter++, "On Your Own Or I Get By With A Little Help From My Friends"));

            list.Add(new BookModel(counter++, "Where Do We Come From"));

            list.Add(new BookModel(counter++, "Pleasant Surprise"));

            list.Add(new BookModel(counter++, "Randy Stabler"));

            list.Add(new BookModel(counter++, "Mafu Arizona Light 3 - 7 - 87"));

            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysMysticalAdventures Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMysticalAdventures();
            }

            return _instance;
        }
    }
}