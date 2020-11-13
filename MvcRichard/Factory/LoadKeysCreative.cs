using MvcRichard.Models;
using System.Collections.Generic;


namespace MvcRichard.Factory
{
    internal class LoadKeysCreative
    {
        private static LoadKeysCreative _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysCreative()
        {
            int counter = 0;
            //talks

           
            list.Add(new BookModel(counter++, "05-11-2020 Creative Project"));
            list.Add(new BookModel(counter++, "Paula Jensen-Henny The Lucky Penny"));
            list.Add(new BookModel(counter++, "Paula Jensen-Receipe for Friendship"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - One God"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Cosmic Travelers"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Never Give Up Hope"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Nobody Truly Wins a War"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Visitor"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Timeless"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Being Old"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - I Feel So Good When I Feel Love"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Angels Fallen From Heaven"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - In a Day of Lovers"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Sea of Mercy"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - Rumi I am the Soul"));
            list.Add(new BookModel(counter++, "John Franklin Fletcher - If Superman Was A Man"));
            list.Add(new BookModel(counter++, "Donn and Richard-How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "Donn and Richard-The World Is a Drama"));
            list.Add(new BookModel(counter++, "Donn and Richard-Sailing"));
            list.Add(new BookModel(counter++, "Donn and Richard-Meditation"));
            list.Add(new BookModel(counter++, "Donn and Richard-He Who Says Doesn't Know"));
            list.Add(new BookModel(counter++, "Donn and Richard-As A Man Of Forty"));
            list.Add(new BookModel(counter++, "Donn and Richard-Stairway Of Life"));
            list.Add(new BookModel(counter++, "Donn and Richard-Life Is A Garland"));
            list.Add(new BookModel(counter++, "Donn and Richard-Focus"));
            list.Add(new BookModel(counter++, "Donn and Richard-Serenity"));
            list.Add(new BookModel(counter++, "Donn and Richard-Forgive"));
            list.Add(new BookModel(counter++, "Donn and Richard-Nothing To Prove"));
            list.Add(new BookModel(counter++, "Donn and Richard-3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Brad Schultz-All-is-One-1"));
            list.Add(new BookModel(counter++, "House Of The Future"));
            list.Add(new BookModel(counter++, "Nick Roth"));
            list.Add(new BookModel(counter++, "My High School Poetry Teacher"));
            list.Add(new BookModel(counter++, "Betty Topalion Poetry Assignment"));
            list.Add(new BookModel(counter++, "David Humphrey"));
            list.Add(new BookModel(counter++, "John Slowsky"));
            list.Add(new BookModel(counter++, "David Gelfand"));
            list.Add(new BookModel(counter++, "Joe Lopez"));
            list.Add(new BookModel(counter++, "Katharita Parsons Lamoza"));
            list.Add(new BookModel(counter++, "John Baier"));
            list.Add(new BookModel(counter++, "David Schweizer"));
            list.Add(new BookModel(counter++, "PAUL Mcclain"));
            list.Add(new BookModel(counter++, "Ancestors"));
            list.Add(new BookModel(counter++, "Leilani And Family"));
            list.Add(new BookModel(counter++, "My Sister Jane"));
            list.Add(new BookModel(counter++, "My Brother David And His Family"));
            list.Add(new BookModel(counter++, "My Twin Brother"));
            list.Add(new BookModel(counter++, "My Twin Brother John And His Family"));
            list.Add(new BookModel(counter++, "Glen & Elaine"));
            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 4"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 5"));
            list.Add(new BookModel(counter++, "Charles R Beresford-WHERE ARE YOU GOING"));
            list.Add(new BookModel(counter++, "Charles R Beresford-Charlie The Dragon"));
            list.Add(new BookModel(counter++, "Ram Das-Quotes 1"));
            list.Add(new BookModel(counter++, "Ram Das-Quotes 2"));
            list.Add(new BookModel(counter++, "Scott Schaefer Mom and Dad"));
            list.Add(new BookModel(counter++, "Steven Soffer-when is one plus one only one"));
            list.Add(new BookModel(counter++, "Steven Soffer-love is like a fox"));
            list.Add(new BookModel(counter++, "Steven Soffer-listen do you want to know a secret"));
            list.Add(new BookModel(counter++, "Steven Soffer-just a note"));
            list.Add(new BookModel(counter++, "Steven Soffer-its so easy to fall in love"));
            list.Add(new BookModel(counter++, "Steven Soffer-i hear thunder"));
            list.Add(new BookModel(counter++, "Steven Soffer-have you had an accident"));
            list.Add(new BookModel(counter++, "Steven Soffer-have you flown His magic carpet"));
            list.Add(new BookModel(counter++, "Steven Soffer-have you been struck by cupids arrows"));
            list.Add(new BookModel(counter++, "Steven Soffer-does HE talk to you"));
            list.Add(new BookModel(counter++, "Steven Soffer-do you want to go to eternities garden"));
            list.Add(new BookModel(counter++, "Steven Soffer-do you know HIS number"));
            list.Add(new BookModel(counter++, "Steven Soffer-Are you finally ready to play divine hide and seek"));
            list.Add(new BookModel(counter++, "Steven Soffer-a flute divine plays within"));





        }

            public static LoadKeysCreative Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysCreative();
            }

            return _instance;
        }
    }
}