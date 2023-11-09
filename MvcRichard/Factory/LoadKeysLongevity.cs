using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysLongevity
    {
        private static LoadKeysLongevity _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysLongevity()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "The concept of longevity"));
            list.Add(new BookModel(counter++, "Inner Harmony"));
            list.Add(new BookModel(counter++, "David Sinclair and his work on longevity"));
            list.Add(new BookModel(counter++, "Aging is a disease"));
            list.Add(new BookModel(counter++, "The Secret of the Golden Flower and longevity 2"));
            list.Add(new BookModel(counter++, "Ultra-processed foods can shorten lifespan"));
            list.Add(new BookModel(counter++, "Latest scientific research on longevity and the East"));
            list.Add(new BookModel(counter++, "Ageism is one of the last socially acceptable prejudices"));
            list.Add(new BookModel(counter++, "Ageism is a type of bias based on a person’s age"));
            list.Add(new BookModel(counter++, "Ageism can take many forms"));
            list.Add(new BookModel(counter++, "Longevity and the microbiome"));
            list.Add(new BookModel(counter++, "Longevity and telomeres"));
            list.Add(new BookModel(counter++, "Epigenetics and Bruce Lipton"));
            list.Add(new BookModel(counter++, "The biology of belief"));
            list.Add(new BookModel(counter++, "The current state of research on epigenetics"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza and the Quest for Longevity"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza and The Mind-Body Connection"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza and Meditation for Longevity"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza and the Role of Epigenetics"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza, Visualization, and Affirmations"));
            list.Add(new BookModel(counter++, "Dr. Joe Dispenza and Lifestyle for Longevity"));
            list.Add(new BookModel(counter++, "Joe Dispenza research with University Of San Diego"));
            list.Add(new BookModel(counter++, "Food that lower blood pressure"));
            list.Add(new BookModel(counter++, "Foods that raise blood pressure"));
            list.Add(new BookModel(counter++, "Gregg Braden and longevity"));
            list.Add(new BookModel(counter++, "Gregg Braden and AI"));
            list.Add(new BookModel(counter++, "The Six Yogas of Naropa and Longevity"));
            list.Add(new BookModel(counter++, "Taoism and longevity"));
            list.Add(new BookModel(counter++, "Sleep and A Trillion Times Bliss"));
            list.Add(new BookModel(counter++, "Importance of sleep"));
            list.Add(new BookModel(counter++, "The Power of Fasting"));
            list.Add(new BookModel(counter++, "Niacin"));
            list.Add(new BookModel(counter++, "Biofeedback"));
            list.Add(new BookModel(counter++, "Best herbs for lower blood pressure"));
            list.Add(new BookModel(counter++, "Yoga is a great way to lower your blood pressure naturally"));
            list.Add(new BookModel(counter++, "Best sleeping position for lowering blood pressure"));
            list.Add(new BookModel(counter++, "Yogic breathing techniques for lowering blood pressure"));
            list.Add(new BookModel(counter++, "Foods that are relatively high in sodium content"));
            list.Add(new BookModel(counter++, "List of snacks that contain high sodium"));
            list.Add(new BookModel(counter++, "The nitric oxide 4 minute exercise created by Dr. Zach Bush"));
            list.Add(new BookModel(counter++, "Football Aikido"));
            list.Add(new BookModel(counter++, "Going Vegan"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Anger And Brain Waves"));
            list.Add(new BookModel(counter++, "Sleep"));
            list.Add(new BookModel(counter++, "Cold Water Therapy"));
            list.Add(new BookModel(counter++, "Injuries"));
            list.Add(new BookModel(counter++, "Hatha Yoga"));
            list.Add(new BookModel(counter++, "Chi Gong"));
            list.Add(new BookModel(counter++, "David The Dragon"));
            list.Add(new BookModel(counter++, "Monitoring Your Thoughts And Emotions"));
            list.Add(new BookModel(counter++, "Nutritional psychiatry"));
            list.Add(new BookModel(counter++, "Sarah and Walking meditation"));
            list.Add(new BookModel(counter++, "As Sarah continued to walk mindfully"));
            list.Add(new BookModel(counter++, "Sarah was fascinated by the idea that what she ate could affect her mental health"));
            list.Add(new BookModel(counter++, "Sleep Sara"));
            list.Add(new BookModel(counter++, "Bugs Bunny"));
            list.Add(new BookModel(counter++, "Power of now"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysLongevity Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysLongevity();
            }

            return _instance;
        }
    }
}