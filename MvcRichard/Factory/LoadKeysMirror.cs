using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMirror
    {
        private static LoadKeysMirror _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMirror()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "Evolution revolution of love"));
            list.Add(new BookModel(counter++, "Gaia"));
            list.Add(new BookModel(counter++, "What is the power behind your breath"));
            list.Add(new BookModel(counter++, "Does the universe breathe"));
            list.Add(new BookModel(counter++, "Breath of Brahma"));
            list.Add(new BookModel(counter++, "How do Hindus relate to the breath of Brahma"));
            list.Add(new BookModel(counter++, "You are the universe you just don't know it"));
            list.Add(new BookModel(counter++, "You are your own chemistry set"));
            list.Add(new BookModel(counter++, "Where did yesterday go"));
            list.Add(new BookModel(counter++, "Beyond The Beyond"));
            list.Add(new BookModel(counter++, "You Don't Have To Live In Darkness"));
            list.Add(new BookModel(counter++, "Sleep"));
            list.Add(new BookModel(counter++, "Land Of Milk and Honey lies inside of you"));
            list.Add(new BookModel(counter++, "Is the West Coast dying"));
            list.Add(new BookModel(counter++, "6 Yogas of Naropa drops of nectar"));
            list.Add(new BookModel(counter++, "Brahmanand - Palace in the sky"));
            list.Add(new BookModel(counter++, "What is Khechari Mudra"));
            list.Add(new BookModel(counter++, "Oil of Christ"));
            list.Add(new BookModel(counter++, "RAISING THE CHRISM SANTA CLAUS"));
            list.Add(new BookModel(counter++, "Kingdom of heaven lies within"));
            list.Add(new BookModel(counter++, "Your Spirit Took Human "));
            list.Add(new BookModel(counter++, "Cosmic Advice"));
            list.Add(new BookModel(counter++, "Spinoza"));
            list.Add(new BookModel(counter++, "Central Sun"));
            list.Add(new BookModel(counter++, "War"));
            list.Add(new BookModel(counter++, "Alchemy"));
            list.Add(new BookModel(counter++, "Paryushan 2022"));
            list.Add(new BookModel(counter++, "Occam's razor"));
            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Bring The Genie Back Into The Bottle"));
            list.Add(new BookModel(counter++, "You are a piece of the puzzle in life"));
            list.Add(new BookModel(counter++, "Subtle body and its role in Tantric Buddhism"));
            list.Add(new BookModel(counter++, "Is the universe a sine wave"));
            list.Add(new BookModel(counter++, "Galileo's telescope"));
            list.Add(new BookModel(counter++, "Conscious economics"));
            list.Add(new BookModel(counter++, "Conscious politics"));
            list.Add(new BookModel(counter++, "Dog training for the mind"));
            list.Add(new BookModel(counter++, "What me worry"));
            list.Add(new BookModel(counter++, "The sound of inner silence"));
            list.Add(new BookModel(counter++, "You are your own master chemist"));
            list.Add(new BookModel(counter++, "Recalibration"));
            list.Add(new BookModel(counter++, "Rumi"));
            list.Add(new BookModel(counter++, "Aboriginal Dream Time"));
            list.Add(new BookModel(counter++, "Mystical Adventures"));
            list.Add(new BookModel(counter++, "Broken Record"));
            list.Add(new BookModel(counter++, "Jai Sat Chit Ananda"));
            list.Add(new BookModel(counter++, "David the Dragon"));
            list.Add(new BookModel(counter++, "Harmony"));
            list.Add(new BookModel(counter++, "Jai Jinendra"));
            list.Add(new BookModel(counter++, "Jataka Tales"));
            list.Add(new BookModel(counter++, "Pandora’s Box"));
            list.Add(new BookModel(counter++, "The Kingdom Of Heaven Lies Inside"));
            list.Add(new BookModel(counter++, "Shamanism"));
            list.Add(new BookModel(counter++, "Mystical Tricks Of The Trade"));
            list.Add(new BookModel(counter++, "Who Am I"));
            list.Add(new BookModel(counter++, "Know thy self"));
            list.Add(new BookModel(counter++, "Closing"));





        }

        public static LoadKeysMirror Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMirror();
            }

            return _instance;
        }
    }
}