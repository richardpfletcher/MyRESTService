using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysJewelerAndTheTheif
    {
        private static LoadKeysJewelerAndTheTheif _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysJewelerAndTheTheif()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "The Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "Comparison The Power of Now and the Jeweler And The Thief"));
            list.Add(new BookModel(counter++, "Planting - the - seeds"));
            list.Add(new BookModel(counter++, "Planting The Seeds Commentary"));
            list.Add(new BookModel(counter++, "Stop - the - noise -in-your - head"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head Commentary"));
            list.Add(new BookModel(counter++, "The-frog-in-the-well"));
            list.Add(new BookModel(counter++, "The Frog in The Wel Commentary"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant"));
            list.Add(new BookModel(counter++, "3 Blind Men And The Elephant Commentary"));
            list.Add(new BookModel(counter++, "Comparison of The Power of Now by Eckhart Tolle and Fletcher Soul Traveler"));
            list.Add(new BookModel(counter++, "The Power of Now"));
            list.Add(new BookModel(counter++, "Pain body"));
            list.Add(new BookModel(counter++, "What Is The Pain Body"));
            list.Add(new BookModel(counter++, "The Ego"));
            list.Add(new BookModel(counter++, "The present moment"));
            list.Add(new BookModel(counter++, "Mindfulness"));
            list.Add(new BookModel(counter++, "Spiritual enlightenment"));
            list.Add(new BookModel(counter++, "Surrender"));
            list.Add(new BookModel(counter++, "The Importance of Forgiveness"));
            list.Add(new BookModel(counter++, "The correlation between Eckhart Tolle and the Vedas"));
            list.Add(new BookModel(counter++, "Aware"));
            list.Add(new BookModel(counter++, "Stillness Speaks"));
            list.Add(new BookModel(counter++, "Stillness Speaks passages 1"));
            list.Add(new BookModel(counter++, "Stillness Speaks passages 2"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Eckhart Tolle's teachings on surrender and the Dao"));
            list.Add(new BookModel(counter++, "True listening"));
            list.Add(new BookModel(counter++, "Set Ego Boundaries"));
            list.Add(new BookModel(counter++, "Forms Of Suffering"));
            list.Add(new BookModel(counter++, "Awareness Replacing Thinking"));
            list.Add(new BookModel(counter++, "Ramana Maharish"));
            list.Add(new BookModel(counter++, "Self-inquiry"));
            list.Add(new BookModel(counter++, "jivanmukta"));
            list.Add(new BookModel(counter++, "Be As You Are The Teachings of Sri Ramana Maharshi"));
            list.Add(new BookModel(counter++, "Ramana Maharshi Meditation"));
            list.Add(new BookModel(counter++, "Ramana Maharshi Surrender"));
            list.Add(new BookModel(counter++, "Ramana Maharshi Three stages of surrender"));
            list.Add(new BookModel(counter++, "Eckhart Tolle and Ramana Maharshi share many common teachings"));
            list.Add(new BookModel(counter++, "Baba Ram Dass"));
            list.Add(new BookModel(counter++, "Be Here Now"));
            list.Add(new BookModel(counter++, "Bhakti Yoga"));
            list.Add(new BookModel(counter++, "being-perfect-versus-being-"));
            list.Add(new BookModel(counter++, "Be In The Moment Instrumental"));
            list.Add(new BookModel(counter++, "The Journey of Awakening"));
            list.Add(new BookModel(counter++, "Transformation"));
            list.Add(new BookModel(counter++, "Paul Cohen"));
            list.Add(new BookModel(counter++, "ram-das-quotes-1"));
            list.Add(new BookModel(counter++, "ram-das-quotes-2"));
            list.Add(new BookModel(counter++, "Tibetan Book of the Dead"));
            list.Add(new BookModel(counter++, "The process of dissolving the elements in Tibetan Buddhism"));
            list.Add(new BookModel(counter++, "Correlation between Six Yogas of Naropa and Tibetan Book of the Dead"));
            list.Add(new BookModel(counter++, "Disengaging from the mind"));
            list.Add(new BookModel(counter++, "Subtle body"));
            list.Add(new BookModel(counter++, "Six Yogas of Naropa and the subtle body"));
            list.Add(new BookModel(counter++, "Shadow work"));
            list.Add(new BookModel(counter++, "How to practice shadow work"));
            list.Add(new BookModel(counter++, "Shadow work can be a challenging process"));
            list.Add(new BookModel(counter++, "The Dark Side of the Light Chasers"));
            list.Add(new BookModel(counter++, "Exercises"));
            list.Add(new BookModel(counter++, "Carl Yung"));
            list.Add(new BookModel(counter++, "Buddhist thought"));
            list.Add(new BookModel(counter++, "Carl Jung Meditation"));
            list.Add(new BookModel(counter++, "The Practice of Psychotherapy"));
            list.Add(new BookModel(counter++, "Common Themes"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysJewelerAndTheTheif Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysJewelerAndTheTheif();
            }

            return _instance;
        }
    }
}