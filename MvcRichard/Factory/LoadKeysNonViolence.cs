using MvcRichard.Models;
using System.Collections.Generic;


namespace MvcRichard.Factory
{
    internal class LoadKeysNonViolence
    {
        private static LoadKeysNonViolence _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysNonViolence()
        {
            int counter = 0;
            //talks

           

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Jainism Mahavira quotes"));
            list.Add(new BookModel(counter++, "Fourteen Video Game Stages Of Spiritual Development"));
            list.Add(new BookModel(counter++, "Video game of life"));
            list.Add(new BookModel(counter++, "Jain ethics and five vows"));
            list.Add(new BookModel(counter++, "Sat Chit Ananda"));
            list.Add(new BookModel(counter++, "Violence in our leaders"));
            list.Add(new BookModel(counter++, "Did Jainism Help Shape the American Civil Rights Movement"));
            list.Add(new BookModel(counter++, "My Trip to the Land of Gandhi"));
            list.Add(new BookModel(counter++, "My Trip to the Land of Gandhi 2"));
            list.Add(new BookModel(counter++, "Non-violence in protests"));
            list.Add(new BookModel(counter++, "Non-violence in schools"));
            list.Add(new BookModel(counter++, "Non-violence in relationships"));
            list.Add(new BookModel(counter++, "Non-violence in your mind and body"));
            list.Add(new BookModel(counter++, "Emotions"));
            list.Add(new BookModel(counter++, "New Thought"));
            list.Add(new BookModel(counter++, "New Concepts"));
            list.Add(new BookModel(counter++, "New Wiring"));
            list.Add(new BookModel(counter++, "New Personality"));
            list.Add(new BookModel(counter++, "New Human"));
            list.Add(new BookModel(counter++, "You Are Closer Than You Think"));
            list.Add(new BookModel(counter++, "Non-violence in media"));
            list.Add(new BookModel(counter++, "The Drama Queen"));
            list.Add(new BookModel(counter++, "Non-violence in Politics"));
            list.Add(new BookModel(counter++, "Non-violence in economy"));
            list.Add(new BookModel(counter++, "Non-violence in personal beliefs"));
            list.Add(new BookModel(counter++, "Non-violence in diet"));
            list.Add(new BookModel(counter++, "Jain Meditation Old School"));
            list.Add(new BookModel(counter++, "Preksha Meditation"));
            list.Add(new BookModel(counter++, "Perception Of Breathing"));
            list.Add(new BookModel(counter++, "Perception Of Alternate Breathing"));
            list.Add(new BookModel(counter++, "Perception Of Alternate Breathing Exercise"));
            list.Add(new BookModel(counter++, "The Kayotsarga"));
            list.Add(new BookModel(counter++, "Pindāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Padāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Rūpāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Rūpātita Dhyāna"));
            list.Add(new BookModel(counter++, "The Spiritual Elevation And Salvation Of The Soul"));
            list.Add(new BookModel(counter++, "Jain Meditation New School"));
            list.Add(new BookModel(counter++, "Relaxation"));
            list.Add(new BookModel(counter++, "Internal Journey"));
            list.Add(new BookModel(counter++, "Modern day version"));
            list.Add(new BookModel(counter++, "Modern day version meditation"));
            list.Add(new BookModel(counter++, "Perception of Breathing New"));
            list.Add(new BookModel(counter++, "SOHUM"));
            list.Add(new BookModel(counter++, "Om Meditation"));
            list.Add(new BookModel(counter++, "Perception of Breathing New"));
            list.Add(new BookModel(counter++, "How To Do Alternate Nostril Breathing(Nadi Shodhana)"));
            list.Add(new BookModel(counter++, "The Breath"));
            list.Add(new BookModel(counter++, "Breathing Through Your Mouth"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Monitoring Your Thoughts And Emotions"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "Chakras"));
            list.Add(new BookModel(counter++, "Endocrine System"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysNonViolence Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysNonViolence();
            }

            return _instance;
        }
    }
}