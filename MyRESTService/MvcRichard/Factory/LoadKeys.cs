using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeys
    {
        private static LoadKeys _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeys()
        {
            int counter = 0;
            list.Add(new BookModel(counter++, "intro"));
            list.Add(new BookModel(counter++, "The Essence of the Kabbalah"));
            list.Add(new BookModel(counter++, "The Law of Creation"));
            list.Add(new BookModel(counter++, "The Law of Manifestation"));
            list.Add(new BookModel(counter++, "Barbara’s divine words"));
            list.Add(new BookModel(counter++, "The Law of Prayer"));

            list.Add(new BookModel(counter++, "The Law of Silence"));
            list.Add(new BookModel(counter++, "The Law of Cause and Effect"));
            list.Add(new BookModel(counter++, "The Law of Being"));
            list.Add(new BookModel(counter++, "The Ray of Patience"));
            list.Add(new BookModel(counter++, "The Ray of Compassion")); 
            list.Add(new BookModel(counter++, "The Ray of Good-Natured")); //not found
            list.Add(new BookModel(counter++, "The Ray of Tolerance"));
            list.Add(new BookModel(counter++, "The Ray of Humbleness"));
            list.Add(new BookModel(counter++, "The Ray of Honesty"));
            list.Add(new BookModel(counter++, "The Ray of Sincerity"));
            list.Add(new BookModel(counter++, "The Ray of Respect"));
            list.Add(new BookModel(counter++, "The Ray of Forgiveness"));
            list.Add(new BookModel(counter++, "The Ray of Bliss"));
            list.Add(new BookModel(counter++, "The Ray of Love"));
            list.Add(new BookModel(counter++, "The Ray of Mercy"));
            list.Add(new BookModel(counter++, "The Ray of Modesty"));
            list.Add(new BookModel(counter++, "The Ray of Passion"));
            list.Add(new BookModel(counter++, "The Ray of Honor"));
            list.Add(new BookModel(counter++, "The Ray of Charity")); 
            list.Add(new BookModel(counter++, "The Ray of Acceptance"));

            list.Add(new BookModel(counter++, "The Ray of Contentment"));
            list.Add(new BookModel(counter++, "The Ray of Self Control"));
            list.Add(new BookModel(counter++, "The Ray of Happiness"));
            list.Add(new BookModel(counter++, "The Ray of Non-Attachment"));
            list.Add(new BookModel(counter++, "The Ray of Empowerment"));
            list.Add(new BookModel(counter++, "Tree of Life Prayer"));
            list.Add(new BookModel(counter++, "The Law of Laughter"));
            list.Add(new BookModel(counter++, "The Law of Giving and Receiving"));
            list.Add(new BookModel(counter++, "The Law of Giving and Receiving 2"));
            list.Add(new BookModel(counter++, "The Four Noble Laws (Truths)"));
            list.Add(new BookModel(counter++, "The Law of Prosperity and Abundance"));
            list.Add(new BookModel(counter++, "The Law of Balance"));
            list.Add(new BookModel(counter++, "The Law of Balance 2"));
            list.Add(new BookModel(counter++, "The Law of Health"));
            list.Add(new BookModel(counter++, "The Law of Rest"));
            list.Add(new BookModel(counter++, "The Law of Enlightenment"));
            list.Add(new BookModel(counter++, "The Ox Parable"));

            list.Add(new BookModel(counter++, "The four conditions of mind"));
            list.Add(new BookModel(counter++, "The Law of Life and Death"));
            list.Add(new BookModel(counter++, "The Law of Communication"));
            list.Add(new BookModel(counter++, "The Law of Free Will"));
            list.Add(new BookModel(counter++, "The Law of Unity"));
            list.Add(new BookModel(counter++, "The Law of Kindness"));
            list.Add(new BookModel(counter++, "The Law of Practice"));
            list.Add(new BookModel(counter++, "The Law of Calibration"));
            list.Add(new BookModel(counter++, "The Law of Intuition"));
            
        }

        public static LoadKeys Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeys();
            }

            return _instance;
        }
    }
}