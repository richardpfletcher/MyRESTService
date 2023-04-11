using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysTemper
    {
        private static LoadKeysTemper _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysTemper()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "Like Leaves Blowing In The Wind"));
            list.Add(new BookModel(counter++, "The Center Of The Hurricane"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));
            list.Add(new BookModel(counter++, "The Wisdom of Your Cells"));
            list.Add(new BookModel(counter++, "Tip Of The Iceberg"));
            list.Add(new BookModel(counter++, "The 4 Pillars of Healing"));
            list.Add(new BookModel(counter++, "Mind and Body"));
            list.Add(new BookModel(counter++, "Emotions"));
            list.Add(new BookModel(counter++, "New Thought"));
            list.Add(new BookModel(counter++, "New Concepts"));
            list.Add(new BookModel(counter++, "New Wiring"));
            list.Add(new BookModel(counter++, "New Personality"));
            list.Add(new BookModel(counter++, "New Human"));
            list.Add(new BookModel(counter++, "You Are Closer Than You Think"));
            list.Add(new BookModel(counter++, "Mindfulness"));
            list.Add(new BookModel(counter++, "Radical Acceptance Revisited Tara Brach"));
            list.Add(new BookModel(counter++, "Dalai Lama 80th birthday speech at Glastonbury 2015"));
            list.Add(new BookModel(counter++, "3-02-2017 Anger = gasoline on fire"));
            list.Add(new BookModel(counter++, "Anger And Brain Waves"));
            list.Add(new BookModel(counter++, "Intro to Dog training for the mind book"));
            list.Add(new BookModel(counter++, "Dog training for the mind"));
            list.Add(new BookModel(counter++, "Transform"));
            list.Add(new BookModel(counter++, "Video game of life"));
            list.Add(new BookModel(counter++, "Anger"));
            list.Add(new BookModel(counter++, "Kindness Is More Powerful Than Anger"));
            list.Add(new BookModel(counter++, "Kudos"));
            list.Add(new BookModel(counter++, "Love Over Anger"));
            list.Add(new BookModel(counter++, "Riptides"));
            list.Add(new BookModel(counter++, "How To Survive A Wipeout"));
            list.Add(new BookModel(counter++, "Life Is So Beautiful"));
            list.Add(new BookModel(counter++, "State Of Anger "));
            list.Add(new BookModel(counter++, "Throw Away The Anger"));
            list.Add(new BookModel(counter++, "The mosquito itch "));
            list.Add(new BookModel(counter++, "True Nature Of The Mind "));
            list.Add(new BookModel(counter++, "You Are A Genie"));
            list.Add(new BookModel(counter++, "Eons"));
            list.Add(new BookModel(counter++, "4-28-2018 Chicken"));
            list.Add(new BookModel(counter++, "Why Weren’t We Taught Where To Look For God"));
            list.Add(new BookModel(counter++, "I Don’t Know Why People Pass This Up"));
            list.Add(new BookModel(counter++, "Signposts Are All Around"));
            list.Add(new BookModel(counter++, "The Breath"));
            list.Add(new BookModel(counter++, "Prison"));
            list.Add(new BookModel(counter++, "Brainwash"));
            list.Add(new BookModel(counter++, "Peace Education Program"));
            list.Add(new BookModel(counter++, "More Americans Killed by Guns Since 1968 Than in All U.S.Wars"));
            list.Add(new BookModel(counter++, "closing"));


        }

        public static LoadKeysTemper Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysTemper();
            }

            return _instance;
        }
    }
}