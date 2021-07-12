using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysKnowledge
    {
        private static LoadKeysKnowledge _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysKnowledge()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Prophesy"));
            list.Add(new BookModel(counter++, "05 - 02 - 2021 One Thing Leads To Another"));
            list.Add(new BookModel(counter++, "Craig Perkins"));
            list.Add(new BookModel(counter++, "Surfing Experience In France"));
            list.Add(new BookModel(counter++, "Initiation"));
            list.Add(new BookModel(counter++, "Asokananda Incident"));
            list.Add(new BookModel(counter++, "Zambia"));
            list.Add(new BookModel(counter++, "South Africa"));
            list.Add(new BookModel(counter++, "Chris Parker"));
            list.Add(new BookModel(counter++, "Back To The States"));
            list.Add(new BookModel(counter++, "Spaced Out"));
            list.Add(new BookModel(counter++, "Meditation 10 Hours A Day"));
            list.Add(new BookModel(counter++, "Katharita Parsons Lamoza"));
            list.Add(new BookModel(counter++, "Kali Rodriguez"));
            list.Add(new BookModel(counter++, "Kathleen Cook"));
            list.Add(new BookModel(counter++, "David Humphrey"));
            list.Add(new BookModel(counter++, "John Roberts"));
            list.Add(new BookModel(counter++, "John Slowsky"));
            list.Add(new BookModel(counter++, "Joe Lopez"));
            list.Add(new BookModel(counter++, "Mark and Geraldine"));
            list.Add(new BookModel(counter++, "My First Girl Friend"));
            list.Add(new BookModel(counter++, "Mahatma Rajeshwar"));
            list.Add(new BookModel(counter++, "RIP Bihari Singh"));
            list.Add(new BookModel(counter++, "More Spiritual Friends"));
            list.Add(new BookModel(counter++, "NY Friends"));
            list.Add(new BookModel(counter++, "Buffalo Friends"));
            list.Add(new BookModel(counter++, "South Florida Friends"));
            list.Add(new BookModel(counter++, "John Baier"));
            list.Add(new BookModel(counter++, "David Schweizer"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "Paul Mcclain"));
            list.Add(new BookModel(counter++, "Layla Masant"));
            list.Add(new BookModel(counter++, "Richie RIP"));
            list.Add(new BookModel(counter++, "More South Florida Friends"));
            list.Add(new BookModel(counter++, "Phone Book Friends"));
            list.Add(new BookModel(counter++, "Phone Book Friends 2"));
            list.Add(new BookModel(counter++, "Mentors"));
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
            list.Add(new BookModel(counter++, "Donn and Richard - How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "Donn and Richard - The World Is a Drama"));
            list.Add(new BookModel(counter++, "Donn and Richard - Sailing"));
            list.Add(new BookModel(counter++, "Donn and Richard - Meditation"));
            list.Add(new BookModel(counter++, "Donn and Richard - He Who Says Doesn't Know"));
            list.Add(new BookModel(counter++, "Donn and Richard - As A Man Of Forty"));
            list.Add(new BookModel(counter++, "Donn and Richard - Stairway Of Life"));
            list.Add(new BookModel(counter++, "Donn and Richard - Focus"));
            list.Add(new BookModel(counter++, "Donn and Richard - Serenity"));
            list.Add(new BookModel(counter++, "Donn and Richard - Forgive"));
            list.Add(new BookModel(counter++, "Donn and Richard - Nothing To Prove"));
            list.Add(new BookModel(counter++, "Donn and Richard - 3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Steven Soffer-when is one plus one only one"));
            list.Add(new BookModel(counter++, "Steven Soffer-love is like a fox"));
            list.Add(new BookModel(counter++, "Steven Soffer-have you had an accident"));
            list.Add(new BookModel(counter++, "Steven Soffer-do you know HIS number"));
            list.Add(new BookModel(counter++, "Steven Soffer-does HE talk to you"));
            list.Add(new BookModel(counter++, "Steven Soffer-have you been struck by cupids arrows"));
            list.Add(new BookModel(counter++, "Steven Soffer-have you flown His magic carpet"));
            list.Add(new BookModel(counter++, "Steven Soffer-its so easy to fall in love"));
            list.Add(new BookModel(counter++, "Steven Soffer-listen do you want to know a secret"));
            list.Add(new BookModel(counter++, "Steven Soffer-Are you finally ready to play divine hide and seek"));
            list.Add(new BookModel(counter++, "Steven Soffer-do you want to go to eternities garden"));
            list.Add(new BookModel(counter++, "Steven Soffer-i hear thunder"));
            list.Add(new BookModel(counter++, "Steven Soffer-a flute divine plays within"));
            list.Add(new BookModel(counter++, "Charles R Beresford-Charlie The Dragon"));
            list.Add(new BookModel(counter++, "Charles R Beresford-WHERE ARE YOU GOING"));



        }

            public static LoadKeysKnowledge Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysKnowledge();
            }

            return _instance;
        }
    }
}