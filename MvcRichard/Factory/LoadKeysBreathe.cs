using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysBreathe
    {
        private static LoadKeysBreathe _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysBreathe()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "your-next-breath"));
            list.Add(new BookModel(counter++, "Surfing"));
            list.Add(new BookModel(counter++, "My Father Teaching Us Exercises"));
            list.Add(new BookModel(counter++, "High School"));
            list.Add(new BookModel(counter++, "05-02-2021 One Thing Leads To Another"));
            list.Add(new BookModel(counter++, "My first two books"));
            list.Add(new BookModel(counter++, "18 TRAVEL AROUND THE WORD"));
            list.Add(new BookModel(counter++, "Surfing Experience In France"));
            list.Add(new BookModel(counter++, "Indian Pakistan War"));
            list.Add(new BookModel(counter++, "First Day In India"));
            list.Add(new BookModel(counter++, "Initiation"));
            list.Add(new BookModel(counter++, "Mediation Ganges"));
            list.Add(new BookModel(counter++, "Finding Bombay Ashram"));
            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Just breathe"));
            list.Add(new BookModel(counter++, "Galileo's Telescope Instrumental"));
            list.Add(new BookModel(counter++, "quantum-breathing."));
            list.Add(new BookModel(counter++, "Conscious versus unconscious breathing"));
            list.Add(new BookModel(counter++, "The Owners Manual"));
            list.Add(new BookModel(counter++, "Eight limbs on the tree of life"));
            list.Add(new BookModel(counter++, "How Do I Meditate"));
            list.Add(new BookModel(counter++, "Consciousness"));
            list.Add(new BookModel(counter++, "5-12-2017"));
            list.Add(new BookModel(counter++, "Breathing Through Your Mouth"));
            list.Add(new BookModel(counter++, "Breathe"));
            list.Add(new BookModel(counter++, "Why do I Meditate"));
            list.Add(new BookModel(counter++, "Always On Inside Of You"));
            list.Add(new BookModel(counter++, "Last Breath I"));
            list.Add(new BookModel(counter++, "Occam's razor"));
            list.Add(new BookModel(counter++, "Different Perspectives"));
            list.Add(new BookModel(counter++, "Kingdom of heaven lies within"));
            list.Add(new BookModel(counter++, "The Way"));
            list.Add(new BookModel(counter++, "Dream Time"));
            list.Add(new BookModel(counter++, "Runi"));
            list.Add(new BookModel(counter++, "Keys to life"));
            list.Add(new BookModel(counter++, "Tummo-and-tantra"));
            list.Add(new BookModel(counter++, "The Physics of Spirituality"));
            list.Add(new BookModel(counter++, "Kabblah"));
            list.Add(new BookModel(counter++, "Shamanism"));
            list.Add(new BookModel(counter++, "Intro SuperBowl"));
            list.Add(new BookModel(counter++, "Long story short"));
            list.Add(new BookModel(counter++, "The Word"));



        }

        public static LoadKeysBreathe Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysBreathe();
            }

            return _instance;
        }
    }
}