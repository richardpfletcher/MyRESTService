using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDraconis
    {
        private static LoadKeysDraconis _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDraconis()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Kids"));
            list.Add(new BookModel(counter++, "Kids Dragon tales"));
            list.Add(new BookModel(counter++, "Kids You are Stardust"));
            list.Add(new BookModel(counter++, "Kids Storytelling"));
            list.Add(new BookModel(counter++, "Kids Gaia"));
            list.Add(new BookModel(counter++, "Swan Tales"));
            list.Add(new BookModel(counter++, "From Me To We"));
            list.Add(new BookModel(counter++, "Kids Once upon a time"));
            list.Add(new BookModel(counter++, "Kids Zoran"));
            list.Add(new BookModel(counter++, "Pointers Keys to Life"));
            list.Add(new BookModel(counter++, "The Journey"));
            list.Add(new BookModel(counter++, "Cosmic Advice"));
            list.Add(new BookModel(counter++, "Pointers Monroe Institute"));
            list.Add(new BookModel(counter++, "Health"));
            list.Add(new BookModel(counter++, "Health Kindness"));
            list.Add(new BookModel(counter++, "Health The Inner Garden"));
            list.Add(new BookModel(counter++, "Health "));
            list.Add(new BookModel(counter++, "Health Happiness"));
            list.Add(new BookModel(counter++, "Health Life &Death"));
            list.Add(new BookModel(counter++, "The New Human"));
            list.Add(new BookModel(counter++, "You Are Hardwired To Discover God"));
            list.Add(new BookModel(counter++, "Health-how-to use - the - quantum - field"));
            list.Add(new BookModel(counter++, "Health-how-to-manifest-your-dreams"));
            list.Add(new BookModel(counter++, "Health Cloudy Thinking"));
            list.Add(new BookModel(counter++, "Over the hill Not"));
            list.Add(new BookModel(counter++, "Health Recalibrationl"));
            list.Add(new BookModel(counter++, "Health What the fu!!n"));
            list.Add(new BookModel(counter++, "Spirituality"));
            list.Add(new BookModel(counter++, "Spirituality The Way"));
            list.Add(new BookModel(counter++, "Patanjali Yoga Sutras"));
            list.Add(new BookModel(counter++, "Spirituality Heart of Gold"));
            list.Add(new BookModel(counter++, "Spirituality Shamanism"));
            list.Add(new BookModel(counter++, "spirituality The Kingdom Of Heaven Lies Inside"));
            list.Add(new BookModel(counter++, "Spirituality Diary of a Cabbalistic"));
            list.Add(new BookModel(counter++, "Spirituality Knowledge"));
            list.Add(new BookModel(counter++, "Spirituality Dreamtime"));
            list.Add(new BookModel(counter++, "Spirituality Rumi"));
list.Add(new BookModel(counter++, "Spirituality Know thy self"));
            list.Add(new BookModel(counter++, "Spirituality Who am I"));
            list.Add(new BookModel(counter++, "Spirituality The Physics of Spirituality"));
            list.Add(new BookModel(counter++, "Spirituality Tricks Of The Trade"));
            list.Add(new BookModel(counter++, "Buddhis"));
            list.Add(new BookModel(counter++, "Buddhis Six Yogas of Naropa"));
            list.Add(new BookModel(counter++, "Buddhis Teachings Of The Dragons Naropa Part 2"));
            list.Add(new BookModel(counter++, "Buddhis This is just the start of your training"));
            list.Add(new BookModel(counter++, "Jainism"));
            list.Add(new BookModel(counter++, "Jainism Jai Jinendra"));
            list.Add(new BookModel(counter++, "Jainism Non-violence"));
            list.Add(new BookModel(counter++, "Jainism Paryushan 2022"));
            list.Add(new BookModel(counter++, "Jainism Six entities of the universe"));
            list.Add(new BookModel(counter++, "Jainism Sat Cjit Ananda"));
            list.Add(new BookModel(counter++, "Pondering"));
            list.Add(new BookModel(counter++, "Pondering Harmony"));
            list.Add(new BookModel(counter++, "Pondering Mystical Adventures"));
            list.Add(new BookModel(counter++, "Pondering You are your own master chemist"));
            list.Add(new BookModel(counter++, "Pondering Sound Of Silence"));
            list.Add(new BookModel(counter++, "Pondering What Me Worry"));
            list.Add(new BookModel(counter++, "Pondering Dog training for the mind"));
            list.Add(new BookModel(counter++, "Pondering Esoteric Treasures"));
            list.Add(new BookModel(counter++, "Pondering Puzzle"));
            list.Add(new BookModel(counter++, "Pondering Occam"));
            list.Add(new BookModel(counter++, "Current Events Conscious Politics"));
            list.Add(new BookModel(counter++, "Current Events Conscious Economics"));
            list.Add(new BookModel(counter++, "Current Events Pandora's box"));
            list.Add(new BookModel(counter++, "Current Events Super Bowl"));
            list.Add(new BookModel(counter++, "Current Events "));
list.Add(new BookModel(counter++, "Current Events Broken Record"));
            list.Add(new BookModel(counter++, "Current Events War"));
            list.Add(new BookModel(counter++, "Current Events Ancient Wisdom"));
            list.Add(new BookModel(counter++, "Current Events In the Web of Life, Jain Religion Reveres Even the Tiniest Forms"));
            list.Add(new BookModel(counter++, "Current Events Fourteen Video Game Stages Of Spiritual Development"));
            list.Add(new BookModel(counter++, "Current Events Video game of life"));
            list.Add(new BookModel(counter++, "Current Events Your Microbiome The Most Promising Facts"));
            list.Add(new BookModel(counter++, "Current Events Struggles"));
            list.Add(new BookModel(counter++, "Current Events Formation and Evolution of the Universe"));
            list.Add(new BookModel(counter++, "Current Nucleus The University Of Enlightenment"));
            list.Add(new BookModel(counter++, "Current Events You are the universe"));
            list.Add(new BookModel(counter++, "Family and Friends"));
            //list.Add(new BookModel(counter++, "Family Stories and Recipes"));
            list.Add(new BookModel(counter++, "Family The Creative Project"));
            list.Add(new BookModel(counter++, "Family Fractal Fairy Tales"));
            list.Add(new BookModel(counter++, "Closing Turn the computer on"));




        }

        public static LoadKeysDraconis Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDraconis();
            }

            return _instance;
        }
    }
}