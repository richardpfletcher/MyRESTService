using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysFamilyCooking 
    {
        private static LoadKeysFamilyCooking  _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysFamilyCooking ()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            

        }

        public static LoadKeysFamilyCooking  Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysFamilyCooking ();
            }

            return _instance;
        }
    }
}