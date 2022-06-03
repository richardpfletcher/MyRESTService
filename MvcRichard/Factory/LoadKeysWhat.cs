using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysWhat
    {
        private static LoadKeysWhat _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysWhat()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "Definition"));



            list.Add(new BookModel(counter++, "Long story short"));

            list.Add(new BookModel(counter++, "Side A"));

            list.Add(new BookModel(counter++, "Side B"));

            list.Add(new BookModel(counter++, "Functional Medicine Solutions"));

            list.Add(new BookModel(counter++, "Why I Choose Functional Medicine"));

            list.Add(new BookModel(counter++, "What Is Hyperbaric Oxygen Therapy"));
            list.Add(new BookModel(counter++, "03-25-2022"));

            list.Add(new BookModel(counter++, "03-26-202"));

            list.Add(new BookModel(counter++, "03-28-2022"));

            list.Add(new BookModel(counter++, "03-29-2022"));

            list.Add(new BookModel(counter++, "03-30-2022"));

            list.Add(new BookModel(counter++, "Inner rebooting of operating system"));

            list.Add(new BookModel(counter++, "03-31-2022"));

            list.Add(new BookModel(counter++, "Reba and the crew"));

            list.Add(new BookModel(counter++, "Sound of a freight train"));

            list.Add(new BookModel(counter++, "Surgery"));

            list.Add(new BookModel(counter++, "Be conscience or freak out"));

            list.Add(new BookModel(counter++, "Code Red"));

            list.Add(new BookModel(counter++, "What's for dinner"));

            list.Add(new BookModel(counter++, "There is no place like home"));

            list.Add(new BookModel(counter++, "04-12-2020 Doctors appointment one"));

            list.Add(new BookModel(counter++, "04-13-2022 Dodge the bullet"));

            list.Add(new BookModel(counter++, "05-08-2022 Science can be very biased"));

            list.Add(new BookModel(counter++, "Galileo's Telescope Instrumental"));

            list.Add(new BookModel(counter++, "House Of The Future"));

            list.Add(new BookModel(counter++, "Zack Bush"));

            list.Add(new BookModel(counter++, "Zach GLYPHOSATE +TOXINS"));

            list.Add(new BookModel(counter++, "Zach Proactive Ways"));

            list.Add(new BookModel(counter++, "Zach Roll in the dirt"));

            list.Add(new BookModel(counter++, "If science proved"));

            list.Add(new BookModel(counter++, "Internal Radar"));

            list.Add(new BookModel(counter++, "Body Signals - Are You Listening"));

            list.Add(new BookModel(counter++, "09-01-2019 Age Is Timeless"));

            list.Add(new BookModel(counter++, "Thank God For Antibiotics"));

            list.Add(new BookModel(counter++, "Why your doctor’s advice to take all your antibiotics may be wrong"));

            list.Add(new BookModel(counter++, "Why your doctor’s advice"));

            list.Add(new BookModel(counter++, "You are your own master chemist"));


            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));

            list.Add(new BookModel(counter++, "Reversing type 2 diabetes starts with ignoring the guidelines"));

            list.Add(new BookModel(counter++, "Metabolic syndrome"));

            list.Add(new BookModel(counter++, "09-01-2019 Age Is Timeless"));

            list.Add(new BookModel(counter++, "Gulping down the food"));

            list.Add(new BookModel(counter++, "Jim Cokas"));

            list.Add(new BookModel(counter++, "Esmerelda Kay"));

            list.Add(new BookModel(counter++, "First meeting with internal medicine crew"));

            list.Add(new BookModel(counter++, "Easter Sunday Surprise"));

            list.Add(new BookModel(counter++, "Sherlock Holmes"));

            list.Add(new BookModel(counter++, "Prices all over the board"));

            list.Add(new BookModel(counter++, "Don't tell me what to do"));

            list.Add(new BookModel(counter++, "If I could change the medical system"));

            list.Add(new BookModel(counter++, "The double split experminent"));

            list.Add(new BookModel(counter++, "05 -05-2022 Double split experiment 2"));

            list.Add(new BookModel(counter++, "05-07-2022 Fire rant"));

            list.Add(new BookModel(counter++, "Drink plenty of water"));

            list.Add(new BookModel(counter++, "Grocery Store"));

            list.Add(new BookModel(counter++, "ADVENTURES IN ADULTING The Perils of Grocery Shopping in College"));

list.Add(new BookModel(counter++, "What is intermittent fasting"));

            list.Add(new BookModel(counter++, "Intermittent fasting and Ketosis"));
            list.Add(new BookModel(counter++, "Food revolution summit"));

            list.Add(new BookModel(counter++, "Coffee and Ketones"));

            list.Add(new BookModel(counter++, "Insulin Resistance Diet Separating Fact From Fiction"));

            list.Add(new BookModel(counter++, "DOMINIC D’AGOSTINO’S DIET"));

            list.Add(new BookModel(counter++, "Jason Fong"));

            list.Add(new BookModel(counter++, "Coporate farms"));

            list.Add(new BookModel(counter++, "Dirt Poor Have Fruits and Vegetables Become Less Nutritious"));

            list.Add(new BookModel(counter++, "A Bull in a china shop"));

            list.Add(new BookModel(counter++, "The Matrix"));

            list.Add(new BookModel(counter++, "Inner rebooting of operating system 2"));

            list.Add(new BookModel(counter++, "David Sinclair"));

            list.Add(new BookModel(counter++, "05-19-2022 Dr Ayer"));




        }

    public static LoadKeysWhat Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysWhat();
            }

            return _instance;
        }
    }
}