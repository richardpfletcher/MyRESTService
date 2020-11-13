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
            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "The Essence Of The Kabbalah"));
            list.Add(new BookModel(counter++, "The Law Of Creation"));
            list.Add(new BookModel(counter++, "The Law Of Manifestation"));
            list.Add(new BookModel(counter++, "Barbara’s Divine Words"));
            list.Add(new BookModel(counter++, "The Law Of Prayer"));

            list.Add(new BookModel(counter++, "The Law Of Silence"));
            list.Add(new BookModel(counter++, "The Law Of Cause and Effect"));
            list.Add(new BookModel(counter++, "The Law Of Being"));
            list.Add(new BookModel(counter++, "The Ray Of Patience"));
            list.Add(new BookModel(counter++, "The Ray Of Compassion")); 
            list.Add(new BookModel(counter++, "The Ray Of Good-Natured")); 
            list.Add(new BookModel(counter++, "The Ray Of Tolerance"));
            list.Add(new BookModel(counter++, "The Ray Of Humbleness"));
            list.Add(new BookModel(counter++, "The Ray Of Honesty"));
            list.Add(new BookModel(counter++, "The Ray Of Sincerity"));
            list.Add(new BookModel(counter++, "The Ray Of Respect"));
            list.Add(new BookModel(counter++, "The Ray Of Forgiveness"));
            list.Add(new BookModel(counter++, "The Ray Of Bliss"));
            list.Add(new BookModel(counter++, "The Ray Of Love"));
            list.Add(new BookModel(counter++, "The Ray Of Mercy"));
            list.Add(new BookModel(counter++, "The Ray Of Modesty"));
            list.Add(new BookModel(counter++, "The Ray Of Passion"));
            list.Add(new BookModel(counter++, "The Ray Of Honor"));
            list.Add(new BookModel(counter++, "The Ray Of Charity")); 
            list.Add(new BookModel(counter++, "The Ray Of Acceptance"));

            list.Add(new BookModel(counter++, "The Ray Of Contentment"));
            list.Add(new BookModel(counter++, "The Ray Of Self Control"));
            list.Add(new BookModel(counter++, "The Ray Of Happiness"));
            list.Add(new BookModel(counter++, "The Ray Of Non-Attachment"));
            list.Add(new BookModel(counter++, "The Ray Of Empowerment"));
            list.Add(new BookModel(counter++, "Tree Of Life Prayer"));
            list.Add(new BookModel(counter++, "The Law Of Laughter"));
            list.Add(new BookModel(counter++, "The Law Of Giving and Receiving"));
            list.Add(new BookModel(counter++, "The Law Of Giving and Receiving 2"));
            list.Add(new BookModel(counter++, "The Four Noble Laws (Truths)"));
            list.Add(new BookModel(counter++, "The Law Of Prosperity and Abundance"));
            list.Add(new BookModel(counter++, "The Law Of Balance"));
            list.Add(new BookModel(counter++, "The Law Of Balance 2"));
            list.Add(new BookModel(counter++, "The Law Of Health"));
            list.Add(new BookModel(counter++, "The Law Of Rest"));
            list.Add(new BookModel(counter++, "The Law Of Enlightenment"));
            list.Add(new BookModel(counter++, "The Ox Parable"));

            list.Add(new BookModel(counter++, "The four conditions Of mind"));
            list.Add(new BookModel(counter++, "The Law Of Life and Death"));
            list.Add(new BookModel(counter++, "The Law Of Communication"));
            list.Add(new BookModel(counter++, "The Law Of Free Will"));
            list.Add(new BookModel(counter++, "The Law Of Unity"));
            list.Add(new BookModel(counter++, "The Law Of Kindness"));
            list.Add(new BookModel(counter++, "The Law Of Practice"));
            list.Add(new BookModel(counter++, "The Law Of Calibration"));
            list.Add(new BookModel(counter++, "The Law Of Intuition"));
            
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