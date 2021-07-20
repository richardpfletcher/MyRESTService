using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysNaropa
    {
        private static LoadKeysNaropa _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysNaropa()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "Commentary"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Nerve cells that fire together wire together"));
            list.Add(new BookModel(counter++, "Nobody changes until you change your energy"));
            list.Add(new BookModel(counter++, "Your body is your subconscious mind"));
            list.Add(new BookModel(counter++, "Behaviors to match the intention"));
            list.Add(new BookModel(counter++, "Have you ever seen an unhappy Buddhist Lama"));
            list.Add(new BookModel(counter++, "Victim of your environment"));
            list.Add(new BookModel(counter++, "Modify our behaviors reprogram the mind"));
            list.Add(new BookModel(counter++, "Are you heading in the right direction"));
            list.Add(new BookModel(counter++, "Eight limbs on the tree of life"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "How would you like the Dalai Lama to be your Grand Parent"));
            list.Add(new BookModel(counter++, "Dreams"));
            list.Add(new BookModel(counter++, "Set the tone of the conversation"));
            list.Add(new BookModel(counter++, "Just wing it"));
            list.Add(new BookModel(counter++, "Tummo and Tantra"));
            list.Add(new BookModel(counter++, "Video game of life"));
            list.Add(new BookModel(counter++, "Stories-Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Mafu Malidac Incident Flying On Swans"));
            list.Add(new BookModel(counter++, "Sands Of Aruana"));
            list.Add(new BookModel(counter++, "Sedona"));
            list.Add(new BookModel(counter++, "First Time Meeting Zoran"));
            list.Add(new BookModel(counter++, "Space Ride -Zoran"));
            list.Add(new BookModel(counter++, "Infinite Ocean Of Blue Meanies"));
            list.Add(new BookModel(counter++, "Sai Baba Dream"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "You are never alone 1"));
            list.Add(new BookModel(counter++, "You are never alone"));
            list.Add(new BookModel(counter++, "Rūpāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Board Of Directors"));

            

        }

        public static LoadKeysNaropa Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysNaropa();
            }

            return _instance;
        }
    }
}