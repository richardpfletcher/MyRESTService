using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysParadoxes
    {
        private static LoadKeysParadoxes _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysParadoxes()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "How did this book come about"));
            list.Add(new BookModel(counter++, "Zen and Paradoxes"));
            list.Add(new BookModel(counter++, "Push and pull How the Milky Way flies"));
            list.Add(new BookModel(counter++, "Zen Kōans Learning to Live with Ambiguity and Paradox"));
            list.Add(new BookModel(counter++, "Find the Wisdom in Paradox"));
            list.Add(new BookModel(counter++, "What Are The Paradoxes In Quantum Mechanics"));
            list.Add(new BookModel(counter++, "20 Paradoxes That Give Us Wisdom and Perspective"));
            list.Add(new BookModel(counter++, "13 Paradoxes You Can Use To Improve Your Life Today"));
            list.Add(new BookModel(counter++, "What Is A Paradox 1"));
            list.Add(new BookModel(counter++, "Is A Paradox"));
            list.Add(new BookModel(counter++, "What Is A Paradox 3"));
            list.Add(new BookModel(counter++, "Paradox"));
            list.Add(new BookModel(counter++, "Is Buddhism paradoxical"));
            list.Add(new BookModel(counter++, "Paradoxes in Buddhism"));
            list.Add(new BookModel(counter++, "The Taoist Secret Of Embracing Paradoxes Of Life"));
            list.Add(new BookModel(counter++, "Even lao tzu walked away"));
            list.Add(new BookModel(counter++, "A SPIRITUAL PARADOX JAINISM AND THE ARMY"));
            list.Add(new BookModel(counter++, "Conscientiousness"));
            list.Add(new BookModel(counter++, "Sudoku"));
            list.Add(new BookModel(counter++, "I’m astonished"));
            list.Add(new BookModel(counter++, "Silence Is Your Friend Or Foe"));
            list.Add(new BookModel(counter++, "God Speaks Thru Silence"));
            list.Add(new BookModel(counter++, "Earth’s Quietest Place Will Drive You Crazy in 45 Minutes"));
            list.Add(new BookModel(counter++, "not - so - fast"));
            list.Add(new BookModel(counter++, "lies lies lies"));
            list.Add(new BookModel(counter++, "Cosmic Movie"));
            list.Add(new BookModel(counter++, "You are eternal"));
            list.Add(new BookModel(counter++, "The journey in life can be quite bumpy"));
            list.Add(new BookModel(counter++, "Paradox Conscious versus unconscious breathing"));
            list.Add(new BookModel(counter++, "Homework in Finland School"));
            list.Add(new BookModel(counter++, "The 3 Paradoxes of Life"));
            list.Add(new BookModel(counter++, "The surf industry paradox"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysParadoxes Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysParadoxes();
            }

            return _instance;
        }
    }
}