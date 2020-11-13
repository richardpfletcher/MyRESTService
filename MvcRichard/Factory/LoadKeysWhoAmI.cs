using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysWhoAmI
    {
        private static LoadKeysWhoAmI _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysWhoAmI()
        {
            int counter = 0;
            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Mediation"));
            list.Add(new BookModel(counter++, "Who Were You Before You Were Born"));
            list.Add(new BookModel(counter++, "The Wheel Of Life"));
            list.Add(new BookModel(counter++, "You Are You Own Creator"));
            list.Add(new BookModel(counter++, "Cosmic Travelers"));
            list.Add(new BookModel(counter++, "Castles In The Sand"));
            list.Add(new BookModel(counter++, "If Death Approaches You"));
            list.Add(new BookModel(counter++, "Last Breath"));
            list.Add(new BookModel(counter++, "Temple Of God"));
            list.Add(new BookModel(counter++, "The Cosmic Merry Go Round"));
            list.Add(new BookModel(counter++, "Time Passes Every Breath"));
            list.Add(new BookModel(counter++, "We Are Made To Experience"));
            list.Add(new BookModel(counter++, "You Are Made Of The Same Stuff As the Universe"));
            list.Add(new BookModel(counter++, "Does Life Throw You A Curve Ball"));
            list.Add(new BookModel(counter++, "What A Magnificent Drop You Are"));
            list.Add(new BookModel(counter++, "Why do I Meditate"));
            list.Add(new BookModel(counter++, "We See Only 1 % Of The Light Spectrum"));
            list.Add(new BookModel(counter++, "Space Dust"));
            list.Add(new BookModel(counter++, "Agitated"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Apathy"));
            list.Add(new BookModel(counter++, "Intuition"));
            list.Add(new BookModel(counter++, "Fixity"));
            list.Add(new BookModel(counter++, "The Heart Of God"));
            list.Add(new BookModel(counter++, "The Mind Of God"));
            list.Add(new BookModel(counter++, "Slow Down"));
            list.Add(new BookModel(counter++, "The Path Is what You think It Is"));
            list.Add(new BookModel(counter++, "Occam's razor "));
            list.Add(new BookModel(counter++, "Relax Your Muscles Every Day"));
            list.Add(new BookModel(counter++, "Garbage Collector For The Mind"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));





        }

        public static LoadKeysWhoAmI Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysWhoAmI();
            }

            return _instance;
        }
    }
}