using System;
using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysTraining
    {
        private static LoadKeysTraining _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysTraining()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "From me to we"));
            list.Add(new BookModel(counter++, "Zoran and the misfits"));
            list.Add(new BookModel(counter++, "The Word"));
            list.Add(new BookModel(counter++, "The palace in the sky"));
            list.Add(new BookModel(counter++, "Brahmanand-Palace in the sky"));
            list.Add(new BookModel(counter++, "Religions"));
            list.Add(new BookModel(counter++, "Pratyāhāra withdrawing of the external senses"));
            list.Add(new BookModel(counter++, "Pratyāhāra-Five Internal Senses"));
            list.Add(new BookModel(counter++, "Pratyāhāra Commentory"));
            list.Add(new BookModel(counter++, "Prānāyāma"));
            list.Add(new BookModel(counter++, "How To Do Alternate Nostril Breathing(Nadi Shodhana)"));
            list.Add(new BookModel(counter++, "Prānāyāma"));
            list.Add(new BookModel(counter++, "This Breath"));
            list.Add(new BookModel(counter++, "Breathing Through Your Mouth"));
            list.Add(new BookModel(counter++, "Prānāyāma-Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Prānāyāma Commentary"));
            list.Add(new BookModel(counter++, "The Golden Rule"));
            list.Add(new BookModel(counter++, "Lao-Tzu"));
            list.Add(new BookModel(counter++, "The Christ"));
            list.Add(new BookModel(counter++, "Let’s Have Fun"));
            list.Add(new BookModel(counter++, "Chakras"));
            list.Add(new BookModel(counter++, "Chakras Commentary"));
            list.Add(new BookModel(counter++, "Chakras Commentary 2"));
            list.Add(new BookModel(counter++, "Chakras data versus wisdom"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Endocrine System"));
            list.Add(new BookModel(counter++, "DNA"));
            list.Add(new BookModel(counter++, "Dragon History And Tummo"));
            list.Add(new BookModel(counter++, "Tummo and Tantra"));
            list.Add(new BookModel(counter++, "Dragon History And Tummo"));
            list.Add(new BookModel(counter++, "Tummo Commentary"));
            list.Add(new BookModel(counter++, "Illusory Body"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Clear Light"));
            list.Add(new BookModel(counter++, "Dream Yoga"));
            list.Add(new BookModel(counter++, "Bardo Yoga"));
            list.Add(new BookModel(counter++, "The 8 Stages of Dissolution"));
            list.Add(new BookModel(counter++, "Going Home"));
            list.Add(new BookModel(counter++, "Phowa"));
            list.Add(new BookModel(counter++, "Phowa 2"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "The Great White Brotherhood"));
            list.Add(new BookModel(counter++, "Cosmic Impact"));
            list.Add(new BookModel(counter++, "What Is Chakrasamvara Practice"));
            list.Add(new BookModel(counter++, "Why Should We Practice Tantra"));
            list.Add(new BookModel(counter++, "The Meaning of the Name Chakrasamvara"));
            list.Add(new BookModel(counter++, "The Textual Tradition"));
            list.Add(new BookModel(counter++, "Summary"));
            list.Add(new BookModel(counter++, "he Story of Chakrasamvara Subduing Shiva"));
            list.Add(new BookModel(counter++, "Feedback"));
            list.Add(new BookModel(counter++, "Gifts From the dragons"));


        }

        public static LoadKeysTraining Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysTraining();
            }

            return _instance;
        }
    }
}