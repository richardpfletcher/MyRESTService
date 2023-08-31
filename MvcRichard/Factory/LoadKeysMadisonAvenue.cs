using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysMadisonAvenue
    {
        private static LoadKeysMadisonAvenue _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysMadisonAvenue()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Common values of conscious brands"));
            list.Add(new BookModel(counter++, "How can we promote these values"));
            list.Add(new BookModel(counter++, "The history of TV commercials"));
            list.Add(new BookModel(counter++, "Some pros and cons of drug commercials"));
            list.Add(new BookModel(counter++, "How did the drug companies take over in the early 1900's"));
            list.Add(new BookModel(counter++, "Drugs have side effects"));
            list.Add(new BookModel(counter++, "History of pharmacy before 1900s"));
            list.Add(new BookModel(counter++, "The top 10 pharmaceutical products"));
            list.Add(new BookModel(counter++, "Why do drug commercials have people do seem their lives are so happy"));
            list.Add(new BookModel(counter++, "Some famous drug commercials on TV are"));
            list.Add(new BookModel(counter++, "Rinvoq can cause side effects"));
            list.Add(new BookModel(counter++, "Dupixent can cause some side effects"));
            list.Add(new BookModel(counter++, "Skyrizi can cause some side effects"));
            list.Add(new BookModel(counter++, "Humira can cause some side effects"));
            list.Add(new BookModel(counter++, "VRAYLAR can cause some side effects"));
            list.Add(new BookModel(counter++, "Why do people think I don't have to change my life style taking a drug"));
            list.Add(new BookModel(counter++, "How to Balance Your Mind, Body, and Soul"));
            list.Add(new BookModel(counter++, "The United States spends trillions on health care every year"));
            list.Add(new BookModel(counter++, "Doctors May Need More Education on Nutrition"));
            list.Add(new BookModel(counter++, "The majority of the US eats junk food"));
            list.Add(new BookModel(counter++, "How can I reduce my junk food cravings"));
            list.Add(new BookModel(counter++, "What is the relationship between the microbiome and junk food"));
            list.Add(new BookModel(counter++, "How do antibotics affect the microbiome"));
            list.Add(new BookModel(counter++, "Why does junk food taste so good"));
            list.Add(new BookModel(counter++, "What are some healthy foods that can improve my brain function"));
            list.Add(new BookModel(counter++, "How much of these foods should I eat"));
            list.Add(new BookModel(counter++, "The junk food industry spends billions of dollars a year"));
            list.Add(new BookModel(counter++, "Soft drinks health effects"));
            list.Add(new BookModel(counter++, "How much sugar is in a can of soda"));
            list.Add(new BookModel(counter++, "I have friends who only drink soda"));
            list.Add(new BookModel(counter++, "How to convince someone to drink less soda"));
            list.Add(new BookModel(counter++, "Sugar content in energy drinks"));
            list.Add(new BookModel(counter++, "Why does soda industry have professional athletes promote their products"));
            list.Add(new BookModel(counter++, "How muck money do they make for a commercial on TV"));
            list.Add(new BookModel(counter++, "If they ban cigarette commercials, why not ban soda commercials"));
            list.Add(new BookModel(counter++, "Yet the United States is one of the sickest countries in the world"));
            list.Add(new BookModel(counter++, "United States can make significant lifestyle changes"));
            list.Add(new BookModel(counter++, "We should have advertising that should only reflect these values"));
            list.Add(new BookModel(counter++, "I'm saying at times we are sawing off the branch we are sitting on"));
            list.Add(new BookModel(counter++, "Do you see a time in the advertising industry"));
            list.Add(new BookModel(counter++, "What do you see for the trends in the next 50 years"));
            list.Add(new BookModel(counter++, "What are some examples of personalized nutrition"));
            list.Add(new BookModel(counter++, "What is the difference between personalized nutrition and traditional nutrition"));
            list.Add(new BookModel(counter++, "Some pros and cons of soda commercials"));
            list.Add(new BookModel(counter++, "Comparison of soda commercials and drug commercials"));
            list.Add(new BookModel(counter++, "Effects of commercials on mind body and soul"));
            list.Add(new BookModel(counter++, "Some examples of harmful commercials are"));
            list.Add(new BookModel(counter++, "Some examples of good commercials are"));
            list.Add(new BookModel(counter++, "How commercials affect our emotions"));
            list.Add(new BookModel(counter++, "Can commercials be addictive"));
            list.Add(new BookModel(counter++, "Signs of addiction to commercials")); 
list.Add(new BookModel(counter++, "Quick way to resist the temptation of commercials"));
            list.Add(new BookModel(counter++, "What are some healthy alternatives to watching commercial"));
            list.Add(new BookModel(counter++, "How have commercials changed over time"));
            list.Add(new BookModel(counter++, "Can addiction to commercials be cured completely"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysMadisonAvenue Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysMadisonAvenue();
            }

            return _instance;
        }
    }
}