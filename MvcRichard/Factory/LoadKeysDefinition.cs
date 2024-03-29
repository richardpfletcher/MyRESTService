﻿using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDefinition
    {
        private static LoadKeysDefinition _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDefinition()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Dear Old Alfred"));
            list.Add(new BookModel(counter++, "Stupid Is Is What Stupid Does"));
            list.Add(new BookModel(counter++, "Transform"));
            list.Add(new BookModel(counter++, "Management"));
            list.Add(new BookModel(counter++, "Honor"));
            list.Add(new BookModel(counter++, "Surprise"));
            list.Add(new BookModel(counter++, "Greetings"));
            list.Add(new BookModel(counter++, "Equanimity"));
            list.Add(new BookModel(counter++, "Avarice"));
            list.Add(new BookModel(counter++, "Obstacles"));
            list.Add(new BookModel(counter++, "Reciprocity"));
            list.Add(new BookModel(counter++, "Listening"));
            list.Add(new BookModel(counter++, "Barriers"));
            list.Add(new BookModel(counter++, "Hope"));
            list.Add(new BookModel(counter++, "Uplift"));
            list.Add(new BookModel(counter++, "Harmony"));
            list.Add(new BookModel(counter++, "Unity"));
            list.Add(new BookModel(counter++, "Aloha"));
            list.Add(new BookModel(counter++, "Hobby"));
            list.Add(new BookModel(counter++, "Preventive"));
            list.Add(new BookModel(counter++, "Wisdom"));
            list.Add(new BookModel(counter++, "Praise"));
            list.Add(new BookModel(counter++, "Grace"));
            list.Add(new BookModel(counter++, "Reverence"));
            list.Add(new BookModel(counter++, "Ignorance"));
            list.Add(new BookModel(counter++, "Infinity"));
            list.Add(new BookModel(counter++, "Inspiration"));
            list.Add(new BookModel(counter++, "Apathy"));
            list.Add(new BookModel(counter++, "Intuition"));
            list.Add(new BookModel(counter++, "Gratitude"));
            list.Add(new BookModel(counter++, "The Inner Guru"));
            list.Add(new BookModel(counter++, "Synchronicity"));
            list.Add(new BookModel(counter++, "Infinite"));
            list.Add(new BookModel(counter++, "Adapt"));
            list.Add(new BookModel(counter++, "Adventure"));
            list.Add(new BookModel(counter++, "Keep Your Honor"));
            list.Add(new BookModel(counter++, "Generator, Operator, Destroyer"));
            list.Add(new BookModel(counter++, "Forgive"));
            list.Add(new BookModel(counter++, "Ego"));
            list.Add(new BookModel(counter++, "Intention"));
            list.Add(new BookModel(counter++, "Contact"));
            list.Add(new BookModel(counter++, "Feeling"));
            list.Add(new BookModel(counter++, "Aspiration"));
            list.Add(new BookModel(counter++, "Resolve"));
            list.Add(new BookModel(counter++, "Shame"));
            list.Add(new BookModel(counter++, "Consideration"));
            list.Add(new BookModel(counter++, "Non-hatred"));
            list.Add(new BookModel(counter++, "Non-ignorance"));
            list.Add(new BookModel(counter++, "Diligence"));
            list.Add(new BookModel(counter++, "Pliancy"));
            list.Add(new BookModel(counter++, "Conscientiousness"));
            list.Add(new BookModel(counter++, "Non-harmfulness"));
            list.Add(new BookModel(counter++, "Aggression"));
            list.Add(new BookModel(counter++, "Vindictiveness"));
            list.Add(new BookModel(counter++, "Concealment"));
            list.Add(new BookModel(counter++, "Spite"));
            list.Add(new BookModel(counter++, "Jealousy"));
            list.Add(new BookModel(counter++, "Miserliness"));
            list.Add(new BookModel(counter++, "Pretension"));
            list.Add(new BookModel(counter++, "Haughtiness"));
            list.Add(new BookModel(counter++, "Harmfulness"));
            list.Add(new BookModel(counter++, "Shamelessness"));
            list.Add(new BookModel(counter++, "Dullness"));
            list.Add(new BookModel(counter++, "Afflictive"));
            list.Add(new BookModel(counter++, "Non - faith"));
            list.Add(new BookModel(counter++, "Forgetfulness"));
            list.Add(new BookModel(counter++, "Laziness"));
            list.Add(new BookModel(counter++, "Non-conscientiousness"));
            list.Add(new BookModel(counter++, "Distraction"));
            list.Add(new BookModel(counter++, "Regret"));
            list.Add(new BookModel(counter++, "Investigation"));
            list.Add(new BookModel(counter++, "Analysis"));



        }

        public static LoadKeysDefinition Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDefinition();
            }

            return _instance;
        }
    }
}