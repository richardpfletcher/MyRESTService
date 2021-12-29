using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysAlchemy
    {
        private static LoadKeysAlchemy _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysAlchemy()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "What Does Alchemy Have To Do With Me"));
            list.Add(new BookModel(counter++, "Fourteen Video Game Stages Of Spiritual Development"));
            list.Add(new BookModel(counter++, "Video game of life"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Synchronicity"));
            list.Add(new BookModel(counter++, "Michael Singer"));
            list.Add(new BookModel(counter++, "What is “The Surrender Experiment"));
            list.Add(new BookModel(counter++, "The Untethered Soul"));
            list.Add(new BookModel(counter++, "Alchemy At Its Finest"));
            list.Add(new BookModel(counter++, "Let go of your aggravations"));
            list.Add(new BookModel(counter++, "Let go"));
            list.Add(new BookModel(counter++, "Let it go"));
            list.Add(new BookModel(counter++, "It takes two to tango"));
            list.Add(new BookModel(counter++, "Relax and Release"));
            list.Add(new BookModel(counter++, "Relax"));
            list.Add(new BookModel(counter++, "How to learn to live with the world around you"));
            list.Add(new BookModel(counter++, "Relax Your Muscles Every Day"));
            list.Add(new BookModel(counter++, "Control freak"));
            list.Add(new BookModel(counter++, "Risking failure"));
            list.Add(new BookModel(counter++, "Recognize I have a problem and it is me"));
            list.Add(new BookModel(counter++, "The more control you have the more out of control you are"));
            list.Add(new BookModel(counter++, "Is it fixable"));
            list.Add(new BookModel(counter++, "Before you judge others"));
            list.Add(new BookModel(counter++, "Recognition of your problem"));
            list.Add(new BookModel(counter++, "Everything causes a disturbance"));
            list.Add(new BookModel(counter++, "Why are you disturbed by the weather"));
            list.Add(new BookModel(counter++, "What part of you is disturbed"));
            list.Add(new BookModel(counter++, "We protect ourselves from what we feel uncomfortable inside of us"));
            list.Add(new BookModel(counter++, "The highest way to let go of a disturbance is to relax"));
            list.Add(new BookModel(counter++, "Don’t complain just relax"));
            list.Add(new BookModel(counter++, "Discipline leads to surrender"));
            list.Add(new BookModel(counter++, "When you relax you disengage with the disturbance"));
            list.Add(new BookModel(counter++, "All Things Must Pass"));
            list.Add(new BookModel(counter++, "Water underneath the bridge"));
            list.Add(new BookModel(counter++, "Using the world to define you"));
            list.Add(new BookModel(counter++, "Road Rage"));
            list.Add(new BookModel(counter++, "Suppression pushes the event away"));
            list.Add(new BookModel(counter++, "No experience is traumatic it is how we handle it"));
            list.Add(new BookModel(counter++, "The same event occurs in the family"));
            list.Add(new BookModel(counter++, "The mosquito itch"));
            list.Add(new BookModel(counter++, "That nagging feeling"));
            list.Add(new BookModel(counter++, "Laugh At Life"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysAlchemy Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysAlchemy();
            }

            return _instance;
        }
    }
}