using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysRecalibration
    {
        private static LoadKeysRecalibration _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysRecalibration()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));




            list.Add(new BookModel(counter++, "The Law Of Calibration"));



            list.Add(new BookModel(counter++, "Recalibration"));


            list.Add(new BookModel(counter++, "ur Education System Needs Recalibration"));

            list.Add(new BookModel(counter++, "Recalibration in Media"));

            list.Add(new BookModel(counter++, "Recalibration in Entertainment"));

            list.Add(new BookModel(counter++, "Recalibration in Entertainment 2"));

            list.Add(new BookModel(counter++, "Recalibration in Politics"));

            list.Add(new BookModel(counter++, "Recalibration in Society"));

            list.Add(new BookModel(counter++, "Recalibration in Sports"));

            list.Add(new BookModel(counter++, "Recalibration in Mind And Body"));

            list.Add(new BookModel(counter++, "Recalibration in Science and Inventions"));

            list.Add(new BookModel(counter++, "House Of The Future"));


            list.Add(new BookModel(counter++, "Recalibration in Thought"));

            list.Add(new BookModel(counter++, "Recalibration in Environment"));

            list.Add(new BookModel(counter++, "Recalibration in Nutrition"));

            list.Add(new BookModel(counter++, "Recalibration in Medicine"));

            list.Add(new BookModel(counter++, "Recalibration in Economics"));

            list.Add(new BookModel(counter++, "Recalibration in Housing"));

            list.Add(new BookModel(counter++, "Recalibration in Raising Kids"));

            list.Add(new BookModel(counter++, "Recalibration in Thinking"));

            list.Add(new BookModel(counter++, "Reset Button"));

            list.Add(new BookModel(counter++, "The Revolution Is Here"));

            list.Add(new BookModel(counter++, "The Wise Man Just Simply Smiles"));

            list.Add(new BookModel(counter++, "Fine Tune Your Life"));

            list.Add(new BookModel(counter++, "Little Drops Of Mercy"));

            list.Add(new BookModel(counter++, "You Are Your Own Doctor"));

            list.Add(new BookModel(counter++, "There Is A Point In Life"));

            list.Add(new BookModel(counter++, "The Struggle"));

            list.Add(new BookModel(counter++, "Your Treasure Chest"));

            list.Add(new BookModel(counter++, "We Are Wired For God"));

            list.Add(new BookModel(counter++, "Listen To Your Body"));

            list.Add(new BookModel(counter++, "Where Did Our Wisdom Go"));

            list.Add(new BookModel(counter++, "The Inner Scientist"));

            list.Add(new BookModel(counter++, "Just One More Book"));

            list.Add(new BookModel(counter++, "At the speed of light"));

            list.Add(new BookModel(counter++, "The engine of DNA"));
            list.Add(new BookModel(counter++, "The Tuning Fork Of Life"));

            list.Add(new BookModel(counter++, "No Free Rides"));




        }

        public static LoadKeysRecalibration Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysRecalibration();
            }

            return _instance;
        }
    }
}