using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysPuzzle
    {
        private static LoadKeysPuzzle _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysPuzzle()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "The Power To Change"));
            list.Add(new BookModel(counter++, "The Solution"));
            list.Add(new BookModel(counter++, "The Song Of Life"));
            list.Add(new BookModel(counter++, "The Summer Night Time Breeze"));
            list.Add(new BookModel(counter++, "The Spirit Of Humanity"));
            list.Add(new BookModel(counter++, "The World Would Be Much Better"));
            list.Add(new BookModel(counter++, "The Breath"));
            list.Add(new BookModel(counter++, "Wonderful Day"));
            list.Add(new BookModel(counter++, "World Of Mystery"));
            list.Add(new BookModel(counter++, "You Are Never Alone II"));
            list.Add(new BookModel(counter++, "You Are On My Mind"));
            list.Add(new BookModel(counter++, "You Are You"));
            list.Add(new BookModel(counter++, "You Can Do It II"));
            list.Add(new BookModel(counter++, "Just Don't Get Why"));
            list.Add(new BookModel(counter++, "Just Tell Me"));
            list.Add(new BookModel(counter++, "Keep Your Heart Alive"));
            list.Add(new BookModel(counter++, "Leave A Legacy Behind You"));
            list.Add(new BookModel(counter++, "Let Me In Your Heart"));
            list.Add(new BookModel(counter++, "Let The Light Shine Within"));
            list.Add(new BookModel(counter++, "World Of Mystery"));
            list.Add(new BookModel(counter++, "You Are Never Alone"));
            list.Add(new BookModel(counter++, "You Are On My Mind"));
            list.Add(new BookModel(counter++, "You Are You"));
            list.Add(new BookModel(counter++, "You Can Do It"));
            list.Add(new BookModel(counter++, "Solve this puzzle of life"));
            list.Add(new BookModel(counter++, "The Carrot on the stick"));
            list.Add(new BookModel(counter++, "Family and Friends"));
            list.Add(new BookModel(counter++, "Missing Piece Of The Puzzle"));
            list.Add(new BookModel(counter++, "3-16-2018 Panpsychism"));
            list.Add(new BookModel(counter++, "Five Internal Senses"));
            list.Add(new BookModel(counter++, "Theory Versus Practical"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "There Are Sign Post Of God Everywhere"));
            list.Add(new BookModel(counter++, "Does Life Throw You A Curve Ball"));
            list.Add(new BookModel(counter++, "One Tribe"));
            list.Add(new BookModel(counter++, "Our Days Here Are Numbered"));
            list.Add(new BookModel(counter++, "Out Of Control"));
            list.Add(new BookModel(counter++, "Peace On Earth Is Possible"));
            list.Add(new BookModel(counter++, "Pure Love &Gratitude"));
            list.Add(new BookModel(counter++, "Redemption"));
            list.Add(new BookModel(counter++, "You are the missing piece of the puzzle"));
            list.Add(new BookModel(counter++, "Life Is More Than You Think It Is"));
            list.Add(new BookModel(counter++, "Living The Dream"));
            list.Add(new BookModel(counter++, "Love Is That Way"));
            list.Add(new BookModel(counter++, "Making Friends With Dragons"));
            list.Add(new BookModel(counter++, "Alchemy At Its Finest"));
            list.Add(new BookModel(counter++, "Maya"));
            list.Add(new BookModel(counter++, "The Sugar Cube"));
            list.Add(new BookModel(counter++, "Adios Senor"));
            list.Add(new BookModel(counter++, "You Are Star Dust"));
            list.Add(new BookModel(counter++, "Signposts Are All Around"));
            list.Add(new BookModel(counter++, "Wizards Handbook"));
            list.Add(new BookModel(counter++, "One Million Years From Now"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "Bruce Lipton"));
            list.Add(new BookModel(counter++, "The World Is a Drama"));
            list.Add(new BookModel(counter++, "Dragon Politics"));
            list.Add(new BookModel(counter++, "Got To Change Our Crazy Ways"));
            list.Add(new BookModel(counter++, "How To Stop Wars"));
            list.Add(new BookModel(counter++, "Lack Of Kindness"));









        }

        public static LoadKeysPuzzle Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysPuzzle();
            }

            return _instance;
        }
    }
}