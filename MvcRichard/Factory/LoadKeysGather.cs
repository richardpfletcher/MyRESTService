using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysGather
    {
        private static LoadKeysGather _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysGather()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Where the Buffalo No Longer Roamed"));
            list.Add(new BookModel(counter++, "Gather’ Review The Struggle to Remain Sovereign"));
            list.Add(new BookModel(counter++, "Gather Centers Efforts to Heal and Rebuild"));
            list.Add(new BookModel(counter++, "FILMMAKER Q & A WITH SANJAY RAWAL"));
            list.Add(new BookModel(counter++, "Native American Food Sovereignty"));
            list.Add(new BookModel(counter++, "01-25-2020 The Wild "));
            list.Add(new BookModel(counter++, "Inside Outside"));
            list.Add(new BookModel(counter++, "Sound of the grass growing"));
            list.Add(new BookModel(counter++, "Dreaming ears dreaming eyes"));
            list.Add(new BookModel(counter++, "The farmers restoring Hawaii’s ancient food forests"));
            list.Add(new BookModel(counter++, "Restoring Hawaiian fishponds"));
            list.Add(new BookModel(counter++, "Restoring Community Health"));
            list.Add(new BookModel(counter++, "Restoring Our Limu Practices"));
            list.Add(new BookModel(counter++, "using modern technology to revive 2000-year-old fishponds"));
            list.Add(new BookModel(counter++, "Hawaii was once a local milk mecca"));
            list.Add(new BookModel(counter++, "One year after Native-owned Tanka Bar had lost nearly everything")); 
            list.Add(new BookModel(counter++, "The only catfish native to the Western U.S. is running out of water"));
            list.Add(new BookModel(counter++, "Millennials Moving Back To Roots Of Indian Cuisine"));
            list.Add(new BookModel(counter++, "Sustainable Food A return to the roots"));
            list.Add(new BookModel(counter++, "Western Diet A killer in Okinawa"));
            list.Add(new BookModel(counter++, "The Lost Soybeans of Okinawa"));
            list.Add(new BookModel(counter++, "Improving the Mexican diet"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysGather Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysGather();
            }

            return _instance;
        }
    }
}