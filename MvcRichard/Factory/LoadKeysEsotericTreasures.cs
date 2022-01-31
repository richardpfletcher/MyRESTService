using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysEsotericTreasures
    {
        private static LoadKeysEsotericTreasures _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysEsotericTreasures()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "Your Treasure Chest"));
            list.Add(new BookModel(counter++, "The Esoteric Breath"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "The Video game of life"));
            list.Add(new BookModel(counter++, "Breath By Breath"));
            list.Add(new BookModel(counter++, "The Breath"));
            list.Add(new BookModel(counter++, "Breathing Through Your Mouth"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Pratyāhāra withdrawing of the external senses"));
            list.Add(new BookModel(counter++, "You Are Your Own Doctor"));
            list.Add(new BookModel(counter++, "The Esoteric Body"));
            list.Add(new BookModel(counter++, "Holy Mole Chakras"));
            list.Add(new BookModel(counter++, "Taking Care Of Your Body"));
            list.Add(new BookModel(counter++, "State Of Mind"));
            list.Add(new BookModel(counter++, "Gathering Wisdom"));
            list.Add(new BookModel(counter++, "Being Grandparents"));
            list.Add(new BookModel(counter++, "Keep Your Smile"));
            list.Add(new BookModel(counter++, "Don’t Take Life So Seriously"));
            list.Add(new BookModel(counter++, "How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "The Word"));
            list.Add(new BookModel(counter++, "Religions"));
            list.Add(new BookModel(counter++, "The World Is a Drama"));
            list.Add(new BookModel(counter++, "Is This From A Mystic Or A Sceintist"));
            list.Add(new BookModel(counter++, "Can’t Go Back To Sleep"));
            list.Add(new BookModel(counter++, "Spiritual Life Is Not Boring"));
            list.Add(new BookModel(counter++, "What Is Panpsychism"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "Custom Designed By God"));
            list.Add(new BookModel(counter++, "Custom Designed By God 2"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Constant Meditation"));
            list.Add(new BookModel(counter++, "Sitting Down Meditation"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Tip Of The Iceberg"));
            list.Add(new BookModel(counter++, "Closing"));









        }

        public static LoadKeysEsotericTreasures Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysEsotericTreasures();
            }

            return _instance;
        }
    }
}