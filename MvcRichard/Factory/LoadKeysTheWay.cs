using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysTheWay
    {
        private static LoadKeysTheWay _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysTheWay()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "One"));
            list.Add(new BookModel(counter++, "Two"));
            list.Add(new BookModel(counter++, "Three"));
            list.Add(new BookModel(counter++, "Four"));
            list.Add(new BookModel(counter++, "Five"));
            list.Add(new BookModel(counter++, "Six"));
            list.Add(new BookModel(counter++, "Seven"));
            list.Add(new BookModel(counter++, "Eight"));
            list.Add(new BookModel(counter++, "Nine"));
            list.Add(new BookModel(counter++, "Ten"));
            list.Add(new BookModel(counter++, "Eleven"));
            list.Add(new BookModel(counter++, "Twelve"));
            list.Add(new BookModel(counter++, "Thirteen"));
            list.Add(new BookModel(counter++, "Fourteen"));
            list.Add(new BookModel(counter++, "Fifteen"));
            list.Add(new BookModel(counter++, "Sixteen"));
            list.Add(new BookModel(counter++, "Seventeen"));
            list.Add(new BookModel(counter++, "Eighteen"));
            list.Add(new BookModel(counter++, "Nineteen"));
            list.Add(new BookModel(counter++, "Twenty"));

            list.Add(new BookModel(counter++, "Twenty-One"));
            list.Add(new BookModel(counter++, "Twenty-Two"));
            list.Add(new BookModel(counter++, "Twenty-Three"));
            list.Add(new BookModel(counter++, "Twenty-Four"));
            list.Add(new BookModel(counter++, "Twenty-Five"));
            list.Add(new BookModel(counter++, "Twenty-Six"));
            list.Add(new BookModel(counter++, "Twenty-Seven"));
            list.Add(new BookModel(counter++, "Twenty-Eight"));
            list.Add(new BookModel(counter++, "Twenty-Nine"));

            list.Add(new BookModel(counter++, "Thirty"));
            list.Add(new BookModel(counter++, "Thirty-One"));
            list.Add(new BookModel(counter++, "Thirty-Two"));
            list.Add(new BookModel(counter++, "Thirty-Three"));
            list.Add(new BookModel(counter++, "Thirty-Four"));
            list.Add(new BookModel(counter++, "Thirty-Five"));
            list.Add(new BookModel(counter++, "Thirty-Six"));
            list.Add(new BookModel(counter++, "Thirty-Seven"));
            list.Add(new BookModel(counter++, "Thirty-Eight"));
            list.Add(new BookModel(counter++, "Thirty-Nine"));

            list.Add(new BookModel(counter++, "Forty"));
            list.Add(new BookModel(counter++, "Forty-One"));
            list.Add(new BookModel(counter++, "Forty-Two"));
            list.Add(new BookModel(counter++, "Forty-Three"));
            list.Add(new BookModel(counter++, "Forty-Four"));
            list.Add(new BookModel(counter++, "Forty-Five"));
            list.Add(new BookModel(counter++, "Forty-Six"));
            list.Add(new BookModel(counter++, "Forty-Seven"));
            list.Add(new BookModel(counter++, "Forty-Eight"));
            list.Add(new BookModel(counter++, "Forty-Nine"));

            list.Add(new BookModel(counter++, "Fifty"));
            list.Add(new BookModel(counter++, "Fifty-One"));
            list.Add(new BookModel(counter++, "Fifty-Two"));
            list.Add(new BookModel(counter++, "Fifty-Three"));
            list.Add(new BookModel(counter++, "Fifty-Four"));
            list.Add(new BookModel(counter++, "Fifty-Five"));
            list.Add(new BookModel(counter++, "Fifty-Six"));
            list.Add(new BookModel(counter++, "Fifty-Seven"));
            list.Add(new BookModel(counter++, "Fifty-Eight"));
            list.Add(new BookModel(counter++, "Fifty-Nine"));

            list.Add(new BookModel(counter++, "Sixty"));
            list.Add(new BookModel(counter++, "Sixty-One"));
            list.Add(new BookModel(counter++, "Sixty-Two"));
            list.Add(new BookModel(counter++, "Sixty-Three"));
            list.Add(new BookModel(counter++, "Sixty-Four"));
            list.Add(new BookModel(counter++, "Sixty-Five"));
            list.Add(new BookModel(counter++, "Sixty-Six"));
            list.Add(new BookModel(counter++, "Sixty-Seven"));
            list.Add(new BookModel(counter++, "Sixty-Eight"));
            list.Add(new BookModel(counter++, "Sixty-Nine"));

            list.Add(new BookModel(counter++, "Seventy"));
            list.Add(new BookModel(counter++, "Seventy-One"));
            list.Add(new BookModel(counter++, "Seventy-Two"));
            list.Add(new BookModel(counter++, "Seventy-Three"));
            list.Add(new BookModel(counter++, "Seventy-Four"));
            list.Add(new BookModel(counter++, "Seventy-Five"));
            list.Add(new BookModel(counter++, "Seventy-Six"));
            list.Add(new BookModel(counter++, "Seventy-Seven"));
            list.Add(new BookModel(counter++, "Seventy-Eight"));
            list.Add(new BookModel(counter++, "Seventy-Nine"));

            list.Add(new BookModel(counter++, "Eighty"));
            list.Add(new BookModel(counter++, "Eighty-One"));




        }

        public static LoadKeysTheWay Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysTheWay();
            }

            return _instance;
        }
    }
}