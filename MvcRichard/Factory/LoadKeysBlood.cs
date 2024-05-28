using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysBlood
    {
        private static LoadKeysBlood _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysBlood()
        {
            int counter = 0;
            //talks

           
            list.Add(new BookModel(counter++, "Preface A Journey into the Etheric Realms"));
            list.Add(new BookModel(counter++, "Introduction"));
            list.Add(new BookModel(counter++, "The Concept of Biomineralization"));
            list.Add(new BookModel(counter++, "Sutrayana and Mantrayana"));
            list.Add(new BookModel(counter++, "The Transition from Sutrayana to Mantrayana to Vajrayana"));
            list.Add(new BookModel(counter++, "Self-Initiation"));
            list.Add(new BookModel(counter++, "Etheric Body"));
            list.Add(new BookModel(counter++, "Tree of Life"));
            list.Add(new BookModel(counter++, "The Concept of Ethers and Their Role in Spiritual Development"));
            list.Add(new BookModel(counter++, "Gospel Sophia: The Three Stages"));
            list.Add(new BookModel(counter++, "The Process of Ascension"));
            list.Add(new BookModel(counter++, "The Human Brain"));
            list.Add(new BookModel(counter++, "The Being of Avalokitesvara"));
            list.Add(new BookModel(counter++, "The Head Being More Perfect Than the Heart"));
            list.Add(new BookModel(counter++, "Rainbow Warrior"));
            list.Add(new BookModel(counter++, "Ancient Teachings Based Upon the Breath"));
            list.Add(new BookModel(counter++, "Unveiling the Mysteries of Blood Etherization"));
            list.Add(new BookModel(counter++, "Understanding Blood Etherization"));
            list.Add(new BookModel(counter++, "Role of Etheric Forces in Spiritual Evolution"));
            list.Add(new BookModel(counter++, "Moral Development and the Blood Etherization Process"));
            list.Add(new BookModel(counter++, "Insights from Rudolf Steiner's Lectures"));
            list.Add(new BookModel(counter++, "The Etherization Process and Human Evolution"));
            list.Add(new BookModel(counter++, "Significance of Pineal and Pituitary Glands"));
            list.Add(new BookModel(counter++, "Unveiling the Divine Feminine: Exploring the Gospel of Sophia's Spiritual Wisdom"));
            list.Add(new BookModel(counter++, "The Concept of the Divine Feminine"));
            list.Add(new BookModel(counter++, "Practical Exercises for Spiritual Growth"));
            list.Add(new BookModel(counter++, "Understanding Interconnectedness"));
            list.Add(new BookModel(counter++, "Experiencing the Divine Through Consciousness"));
            list.Add(new BookModel(counter++, "A Contemplative and Insightful Approach"));
            list.Add(new BookModel(counter++, "Vision of the Great Goddess"));
            list.Add(new BookModel(counter++, "The Adventure Begins: Understanding Our Blood"));
            list.Add(new BookModel(counter++, "The Heart's Secret"));
            list.Add(new BookModel(counter++, "Etheric Connection"));
            list.Add(new BookModel(counter++, "Ectropic Nature"));
            list.Add(new BookModel(counter++, "Invisible Components"));
            list.Add(new BookModel(counter++, "Initiation and Ascension"));
            list.Add(new BookModel(counter++, "Moral Center"));
            list.Add(new BookModel(counter++, "The Ascension Process"));
            list.Add(new BookModel(counter++, "Cosmic Nutrition"));
            list.Add(new BookModel(counter++, "The Four Ethers and Their Significance"));
            list.Add(new BookModel(counter++, "Human Evolution"));
            list.Add(new BookModel(counter++, "Spiritual Development"));
            list.Add(new BookModel(counter++, "Ascension Process 2"));
            list.Add(new BookModel(counter++, "Practical Cultivation of Empathy and Integrity"));
            list.Add(new BookModel(counter++, "The Breath of Life"));
            list.Add(new BookModel(counter++, "Conscious Breathing Practices: The Breath of Life"));
            list.Add(new BookModel(counter++, "The Path of Heroes"));
            list.Add(new BookModel(counter++, "Supermassive Black Holes"));
            list.Add(new BookModel(counter++, "Conclusion The Convergence of Ethers"));

        }

        public static LoadKeysBlood Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysBlood();
            }

            return _instance;
        }
    }
}