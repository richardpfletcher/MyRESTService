using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDragonsShaolin
    {
        private static LoadKeysDragonsShaolin _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDragonsShaolin()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Buddha has been following me around for a long time"));
            list.Add(new BookModel(counter++, "The beginning Dragon Tales"));
            list.Add(new BookModel(counter++, "Exploring the Shaolin Temple in Germany A Path to Self-Transformation"));
            list.Add(new BookModel(counter++, "The Shaolin Temple is a Buddhist temple in China"));
            list.Add(new BookModel(counter++, "Zoran the dragon founder of the Shaolin Temple in China 1,500 years ago"));
            list.Add(new BookModel(counter++, "The Shaolin Temple A Living Legacy of Zen and Kung Fu"));
            list.Add(new BookModel(counter++, "The Ancient Art of Shaolin Kung Fu"));
            list.Add(new BookModel(counter++, "Bruce Lee and Kung Fu"));
            list.Add(new BookModel(counter++, "Shi Heng Yi best motivation video"));
            list.Add(new BookModel(counter++, "Five hindrances"));
            list.Add(new BookModel(counter++, "Zoran teaching the five hindrances"));
            list.Add(new BookModel(counter++, "Sensual desire"));
            list.Add(new BookModel(counter++, "Tools-to-overcome-sensual-desire"));
            list.Add(new BookModel(counter++, "Ill-will"));
            list.Add(new BookModel(counter++, "Tools to overcome Ill-will"));
            list.Add(new BookModel(counter++, "Sloth-and-torpor"));
            list.Add(new BookModel(counter++, "Tools to overcome Sloth and Torpor"));
            list.Add(new BookModel(counter++, "Restlessness-and-worry"));
            list.Add(new BookModel(counter++, "Tools to overcome Restlessness-and-worry"));
            list.Add(new BookModel(counter++, "Doubt"));
            list.Add(new BookModel(counter++, "Tools to overcome doubt"));
            list.Add(new BookModel(counter++, "The Four Noble Truths"));
            list.Add(new BookModel(counter++, "Zoran teaching the Four Noble Truths"));
            list.Add(new BookModel(counter++, "The Eightfold Noble Path"));
            list.Add(new BookModel(counter++, "Zoran the Dragon and the Noble Eightfold Path"));
            list.Add(new BookModel(counter++, "Past - Present – Future"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Past - Present – Future"));
            list.Add(new BookModel(counter++, "How to deal with emotions"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching How to deal with emotions"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching the power of now"));
            list.Add(new BookModel(counter++, "Taoism"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Taoism"));
            list.Add(new BookModel(counter++, "Wuxing 5-Element Concept"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Wuxing 5-Element Concept"));
            list.Add(new BookModel(counter++, "Did isometrics come from Wuxing 5-Element"));
            list.Add(new BookModel(counter++, "Yin Yang"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Yin Yang"));
            list.Add(new BookModel(counter++, "Confucianism"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Confucianism"));
            list.Add(new BookModel(counter++, "Confucian Virtues"));
            list.Add(new BookModel(counter++, "Benevolence"));
            list.Add(new BookModel(counter++, "Righteousness"));
            list.Add(new BookModel(counter++, "Propriety"));
            list.Add(new BookModel(counter++, "Wisdom"));
            list.Add(new BookModel(counter++, "Trustworthiness"));
            list.Add(new BookModel(counter++, "Harmony and hierarchy"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Harmony and hierarchy"));
            list.Add(new BookModel(counter++, "Bone Marrow Cleansing"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Shaolin Bone Marrow Cleansing"));
            list.Add(new BookModel(counter++, "Breath"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Shaolin power of breath"));
            list.Add(new BookModel(counter++, "Shaolin Qi gong"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Shaolin Qi gong"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Shaolin Meditation"));
            list.Add(new BookModel(counter++, "Regenerate Your Mind and body"));
            list.Add(new BookModel(counter++, "Always Positive"));
            list.Add(new BookModel(counter++, "On Anger"));
            list.Add(new BookModel(counter++, "The 6 tools to train the mind"));
            list.Add(new BookModel(counter++, "Escape the Matrix"));
            list.Add(new BookModel(counter++, "Use your hands like this"));
            list.Add(new BookModel(counter++, "Becoming aware of every second"));
            list.Add(new BookModel(counter++, "The 14 Truths"));
            list.Add(new BookModel(counter++, "Super Human"));
            list.Add(new BookModel(counter++, "What Steps to take"));
            list.Add(new BookModel(counter++, "Top Rules"));
            list.Add(new BookModel(counter++, "5 Loosing Exercises"));
            list.Add(new BookModel(counter++, "Dichotomy of control"));
            list.Add(new BookModel(counter++, "Quick Relief for any Diseases"));
            list.Add(new BookModel(counter++, "Know the rules of the game"));
            list.Add(new BookModel(counter++, "Routines of the Shaolin disciple"));
            list.Add(new BookModel(counter++, "Life inside of the monastery"));
            list.Add(new BookModel(counter++, "Shaolin Neigong internal exercises"));
            list.Add(new BookModel(counter++, "Fire within"));
            list.Add(new BookModel(counter++, "Demon and Buddha heart"));
            list.Add(new BookModel(counter++, "Importance of Structure"));
            list.Add(new BookModel(counter++, "Zoran the dragon teaching Shaolin Mind and Body"));
            list.Add(new BookModel(counter++, "The present moment is the only reality and the only thing that matter"));
            list.Add(new BookModel(counter++, "Zoran The present moment is the only reality and the only thing that matters"));
            list.Add(new BookModel(counter++, "The mind and the body"));
            list.Add(new BookModel(counter++, "Shaolin Temple and the Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "Closing"));





        }

        public static LoadKeysDragonsShaolin Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDragonsShaolin();
            }

            return _instance;
        }
    }
}