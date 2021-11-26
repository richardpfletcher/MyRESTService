using System;
using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDragonsNaropa
    {
        private static LoadKeysDragonsNaropa _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDragonsNaropa()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Intro 2"));
            list.Add(new BookModel(counter++, "If you have read this far"));
            list.Add(new BookModel(counter++, "Ponder It Over"));
            list.Add(new BookModel(counter++, "Mm I get high with a little help from my friends"));
            list.Add(new BookModel(counter++, "You are your own master chemist"));
            list.Add(new BookModel(counter++, "How would you like the Dalai Lama to be your Grand Parent"));
            list.Add(new BookModel(counter++, "Just wing it"));
            list.Add(new BookModel(counter++, "6 Yogas Of Naropa"));
            list.Add(new BookModel(counter++, "Tummo and Tantra"));
            list.Add(new BookModel(counter++, "Dragon History And Tummo"));
            list.Add(new BookModel(counter++, "6 Afflictions"));
            list.Add(new BookModel(counter++, "Are You Curious or Dull About Life"));
            list.Add(new BookModel(counter++, "Nerve cells that fire together wire together"));
            list.Add(new BookModel(counter++, "Illusory Body"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug St"));
            list.Add(new BookModel(counter++, "Clear Light"));
            list.Add(new BookModel(counter++, "Dream Yoga"));
            list.Add(new BookModel(counter++, "Bardo Yoga"));
            list.Add(new BookModel(counter++, "The 8 Stages of Dissolution"));
            list.Add(new BookModel(counter++, "Going Home"));
            list.Add(new BookModel(counter++, "Phowa"));
            list.Add(new BookModel(counter++, "Phowa 2"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "You Are Never Alone"));
            list.Add(new BookModel(counter++, "You are never alone 1"));
            list.Add(new BookModel(counter++, "Board Of Directors"));
            list.Add(new BookModel(counter++, "Funny Story"));
            list.Add(new BookModel(counter++, "Symbolism of the Chakrasamvara"));
            list.Add(new BookModel(counter++, "What is"));
            list.Add(new BookModel(counter++, "From Darkness To Light"));
            list.Add(new BookModel(counter++, "The Golden Rule"));
            list.Add(new BookModel(counter++, "Lao-Tzu"));
            list.Add(new BookModel(counter++, "The Christ"));
            list.Add(new BookModel(counter++, "Hidden Puzzles"));
            list.Add(new BookModel(counter++, "Spiritual Life Is The Most Practical"));
            list.Add(new BookModel(counter++, "Smart Cookies"));
            list.Add(new BookModel(counter++, "Narrow Thinking"));
            list.Add(new BookModel(counter++, "Food is your best medicine"));
            list.Add(new BookModel(counter++, "Count your blessings"));
            list.Add(new BookModel(counter++, "Microscope VS Telescope"));
            list.Add(new BookModel(counter++, "Droplets of love"));
            list.Add(new BookModel(counter++, "Relax"));
            list.Add(new BookModel(counter++, "Grace"));
            list.Add(new BookModel(counter++, "Duty VS Consumer"));
            list.Add(new BookModel(counter++, "Find your refuge within"));
            list.Add(new BookModel(counter++, "The warranty of your inner car"));
            list.Add(new BookModel(counter++, "Worship"));
            list.Add(new BookModel(counter++, "The Fool"));
            list.Add(new BookModel(counter++, "The Inner Gurus"));
            list.Add(new BookModel(counter++, "Stoking The Fire"));
            list.Add(new BookModel(counter++, "Just One Step Away"));
            list.Add(new BookModel(counter++, "A Kinder World"));
            list.Add(new BookModel(counter++, "Time"));
            list.Add(new BookModel(counter++, "Make This World A Better Place"));
            list.Add(new BookModel(counter++, "Empty Space"));
            list.Add(new BookModel(counter++, "Mad At The World"));
            list.Add(new BookModel(counter++, "Emptiness And The Quantum Field"));
            list.Add(new BookModel(counter++, "Maya"));
            list.Add(new BookModel(counter++, "How To BE Light-Hearted"));
            list.Add(new BookModel(counter++, "Maya Deepfakes"));
            list.Add(new BookModel(counter++, "Row Row Row Your Boat"));
            list.Add(new BookModel(counter++, "The Sugar Cube"));
            list.Add(new BookModel(counter++, "Tune In To Kindness"));
            list.Add(new BookModel(counter++, "Adios Senor"));
            list.Add(new BookModel(counter++, "Rocket Man"));
            list.Add(new BookModel(counter++, "Alchemy At Its Fines"));
            list.Add(new BookModel(counter++, "I Love To Write"));
            list.Add(new BookModel(counter++, "Buenos Dias"));
            list.Add(new BookModel(counter++, "Down The Rabbit Hole"));
            list.Add(new BookModel(counter++, "House Of The Future"));
            list.Add(new BookModel(counter++, "Receiving Knowledge"));
            list.Add(new BookModel(counter++, "Surfing"));
            list.Add(new BookModel(counter++, "Besty Topalion Poetry Assignment"));
            list.Add(new BookModel(counter++, "There is only one mind"));
            list.Add(new BookModel(counter++, "Holy Mole Chakras"));
            list.Add(new BookModel(counter++, "Supreme Bliss"));
            list.Add(new BookModel(counter++, "I Have A Knack For This"));
            list.Add(new BookModel(counter++, "The 8 Stages of Dissolution"));
            list.Add(new BookModel(counter++, "Stoking The Fire"));
            list.Add(new BookModel(counter++, "The mosquito itch"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysDragonsNaropa Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDragonsNaropa();
            }

            return _instance;
        }
    }
}