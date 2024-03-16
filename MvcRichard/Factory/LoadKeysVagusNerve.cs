using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysVagusNerve
    {
        private static LoadKeysVagusNerve _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysVagusNerve()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
           
            list.Add(new BookModel(counter++, "Once Upon a Nerve"));
            list.Add(new BookModel(counter++, "The Amazing Journey of the Vagus Nerve"));
            list.Add(new BookModel(counter++, "The Autonomic Nervous System."));
            list.Add(new BookModel(counter++, "The Vagus Nerve Heart's Best Buddy"));
            list.Add(new BookModel(counter++, "The Vagus Nerve and Our Amazing Heart"));
            list.Add(new BookModel(counter++, "Breathing Patterns and Vagal Tone"));
            list.Add(new BookModel(counter++, "The Vagus Nerve and the Happy Thoughts Festival"));
            list.Add(new BookModel(counter++, "The Vagus Nerve's Fun Workout"));
            list.Add(new BookModel(counter++, "The Vagus Nerve and the Happy Messengers"));
            list.Add(new BookModel(counter++, "Vagus Nerve Helpers at the Doctor's Office"));
            list.Add(new BookModel(counter++, "The Vagus Nerve and the Happy Tummy Adventure"));
            list.Add(new BookModel(counter++, "The Superhero Vagus Nerve and the Inflammation Adventure"));
            list.Add(new BookModel(counter++, "The Vagus Nerve's Dreamy Sleep Adventure"));
            list.Add(new BookModel(counter++, "The Vagus Nerve's Quest Against Sneaky Villains"));
            list.Add(new BookModel(counter++, "The Exciting Adventures Ahead for Vagus Nerve Explorers"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza's Insightful Journey into the Vagus Nerve Wonderlandl"));
            list.Add(new BookModel(counter++, "The Vagus Nerve and the Harmony of Taoist Inner Alchemy"));
            list.Add(new BookModel(counter++, "Harmonizing the Vagus Nerve with the Ancient Wisdom of the 6 Yogas of Naropa"));
            list.Add(new BookModel(counter++, "The Vagus Nerve's Serpentine Dance in Kundalini Yoga"));
            list.Add(new BookModel(counter++, "The Harmonious Dance of the Vagus Nerve and Chakra Energy"));
            list.Add(new BookModel(counter++, "The Harmonious Dance of the Vagus, Ida, and Pingala Nerves."));
            list.Add(new BookModel(counter++, "Qi Gong's Dance with the Vagus Nerve Harmony"));
            list.Add(new BookModel(counter++, "Tai Chi's Graceful Dance with the Vagus Nerve"));
            list.Add(new BookModel(counter++, "The Harmonious Dance of the Vagus Nerve in Chinese Medicine"));
            list.Add(new BookModel(counter++, "The Harmonious Dance of the Vagus Nerve and the Microcosmic Orbit"));
            list.Add(new BookModel(counter++, "Adam Mizner's Martial Arts Harmony with the Vagus Nerve"));
            list.Add(new BookModel(counter++, "Damo Mitchell's Wisdom Navigating the Vagus Nerve Pathways"));
            list.Add(new BookModel(counter++, "Mantak Chia's Taoist Wisdom Navigating the Vagus Nerve Pathways"));
            list.Add(new BookModel(counter++, "Hatha Yoga's Dance with the Vagus Nerve Symphony"));
            list.Add(new BookModel(counter++, "The Vagus Nerve and the Enigmatic Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "Vagus Nerve Harmony and the Dance of Wu Wei"));
            list.Add(new BookModel(counter++, "Modern-Day Stress and the Vagus Nerve Symphony"));
            list.Add(new BookModel(counter++, "Culinary Harmony Nourishing the Vagus Nerve"));
            list.Add(new BookModel(counter++, "Ramana Maharshi The Silent Sage"));
            list.Add(new BookModel(counter++, "What is the connection between the vagus nerve and Amrita Nadi"));
            list.Add(new BookModel(counter++, "Closing"));

        }

        public static LoadKeysVagusNerve Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysVagusNerve();
            }

            return _instance;
        }
    }
}