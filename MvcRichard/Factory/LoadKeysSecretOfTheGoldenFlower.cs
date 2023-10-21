using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSecretOfTheGoldenFlower
    {
        private static LoadKeysSecretOfTheGoldenFlower _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysSecretOfTheGoldenFlower()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Down the Rabbit hole"));
            list.Add(new BookModel(counter++, "The Secret of the Golden Flower by Stephen Farah"));
            list.Add(new BookModel(counter++, "The Eight Taoist Immortals -Keepers of Ancient Wisdom"));
            list.Add(new BookModel(counter++, "Immortal Woman He(He Xiangu) -The Pure One"));
            list.Add(new BookModel(counter++, "Cao Guojiu -The Royal Uncle"));
            list.Add(new BookModel(counter++, "Li Tieguai -The Iron - Crutch Li"));
            list.Add(new BookModel(counter++, "Lan Caihe - The Flower Basket Immortal"));
            list.Add(new BookModel(counter++, "Han Xiangzi - The Philosopher"));
            list.Add(new BookModel(counter++, "Zhang Guolao - The Old Man with a Drum"));
            list.Add(new BookModel(counter++, "Lu Dongbin - The Scholar and Alchemist"));
            list.Add(new BookModel(counter++, "The Authorship of The Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "Zhongli Quan -The Elixir Master"));
            list.Add(new BookModel(counter++, "The Relevance of The Eight Taoist Immortals in Today's World"));
            list.Add(new BookModel(counter++, "The Mysterious Flower"));
            list.Add(new BookModel(counter++, "The Path Within"));
            list.Add(new BookModel(counter++, "The Dance of Harmony"));
            list.Add(new BookModel(counter++, "The Magic of Breath"));
            list.Add(new BookModel(counter++, "The Power of Kindness"));
            list.Add(new BookModel(counter++, "The Gift of Gratitude"));
            list.Add(new BookModel(counter++, "The Joy of Sharing"));
            list.Add(new BookModel(counter++, "The Song of Unity"));
            list.Add(new BookModel(counter++, "The Gift of Wisdom"));
            list.Add(new BookModel(counter++, "The Everlasting Bloom"));
            list.Add(new BookModel(counter++, "The Golden Flower's Legacy"));
            list.Add(new BookModel(counter++, "The Integration of the Five Elements"));
            list.Add(new BookModel(counter++, "Mistakes During the Circulation of the Light"));
            list.Add(new BookModel(counter++, "The Ancient Wisdom of the Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "Laying the Foundation"));
            list.Add(new BookModel(counter++, "The Magical Power of the Golden Flower"));
            list.Add(new BookModel(counter++, "The Mind as the Ultimate Battlefield"));
            list.Add(new BookModel(counter++, "The Magical Dance of Spirit"));
            list.Add(new BookModel(counter++, "The Circulation of the Light"));
            list.Add(new BookModel(counter++, "Circulation of the Light Story"));
            list.Add(new BookModel(counter++, "Special light inside you"));
            list.Add(new BookModel(counter++, "The Integration of Yin and Yang"));
            list.Add(new BookModel(counter++, "Balance Yin and Yang"));
            list.Add(new BookModel(counter++, "The Dance of Complementary Forces"));
            list.Add(new BookModel(counter++, "The Flower and the Dragon"));
            list.Add(new BookModel(counter++, "Confirmatory Experiences during the Circulation of the Light"));
            list.Add(new BookModel(counter++, "The Gateway to Unity"));
            list.Add(new BookModel(counter++, "Special power hidden inside you"));
            list.Add(new BookModel(counter++, "The Journey Beyond Words"));
            list.Add(new BookModel(counter++, "Summary"));
            list.Add(new BookModel(counter++, "The Secret of the Golden Flower and the teachings of Mantak Chia are related"));
            list.Add(new BookModel(counter++, "Edgar Cayce and the Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "John Van Aken and the Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "Osho and the secret of the golden flower"));
            list.Add(new BookModel(counter++, "The Secret of the Golden Flower Golden Light Meditation"));
            list.Add(new BookModel(counter++, "Secret of the Golden Flower by Śivadyuti(शिवद्युति)"));
            list.Add(new BookModel(counter++, "Backward Flowing Method"));
            list.Add(new BookModel(counter++, "The Backward - Flowing Method"));
            list.Add(new BookModel(counter++, "The Connection Between the Backward Flowing Method and Joe Dispenza's Energy Center Work"));
            list.Add(new BookModel(counter++, "Exploring the Relationship Between the Backward Flowing Method and the Six Yogas of Naropa"));
            list.Add(new BookModel(counter++, "Exploring the Relationship Between the Backward Flowing Method and Kundalini Yoga"));
            list.Add(new BookModel(counter++, "Pratyāhāra withdrawing of the external senses"));
            list.Add(new BookModel(counter++, "Pratyāhāra - Five Internal Sensesmp3"));
            list.Add(new BookModel(counter++, "The Magic of Letting Things Happen"));
            list.Add(new BookModel(counter++, "The Tao Te Ching and the Secret of the Golden Flower"));
            list.Add(new BookModel(counter++, "Tao Te Ching"));
            list.Add(new BookModel(counter++, "The Way"));
            list.Add(new BookModel(counter++, "Closing The Golden Flower Blooms"));





        }

        public static LoadKeysSecretOfTheGoldenFlower Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysSecretOfTheGoldenFlower();
            }

            return _instance;
        }
    }
}