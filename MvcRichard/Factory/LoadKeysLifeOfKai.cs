using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysLifeOfKai
    {
        private static LoadKeysLifeOfKai _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysLifeOfKai()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));



            list.Add(new BookModel(counter++, "Mystics and surfers"));
            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "Planting The Seeds"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Intuition"));
            list.Add(new BookModel(counter++, "Synchronicityl"));
            list.Add(new BookModel(counter++, "Synchronicit poem"));
            list.Add(new BookModel(counter++, "Paddling"));
            list.Add(new BookModel(counter++, "Quantum Field"));
            list.Add(new BookModel(counter++, "Patterns"));
            list.Add(new BookModel(counter++, "Conscious Chessboard"));
            list.Add(new BookModel(counter++, "Football Aikido"));
            list.Add(new BookModel(counter++, "Going Vegan"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "How Can a Fish Drown In Water"));
            list.Add(new BookModel(counter++, "Anger And Brain Waves"));
            list.Add(new BookModel(counter++, "Sleep"));
            list.Add(new BookModel(counter++, "Cold Water Therapy"));
            list.Add(new BookModel(counter++, "Injuries"));
            list.Add(new BookModel(counter++, "Hatha Yoga"));
            list.Add(new BookModel(counter++, "Chi Gong"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Miss You So Much! Instrumental"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "Focus"));
            list.Add(new BookModel(counter++, "Balance"));
            list.Add(new BookModel(counter++, "Wipeouts and the art of surrende"));
            list.Add(new BookModel(counter++, "11-28-2020 40 Days 40 Nights"));
            list.Add(new BookModel(counter++, "Teachers Pramilaji and Priyaji"));
            list.Add(new BookModel(counter++, "Prānāyāma"));
            list.Add(new BookModel(counter++, "Arugga Bohi Labham Meditation"));
            list.Add(new BookModel(counter++, "Asanas"));
            list.Add(new BookModel(counter++, "Arugga Bohi Labham Meditation"));
            list.Add(new BookModel(counter++, "Arugga Bohi Labham Chakras"));
            list.Add(new BookModel(counter++, "Arugga Bohi Acupressure"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Arugga Bohi Mantras"));
            list.Add(new BookModel(counter++, "Arugga Bohi Human Anatomy"));
            list.Add(new BookModel(counter++, "Arugga Bohi Seed Therapy"));
            list.Add(new BookModel(counter++, "Arugga Bohi Mudra Healing"));
            list.Add(new BookModel(counter++, "Arugga Bohi Rog Anusar Yoga"));
            list.Add(new BookModel(counter++, "Arugga Bohi Rog Saptu Dhatu 7 tissues"));
            list.Add(new BookModel(counter++, "Arugga Bohi Detox Diet and other"));
            list.Add(new BookModel(counter++, "Arugga Bohi Rog Ritu Charya Seasonings"));
            list.Add(new BookModel(counter++, "Tummo and Tantra"));





        }

        public static LoadKeysLifeOfKai Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysLifeOfKai();
            }

            return _instance;
        }
    }
}