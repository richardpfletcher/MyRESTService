using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysCommonSenseIsUncommon
    {
        private static LoadKeysCommonSenseIsUncommon _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysCommonSenseIsUncommon()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            
        }

        public static LoadKeysCommonSenseIsUncommon Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysCommonSenseIsUncommon();
            }

            return _instance;
        }
    }
}