using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysQuantumComputing
    {
        private static LoadKeysQuantumComputing _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysQuantumComputing()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Evolution revolution of love by chat openai"));
            list.Add(new BookModel(counter++, "House Of The Future"));
            list.Add(new BookModel(counter++, "Personal computer"));
            list.Add(new BookModel(counter++, "PARC"));
            list.Add(new BookModel(counter++, "Steve Jobs"));
            list.Add(new BookModel(counter++, "Adobe Inc"));
            list.Add(new BookModel(counter++, "The Kardashev Scale With Michio Kaku Can We Become a Type 1 Civilization"));
            list.Add(new BookModel(counter++, "Intro From Me to We"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));
            list.Add(new BookModel(counter++, "The Inner Garden"));
            list.Add(new BookModel(counter++, "meditation"));
            list.Add(new BookModel(counter++, "Life and Death"));
            list.Add(new BookModel(counter++, "The New Human"));
            list.Add(new BookModel(counter++, "You Are Hardwired To Discover God"));
            list.Add(new BookModel(counter++, "How To Use The Quantum Field"));
            list.Add(new BookModel(counter++, "How to manifest your dreams"));
            list.Add(new BookModel(counter++, "Cloudy Thinking"));
            list.Add(new BookModel(counter++, "Over the hill not"));
            list.Add(new BookModel(counter++, "Recalibration."));
            list.Add(new BookModel(counter++, "Keys to Life"));
            list.Add(new BookModel(counter++, "The Journey"));
            list.Add(new BookModel(counter++, "Cosmic Advice"));
            list.Add(new BookModel(counter++, "Breathe"));
            list.Add(new BookModel(counter++, "Dog training for the mind"));
            list.Add(new BookModel(counter++, "Alchemy"));
            list.Add(new BookModel(counter++, "Esoteric - treasures"));
            list.Add(new BookModel(counter++, "Puzzle"));
            list.Add(new BookModel(counter++, "Occam's razor"));
            list.Add(new BookModel(counter++, "Pandoras Box"));
            list.Add(new BookModel(counter++, "Broken Record"));
            list.Add(new BookModel(counter++, "War"));
            list.Add(new BookModel(counter++, "Draconis"));
            list.Add(new BookModel(counter++, "Land of milk and honey"));
            list.Add(new BookModel(counter++, "Is the West Coast dying"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "OnMaui"));
            list.Add(new BookModel(counter++, "Charles Schwab"));
            list.Add(new BookModel(counter++, "Plexis and Stillhead"));
            list.Add(new BookModel(counter++, "USDA RMA"));
            list.Add(new BookModel(counter++, "Heartland Crop Insurance"));
            list.Add(new BookModel(counter++, "USDA - Booz Allen"));
            list.Add(new BookModel(counter++, "whatscookingtreasures"));
            list.Add(new BookModel(counter++, "Getting Laid "));
            list.Add(new BookModel(counter++, "How quantum computing could transform everything everywhere"));
            list.Add(new BookModel(counter++, "In a Historic Milestone, Silicon Quantum Computing Just Exceeded 99 % Accuracy"));
            list.Add(new BookModel(counter++, "Quantum Computing – pros and cons"));
            list.Add(new BookModel(counter++, "Exploring the Potential Ethical Dilemmas of Quantum Computing"));
            list.Add(new BookModel(counter++, "Quantum Computing Scientists Call for Ethical Guidelines"));
            list.Add(new BookModel(counter++, "How Great Leaders Use the 100 - 0 Rule to Improve Engagement, Productivity, and Performance"));
            list.Add(new BookModel(counter++, "How Differently Would You Live If You Knew How to use this Power Gregg Braden"));
            list.Add(new BookModel(counter++, "Use Your Mind To HEAL THE BODY Boost Your IMMUNE SYSTEM Joe Dispenza Mark Hyman"));
            list.Add(new BookModel(counter++, "You are your own master chemist"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, " With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Nerve cells that fire together wire togethe"));
            list.Add(new BookModel(counter++, "Nobody changes until you change your energy"));
            list.Add(new BookModel(counter++, "Your body is your subconscious mind"));
            list.Add(new BookModel(counter++, "Are you heading in the right direction"));
            list.Add(new BookModel(counter++, "Eight limbs on the tree of "));
            list.Add(new BookModel(counter++, "Behaviors to match the intention"));
            list.Add(new BookModel(counter++, "Victim of your environment"));
            list.Add(new BookModel(counter++, "Modify our behaviors reprogram the mind"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Now I am become Death, the destroyer of worlds"));
            list.Add(new BookModel(counter++, "Lama Yeshe Introductory talk to Naropa and the Six Yogas"));
            list.Add(new BookModel(counter++, "Drupon Sangye Meditation Instructions Part 6 Nine Breathing Excercise of Naropa"));
            list.Add(new BookModel(counter++, "Closing"));






        }

        public static LoadKeysQuantumComputing Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysQuantumComputing();
            }

            return _instance;
        }
    }
}