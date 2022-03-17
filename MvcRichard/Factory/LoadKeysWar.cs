using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysWar
    {
        private static LoadKeysWar _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysWar()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "02-26-2022 War"));
            list.Add(new BookModel(counter++, "02-28-2022 I need ammunition, not a ride"));
            list.Add(new BookModel(counter++, "Convoy 40 miles long"));
            list.Add(new BookModel(counter++, "A post from the Dalai Lama, Feb 28, 2022"));
            list.Add(new BookModel(counter++, "Get To The Point Instrumental"));
            list.Add(new BookModel(counter++, "Global Prosperity For All"));
            list.Add(new BookModel(counter++, "Glory To The Almighty"));
            list.Add(new BookModel(counter++, "North Korean Crisis"));
            list.Add(new BookModel(counter++, "Locked And Loaded"));
            list.Add(new BookModel(counter++, "God Willing"));
            list.Add(new BookModel(counter++, "God's Tricks"));
            list.Add(new BookModel(counter++, "Got To Change Our Crazy World"));
            list.Add(new BookModel(counter++, "Charlottesville"));
            list.Add(new BookModel(counter++, "Wisdom"));
            list.Add(new BookModel(counter++, "Give Peace A Chance"));
            list.Add(new BookModel(counter++, "How To Stop Wars"));
            list.Add(new BookModel(counter++, "Be Practical"));
            list.Add(new BookModel(counter++, "Be Quiet"));
            list.Add(new BookModel(counter++, "Just Come Back Home"));
            list.Add(new BookModel(counter++, "Still Alive"));
            list.Add(new BookModel(counter++, "Sweet Dreams"));
            list.Add(new BookModel(counter++, "Taken Away By Love"));
            list.Add(new BookModel(counter++, "War Games"));
            list.Add(new BookModel(counter++, "Aggression"));
            list.Add(new BookModel(counter++, "Peace"));
            list.Add(new BookModel(counter++, "Peace on earth"));
            list.Add(new BookModel(counter++, "Balance is the key to life"));
            list.Add(new BookModel(counter++, "Life is a game"));
            list.Add(new BookModel(counter++, "From Me To We"));
            list.Add(new BookModel(counter++, "Thirty"));
            list.Add(new BookModel(counter++, "Thirty - one"));
            list.Add(new BookModel(counter++, "Pollyanna"));
            list.Add(new BookModel(counter++, "Improved Darkness"));
            list.Add(new BookModel(counter++, "Misfits"));
            list.Add(new BookModel(counter++, "Atrocity Of Atrocities"));
            list.Add(new BookModel(counter++, "Butterfly Creating A Hurricane"));
            list.Add(new BookModel(counter++, "You Have Nothing To Lose"));
            list.Add(new BookModel(counter++, "The choice is ours"));
            list.Add(new BookModel(counter++, "Strength"));
            list.Add(new BookModel(counter++, "Take off your mask"));
            list.Add(new BookModel(counter++, "Cut The Tapes"));
            list.Add(new BookModel(counter++, "The Lantern"));
            list.Add(new BookModel(counter++, "The new dawning of man"));
            list.Add(new BookModel(counter++, "Mothers"));
            list.Add(new BookModel(counter++, "Got To Tell You"));
            list.Add(new BookModel(counter++, "The New Human In Society"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));
            list.Add(new BookModel(counter++, "One Million Years From Now"));
            list.Add(new BookModel(counter++, "Ten Million Years From Now"));
            list.Add(new BookModel(counter++, "I Feel So Much Love"));
            list.Add(new BookModel(counter++, "Think Outside Of The Box"));
            list.Add(new BookModel(counter++, "Signposts Are All Around"));
            list.Add(new BookModel(counter++, "Hungry For The Kil"));
            list.Add(new BookModel(counter++, "Your actions change the universe"));
            list.Add(new BookModel(counter++, "It’s Time For A New Act"));
            list.Add(new BookModel(counter++, "Balance The Ego"));
            list.Add(new BookModel(counter++, "4-28-2018 chicken"));
            list.Add(new BookModel(counter++, "The Rapture"));
            list.Add(new BookModel(counter++, "Closing"));








        }

        public static LoadKeysWar Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysWar();
            }

            return _instance;
        }
    }
}