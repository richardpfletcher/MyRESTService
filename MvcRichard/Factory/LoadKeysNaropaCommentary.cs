using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysNaropaCommentary
    {
        private static LoadKeysNaropaCommentary _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysNaropaCommentary()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Secrecy"));
            list.Add(new BookModel(counter++, "Initiation, empowerment, and transmission"));
            list.Add(new BookModel(counter++, "The Ray Of Empowerment"));
            list.Add(new BookModel(counter++, "Homework"));
            list.Add(new BookModel(counter++, "Step 1 Breathing and Step 2 Cause and effect"));
            list.Add(new BookModel(counter++, "Step 3 Impermanence"));
            list.Add(new BookModel(counter++, "Step 4 interconnected"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Nerve cells that fire together wire together"));
            list.Add(new BookModel(counter++, "Nobody changes until you change your energy"));
            list.Add(new BookModel(counter++, "Your body is your subconscious mind"));
            list.Add(new BookModel(counter++, "Are you heading in the right direction"));
            list.Add(new BookModel(counter++, "The Law Of Cause And Effect"));
            list.Add(new BookModel(counter++, "The Ray Of Non-Attachment"));


        }

        public static LoadKeysNaropaCommentary Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysNaropaCommentary();
            }

            return _instance;
        }
    }
}