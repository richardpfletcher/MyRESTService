using MvcRichard.Models;
using System.Collections.Generic;


namespace MvcRichard.Factory
{
    internal class LoadKeysSparkTales
    {
        private static LoadKeysSparkTales _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSparkTales()
        {
            int counter = 0;
            //talks


            
            list.Add(new BookModel(counter++, "Spark Tales-Intro"));

            list.Add(new BookModel(counter++, "Spark Tales-Buddha and the drunk elephant"));



            list.Add(new BookModel(counter++, "Spark Tales-The Golden Plate"));

            list.Add(new BookModel(counter++, "Spark Tales-Beauty and Grey"));

            list.Add(new BookModel(counter++, "Spark Tales-The Wind and the Moon"));

            list.Add(new BookModel(counter++, "Spark Tales-Two Stupid Children"));

            list.Add(new BookModel(counter++, "Spark Tales-The Tree That Acted Like a Hunter"));

            list.Add(new BookModel(counter++, "Spark Tales-The Magic Priest and the Kidnapper Gang"));

            list.Add(new BookModel(counter++, "Spark Tales-Watering the Garden"));

            list.Add(new BookModel(counter++, "Spark Tales-The Bull Called Delightful"));

            list.Add(new BookModel(counter++, "Spark Tales-Buried Treasure"));

            list.Add(new BookModel(counter++, "Spark Tales-The Birth of a Banyan Tree"));

            list.Add(new BookModel(counter++, "Spark Tales-The Fawn Who Played Hooky"));

            list.Add(new BookModel(counter++, "Spark Tales-Finding a New Spring"));

            list.Add(new BookModel(counter++, "Spark Tales-Best Friends"));

            list.Add(new BookModel(counter++, "Spark Tales-The Baby Quail Who Could Not Fly Away"));

            list.Add(new BookModel(counter++, "Spark Tales-The Mouse Merchant"));

            list.Add(new BookModel(counter++, "Spark Tales-The Fortunate Fish"));

            list.Add(new BookModel(counter++, "Spark Tales-Bamboo's Father"));

            list.Add(new BookModel(counter++, "Spark Tales-Big Red, Little Red and No - squeal"));

            list.Add(new BookModel(counter++, "Spark Tales-Salty Liquor"));

            list.Add(new BookModel(counter++, "Spark Tales-Little Prince No - father"));

            list.Add(new BookModel(counter++, "Spark Tales-The Silent Buddha"));

            list.Add(new BookModel(counter++, "Spark Tales-Demons in the Desert"));

            list.Add(new BookModel(counter++, "Spark Tales-The Jeweler And The Thief"));

            list.Add(new BookModel(counter++, "Spark Tales-The Fight of Two Wolves Within You"));

            list.Add(new BookModel(counter++, "Spark Tales-Learning How To Ride A Bicycle"));

            list.Add(new BookModel(counter++, "Spark Tales-Follow The Recipe"));

            list.Add(new BookModel(counter++, "Spark Tales-The Frog in The Well"));

            list.Add(new BookModel(counter++, "Spark Tales-3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Spark Tales-Stop The Noise In Your Head"));

            list.Add(new BookModel(counter++, "Spark Tales-The Mirror"));

            list.Add(new BookModel(counter++, "Spark Tales-The Sun And The Wind"));

            list.Add(new BookModel(counter++, "Spark Tales-The Sun And Darkness"));

            list.Add(new BookModel(counter++, "Spark Tales-Dragons"));





        }

        public static LoadKeysSparkTales Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSparkTales();
            }

            return _instance;
        }
    }
}