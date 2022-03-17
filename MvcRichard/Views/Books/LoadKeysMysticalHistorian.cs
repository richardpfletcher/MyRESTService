using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMysticalHistorian
    {
        private static LoadKeysMysticalHistorian _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMysticalHistorian()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));






        }

        public static LoadKeysMysticalHistorian Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMysticalHistorian();
            }

            return _instance;
        }
    }
}