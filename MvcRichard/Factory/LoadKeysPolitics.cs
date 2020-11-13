using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysPolitics
    {
        private static LoadKeysPolitics _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysPolitics()
        {
            int counter = 0;

            list.Add(new BookModel(counter++, "Intro"));

            
            list.Add(new BookModel(counter++, "4-29-2018  Korea"));
            list.Add(new BookModel(counter++, "11-03-2018"));
            list.Add(new BookModel(counter++, "11-04-2018 Refinement"));
            list.Add(new BookModel(counter++, "Campaign reform"));
            list.Add(new BookModel(counter++, "Charlottesville"));
            list.Add(new BookModel(counter++, "Christ And Politics"));
            list.Add(new BookModel(counter++, "Division"));
            list.Add(new BookModel(counter++, "Dragon Politics)"));
            list.Add(new BookModel(counter++, "Even Lao Tzu Walked Away"));

            list.Add(new BookModel(counter++, "Gandhi"));
            list.Add(new BookModel(counter++, "Got To Change Our Crazy World"));
            list.Add(new BookModel(counter++, "Has Politics Gone Astray"));
            list.Add(new BookModel(counter++, "How To Stop Wars"));
            list.Add(new BookModel(counter++, "Hungry For The Kill"));
            list.Add(new BookModel(counter++, "Hypocrisy"));
            list.Add(new BookModel(counter++, "I Don’t Care What You Think About Me"));
            list.Add(new BookModel(counter++, "I Don’t Want To Go To War Against You"));
            list.Add(new BookModel(counter++, "Immigration"));


            list.Add(new BookModel(counter++, "Jockey For Position"));
            list.Add(new BookModel(counter++, "Just Come Back Home"));
            list.Add(new BookModel(counter++, "Kindness In Politics"));
            list.Add(new BookModel(counter++, "Lack Of Kindness"));
            list.Add(new BookModel(counter++, "Locked And Loaded"));
            list.Add(new BookModel(counter++, "Martin Luther King"));
            list.Add(new BookModel(counter++, "Mothers"));
            list.Add(new BookModel(counter++, "New Zealand's PM Jacinda Ardern intro"));
            list.Add(new BookModel(counter++, "North Korean Crisis"));
            list.Add(new BookModel(counter++, "Not A Fan Of Trump"));
            list.Add(new BookModel(counter++, "Politics hold your emotions"));
            list.Add(new BookModel(counter++, "President Obama"));
            list.Add(new BookModel(counter++, "President"));
            list.Add(new BookModel(counter++, "Round Two)"));

            list.Add(new BookModel(counter++, "The drama queen"));
            list.Add(new BookModel(counter++, "The Election"));
            list.Add(new BookModel(counter++, "The hack"));
            list.Add(new BookModel(counter++, "The Wall"));
            list.Add(new BookModel(counter++, "World Politics"));


            
           
            
            
            
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

        public static LoadKeysPolitics Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysPolitics();
            }

            return _instance;
        }
    }
}