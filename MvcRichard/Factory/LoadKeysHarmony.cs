using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysHarmony
    {
        private static LoadKeysHarmony _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysHarmony()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Harmony"));

            
            list.Add(new BookModel(counter++, "Three"));
           
            list.Add(new BookModel(counter++, "Five"));
            
            list.Add(new BookModel(counter++, "Eight"));
            
            list.Add(new BookModel(counter++, "Ten"));
            
            list.Add(new BookModel(counter++, "Twelve"));
            
            list.Add(new BookModel(counter++, "Eighteen"));
            

            list.Add(new BookModel(counter++, "Twenty-One"));
            list.Add(new BookModel(counter++, "Twenty-Two"));
            list.Add(new BookModel(counter++, "Twenty-Three"));
            
            list.Add(new BookModel(counter++, "Twenty-Eight"));
            list.Add(new BookModel(counter++, "Twenty-Nine"));

            list.Add(new BookModel(counter++, "Thirty"));
            list.Add(new BookModel(counter++, "Thirty-One"));
           
            list.Add(new BookModel(counter++, "Thirty-Three"));
           
            list.Add(new BookModel(counter++, "Thirty-Six"));
            
            list.Add(new BookModel(counter++, "Thirty-Eight"));
            list.Add(new BookModel(counter++, "Thirty-Nine"));

            
            list.Add(new BookModel(counter++, "Forty-Two"));
           
            list.Add(new BookModel(counter++, "Forty-Six"));
            
            list.Add(new BookModel(counter++, "Fifty-Five"));
           
            list.Add(new BookModel(counter++, "Fifty-Eight"));
            

            list.Add(new BookModel(counter++, "Sixty"));
            list.Add(new BookModel(counter++, "Sixty-One"));
            list.Add(new BookModel(counter++, "Sixty-Two"));
            
            list.Add(new BookModel(counter++, "Sixty-Five"));
            list.Add(new BookModel(counter++, "Sixty-Six"));
            list.Add(new BookModel(counter++, "Sixty-Seven"));
            
            list.Add(new BookModel(counter++, "Seventy-One"));
            list.Add(new BookModel(counter++, "Seventy-Two"));
            list.Add(new BookModel(counter++, "Seventy-Three"));
            
            list.Add(new BookModel(counter++, "Seventy-Six"));
            list.Add(new BookModel(counter++, "Seventy-Seven"));
            list.Add(new BookModel(counter++, "Seventy-Eight"));
            list.Add(new BookModel(counter++, "Seventy-Nine"));

            list.Add(new BookModel(counter++, "Eighty"));
            list.Add(new BookModel(counter++, "Eighty-One"));


        }

        public static LoadKeysHarmony Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysHarmony();
            }

            return _instance;
        }
    }
}