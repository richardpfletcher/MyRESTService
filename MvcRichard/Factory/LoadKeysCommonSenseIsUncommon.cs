using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysCommonSenseIsUncommon
    {
        private static LoadKeysCommonSenseIsUncommon _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysCommonSenseIsUncommon()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Embracing the Present"));
            list.Add(new BookModel(counter++, "Mastering the Tools of the Mind"));
            list.Add(new BookModel(counter++, "The Weight of Yesterday and Tomorrow"));
            list.Add(new BookModel(counter++, "Breaking Free from the Past and Future"));
            list.Add(new BookModel(counter++, "The Path to Happiness Embracing the Present Moment"));
            list.Add(new BookModel(counter++, "Embracing Life's Flow Living in the Present Moment"));
            list.Add(new BookModel(counter++, "The Neglected Art Why the Present Moment is Often Overlooked"));
            list.Add(new BookModel(counter++, "The Awakening to Presence"));
            list.Add(new BookModel(counter++, "Overcome the obstacles to living in the present moment"));
            list.Add(new BookModel(counter++, "Pay attention"));
            list.Add(new BookModel(counter++, "Gently bring your focus back"));
            list.Add(new BookModel(counter++, "Limit distractions"));
            list.Add(new BookModel(counter++, "Watch your thoughts and feelings"));
            list.Add(new BookModel(counter++, "Be patient with yourself"));
            list.Add(new BookModel(counter++, "Find joy in each moment."));
            list.Add(new BookModel(counter++, "Use your senses."));
            list.Add(new BookModel(counter++, "See change as positive"));
            list.Add(new BookModel(counter++, "Know your triggers"));
            list.Add(new BookModel(counter++, "Practice as much as you can"));
            list.Add(new BookModel(counter++, "The Same Breath"));
            list.Add(new BookModel(counter++, "Befriending The Moment"));
            list.Add(new BookModel(counter++, "The Superiority Complex"));
            list.Add(new BookModel(counter++, "Quieting the Noise."));
            list.Add(new BookModel(counter++, "Setting Boundaries"));
            list.Add(new BookModel(counter++, "How to stop complaining"));
            list.Add(new BookModel(counter++, "Awareness, Not Thinking"));
            list.Add(new BookModel(counter++, "Shadow Work"));
            list.Add(new BookModel(counter++, "Embracing Our Shadow"));
            list.Add(new BookModel(counter++, "Your Inner Chemistry"));
            list.Add(new BookModel(counter++, "Your Inner Pharmacy"));
            list.Add(new BookModel(counter++, "Meditation - Your Inner Pharmacy"));
            list.Add(new BookModel(counter++, "Don't Stuff Your Feelings"));
            list.Add(new BookModel(counter++, "holeness Over Perfection"));
            list.Add(new BookModel(counter++, "This Moment is All There Is"));
            list.Add(new BookModel(counter++, "Ego vs The Now"));
            list.Add(new BookModel(counter++, "Defining Yourself"));
            list.Add(new BookModel(counter++, "Living Outside of Time"));
            list.Add(new BookModel(counter++, "Beyond Body and Mind"));
            list.Add(new BookModel(counter++, "Befriending Difficult Emotions"));
            list.Add(new BookModel(counter++, "Preserving Your Peace"));
            list.Add(new BookModel(counter++, "Handling Toxic People"));
            list.Add(new BookModel(counter++, "Forgiveness"));
            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "Comparison The Power of Now and the Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "The Frog in The Well"));
            list.Add(new BookModel(counter++, "The Frog in The Wel Commentary"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head Commentary"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant Commentary"));
            list.Add(new BookModel(counter++, "Planting The Seeds"));
            list.Add(new BookModel(counter++, "Planting The Seeds Commentary"));
            list.Add(new BookModel(counter++, "You Are The Universe"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysCommonSenseIsUncommon Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysCommonSenseIsUncommon();
            }

            return _instance;
        }
    }
}