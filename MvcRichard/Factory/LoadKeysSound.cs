using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSound
    {
        private static LoadKeysSound _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSound()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "The Law Of Silence"));



            list.Add(new BookModel(counter++, "Silence"));

            list.Add(new BookModel(counter++, "The Sound Of Silence"));

            list.Add(new BookModel(counter++, "Silence is your friend Or Foe"));

            list.Add(new BookModel(counter++, "Calm Inside Of The Storm"));

            list.Add(new BookModel(counter++, "Carry Your Meditation Into Your Daily Life"));

            list.Add(new BookModel(counter++, "Listening"));

            list.Add(new BookModel(counter++, "Where Is The Buddha"));
            list.Add(new BookModel(counter++, "We see only 1 % of the light spectrum"));
            list.Add(new BookModel(counter++, "Do you listen to your body"));
            list.Add(new BookModel(counter++, "Feet On The Ground And Your Head Is In Heaven"));

            list.Add(new BookModel(counter++, "Which Level Are You On"));
            list.Add(new BookModel(counter++, "Focus"));
            list.Add(new BookModel(counter++, "The World Is A Drama"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Two"));
            list.Add(new BookModel(counter++, "Five"));
            list.Add(new BookModel(counter++, "Eleven"));
            list.Add(new BookModel(counter++, "Twenty-one"));
            list.Add(new BookModel(counter++, "Twenty-three"));
            list.Add(new BookModel(counter++, "Twenty-five"));
            list.Add(new BookModel(counter++, "Thirty-seven"));
            list.Add(new BookModel(counter++, "Forty-five"));
            list.Add(new BookModel(counter++, "Fifty-two"));
            list.Add(new BookModel(counter++, "Sixty"));
            list.Add(new BookModel(counter++, "Sixty-one"));
            list.Add(new BookModel(counter++, "Enlightenment"));
            list.Add(new BookModel(counter++, "God Won't Drive Your Car For You"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "If I Could Recommend One Thing"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "True Nature Of The Mind"));
            list.Add(new BookModel(counter++, "Is The Universe Biased"));
            list.Add(new BookModel(counter++, "Occam's razor"));
            list.Add(new BookModel(counter++, "One Drop Of Water"));
            list.Add(new BookModel(counter++, "The Modern Day Man Looks For God On The Moon And Beyond"));
            list.Add(new BookModel(counter++, "The Ox Parable"));
            list.Add(new BookModel(counter++, "The Four Conditions Of Mind"));
            list.Add(new BookModel(counter++, "Emptiness"));
            list.Add(new BookModel(counter++, "Five Internal Senses"));
            list.Add(new BookModel(counter++, "Chief Financial Officer"));

            list.Add(new BookModel(counter++, "Board Of Directors"));
            list.Add(new BookModel(counter++, "Unions"));
            list.Add(new BookModel(counter++, "Can You Hear The Grass Growing"));
            list.Add(new BookModel(counter++, "Silence is God's first language"));
            list.Add(new BookModel(counter++, "God Speaks Thru Silence"));
            list.Add(new BookModel(counter++, "Silence Speaks To You About The Secrets Of The Universe"));
            list.Add(new BookModel(counter++, "Silence Quotes"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysSound Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSound();
            }

            return _instance;
        }
    }
}