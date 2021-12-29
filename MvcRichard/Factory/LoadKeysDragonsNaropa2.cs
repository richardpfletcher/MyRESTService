using System;
using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDragonsNaropa2
    {
        private static LoadKeysDragonsNaropa2 _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDragonsNaropa2()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Little Ricky’s History Of The Dragons"));
            list.Add(new BookModel(counter++, "Initiation"));
            list.Add(new BookModel(counter++, "Mediation Ganges"));
            list.Add(new BookModel(counter++, "The palace in the sky"));
            list.Add(new BookModel(counter++, "Brahmanand-Palace in the sky"));
            list.Add(new BookModel(counter++, "Tulsidas-Glimpse Of The Invisible"));
            list.Add(new BookModel(counter++, "Brahmanand-the miracle"));
            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3"));
            list.Add(new BookModel(counter++, "Kabbalah"));
            list.Add(new BookModel(counter++, "Council Meetings"));
            list.Add(new BookModel(counter++, "Gifts Of The Spirit"));
            list.Add(new BookModel(counter++, "From Me To We"));
            list.Add(new BookModel(counter++, "Dragon Tales"));
            list.Add(new BookModel(counter++, "Dragon Tales 2"));
            list.Add(new BookModel(counter++, "Dragon Tales Commentary"));
            list.Add(new BookModel(counter++, "The Role of Dragons in Tibetan Culture and Faith"));
            list.Add(new BookModel(counter++, "Teachings Of The Dragons"));
            list.Add(new BookModel(counter++, "We all have friends that are with us"));
            list.Add(new BookModel(counter++, "Palden Lhamo"));
            list.Add(new BookModel(counter++, "Sri Ramakrishna on the Divine Mother"));
            list.Add(new BookModel(counter++, "What is empowerment"));
            list.Add(new BookModel(counter++, "Palden Lhamo Empowerment"));
            list.Add(new BookModel(counter++, "Tummo"));
            list.Add(new BookModel(counter++, "Tummo Commentary"));
            list.Add(new BookModel(counter++, "Phowa"));
            list.Add(new BookModel(counter++, "The 8 Stages of Dissolution"));
            list.Add(new BookModel(counter++, "Phowa Commentary"));
            list.Add(new BookModel(counter++, "Illusory Body"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Clear Light"));
            list.Add(new BookModel(counter++, "Dream Yoga"));
            list.Add(new BookModel(counter++, "Bardo Yoga"));






        }

        public static LoadKeysDragonsNaropa2 Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDragonsNaropa2();
            }

            return _instance;
        }
    }
}