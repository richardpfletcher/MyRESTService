using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysWestCoast
    {
        private static LoadKeysWestCoast _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysWestCoast()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Vancouver has a new tent city.This time it’s in the street, not a park"));
            list.Add(new BookModel(counter++, "If Seattle is dying, here’s the cause of "));
            list.Add(new BookModel(counter++, "Death Of A Cit The Portland Story"));
            list.Add(new BookModel(counter++, "Seaside sets course to tackle homelessness at the Oregon Coast"));
            list.Add(new BookModel(counter++, "Why San Francisco Is Nearly The Most Crime-Ridden City In The US"));
            list.Add(new BookModel(counter++, "Ashland Couch surfing"));
            list.Add(new BookModel(counter++, "Venice residents businesses fed up with homeless problem 'It's disgusting"));
            list.Add(new BookModel(counter++, "Santa Ana provides new data that Orange County is ‘dumping’ homeless"));
            list.Add(new BookModel(counter++, "Life Of a Homeless"));
            list.Add(new BookModel(counter++, "THE CHALLENGE"));
            list.Add(new BookModel(counter++, "The Impact of Homelessness on Education"));
            list.Add(new BookModel(counter++, "Homeless as a high school senior"));
            list.Add(new BookModel(counter++, "Why Finland and Norway still shun university tuition fees"));
            list.Add(new BookModel(counter++, "Education Comments"));
            list.Add(new BookModel(counter++, "Homework in Finland School"));
            list.Add(new BookModel(counter++, "The Facts About Family Homelessness"));
            list.Add(new BookModel(counter++, "How Many Children and Families Experience Homelessness"));
list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "You are your own master chemist"));
            list.Add(new BookModel(counter++, "‘I DON’T KNOW THAT I WOULD EVEN CALL IT METH ANYMORE’"));
            list.Add(new BookModel(counter++, "How The Atlantic's Big Piece on Meth and Homelessness Gets It Wrong"));
            list.Add(new BookModel(counter++, "Non - violence in your mind and body"));
            list.Add(new BookModel(counter++, "Emotions"));
            list.Add(new BookModel(counter++, "New Thought"));
            list.Add(new BookModel(counter++, "New Concepts"));
            list.Add(new BookModel(counter++, "New Wiring"));
            list.Add(new BookModel(counter++, "New Personality"));
            list.Add(new BookModel(counter++, "Human"));
            list.Add(new BookModel(counter++, "Researchers gave homeless people money"));
            list.Add(new BookModel(counter++, "EVERYTHING YOU NEED TO KNOW ABOUT HOMELESSNESS IN NORWAY"));
            list.Add(new BookModel(counter++, "More affordable housing with less homelessness is possible"));
            list.Add(new BookModel(counter++, "The first step to stop corporations from profiting from "));
            list.Add(new BookModel(counter++, "60 Minutes Presents Behind "));
            list.Add(new BookModel(counter++, "Peace Education "));
            list.Add(new BookModel(counter++, "Man Is At His Best When In Peace – Prem Rawat"));
            list.Add(new BookModel(counter++, "More Americans Killed by Guns Since 1968 Than in All U.S.Wars"));
            list.Add(new BookModel(counter++, "These Are the World's Top 10 Happiest and Unhappiest Countries in 2022"));
            list.Add(new BookModel(counter++, "Happiness is the key"));
            list.Add(new BookModel(counter++, "Forget GDP — New Zealand is prioritizing gross national well-being"));
            list.Add(new BookModel(counter++, "The Ray Of Happiness"));
            list.Add(new BookModel(counter++, "Happiness Lies Inside"));
            list.Add(new BookModel(counter++, "Happines"));
            list.Add(new BookModel(counter++, "Where is preventive Medicine in this picture"));
            list.Add(new BookModel(counter++, "Preventative Care is the Healthcare of the Future"));
            list.Add(new BookModel(counter++, "5 Reasons Functional Medicine is the Only Kind of Health Care You Want"));
            list.Add(new BookModel(counter++, "What is a Functional Medicine Doctor"));
            list.Add(new BookModel(counter++, "California Approves Bill to Punish Doctors Who Spread False Information"));
            list.Add(new BookModel(counter++, "Closing"));





        }

        public static LoadKeysWestCoast Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysWestCoast();
            }

            return _instance;
        }
    }
}