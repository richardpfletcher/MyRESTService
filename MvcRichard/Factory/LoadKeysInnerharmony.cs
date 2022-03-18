using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysInnerharmony
    {
        private static LoadKeysInnerharmony _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysInnerharmony()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Fractal Fairy Tales"));
            list.Add(new BookModel(counter++, "Family and Friends"));
            list.Add(new BookModel(counter++, "Dragons Tales"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));
            list.Add(new BookModel(counter++, "Keys to Life"));
            list.Add(new BookModel(counter++, "Swan Tales"));
            list.Add(new BookModel(counter++, "The Journey"));
            list.Add(new BookModel(counter++, "From Me To We"));
            list.Add(new BookModel(counter++, "Kindness"));
            list.Add(new BookModel(counter++, "Gaia"));
            list.Add(new BookModel(counter++, "The Inner Garden"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Surfing Tales"));
            list.Add(new BookModel(counter++, "Happiness"));
            list.Add(new BookModel(counter++, "Conscious Politics"));
            list.Add(new BookModel(counter++, "Life and Death"));
            list.Add(new BookModel(counter++, "The New Human"));
            list.Add(new BookModel(counter++, "You Are Hardwired To Discover God"));
            list.Add(new BookModel(counter++, "How To Use The Quantum Field"));
            list.Add(new BookModel(counter++, "How to manifest your dreams"));
            list.Add(new BookModel(counter++, "Cloudy Thinking"));
            list.Add(new BookModel(counter++, "Over the hill Not"));
            list.Add(new BookModel(counter++, "Super Bowl"));
            list.Add(new BookModel(counter++, "Corona"));
            list.Add(new BookModel(counter++, "The Way"));
            list.Add(new BookModel(counter++, "Heart of Gold"));
            list.Add(new BookModel(counter++, "The Creative Project"));
            list.Add(new BookModel(counter++, "Patanjali Yoga Sutras"));
            list.Add(new BookModel(counter++, "Non-violence"));
            list.Add(new BookModel(counter++, "Know thy self"));
            list.Add(new BookModel(counter++, "Who am I"));
            list.Add(new BookModel(counter++, "Tricks Of The Trade"));
            list.Add(new BookModel(counter++, "Shamanism"));
            list.Add(new BookModel(counter++, "Storytelling"));
            list.Add(new BookModel(counter++, "The Physics of Spirituality"));
            list.Add(new BookModel(counter++, "The Kingdom Of Heaven Lies Inside"));
            list.Add(new BookModel(counter++, "Pandora's box"));
            list.Add(new BookModel(counter++, "Diary of a Cabbalistic"));
            list.Add(new BookModel(counter++, "Jai Jinendra"));
            list.Add(new BookModel(counter++, "Harmony"));
            list.Add(new BookModel(counter++, "Broken Record"));
            list.Add(new BookModel(counter++, "Mystical Adventures"));
            list.Add(new BookModel(counter++, "Conscious Economics"));
            list.Add(new BookModel(counter++, "Dreamtime"));
            list.Add(new BookModel(counter++, "Rumi"));
            list.Add(new BookModel(counter++, "Recalibration"));
            list.Add(new BookModel(counter++, "You are your own master chemist"));
            list.Add(new BookModel(counter++, "Sound Of Silence"));
            list.Add(new BookModel(counter++, "Knowledge"));
            list.Add(new BookModel(counter++, "Six Yogas of Naropa"));
            list.Add(new BookModel(counter++, "What Me Worryl"));
            list.Add(new BookModel(counter++, "Dog training for the mind"));
            list.Add(new BookModel(counter++, "Naropa Commentary"));
            list.Add(new BookModel(counter++, "Alchemy"));
            list.Add(new BookModel(counter++, "Teachings Of The Dragons Naropa"));
            list.Add(new BookModel(counter++, "This is just the start of your training"));
            list.Add(new BookModel(counter++, "Esoteric Treasures"));
            list.Add(new BookModel(counter++, "Puzzle"));
            list.Add(new BookModel(counter++, "War"));




        }

        public static LoadKeysInnerharmony Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysInnerharmony();
            }

            return _instance;
        }
    }
}