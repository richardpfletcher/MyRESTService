using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysElectronicDoppelgänger
    {
        private static LoadKeysElectronicDoppelgänger _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysElectronicDoppelgänger()
        {
            int counter = 0;
            //talks

list.Add(new BookModel(counter++, "Can you summarize the book"));
            list.Add(new BookModel(counter++, "What does he mean by machine-animals"));
            list.Add(new BookModel(counter++, "Doppelganger is an artificial intelligence"));
            list.Add(new BookModel(counter++, "Does the doppelganger have an agenda"));
            list.Add(new BookModel(counter++, "Prison guard and prisoner"));
            list.Add(new BookModel(counter++, "The Enigma of Doppelgängers"));
            list.Add(new BookModel(counter++, "Story What Is a Doppelgänger"));
            list.Add(new BookModel(counter++, "The Mysterious World of Doppelgängers and the Age of the Internet"));
            list.Add(new BookModel(counter++, "Story The Mysterious World of Doppelgängers and the Age of the Internet"));
            list.Add(new BookModel(counter++, "The Enigmatic World of Doppelgängers Unveiling Rudolf Steiner's Spiritual Insights"));
            list.Add(new BookModel(counter++, "How Machines and Humans Interact"));
            list.Add(new BookModel(counter++, "Story The Dance of Machines and Humans"));
            list.Add(new BookModel(counter++, "The Birth of the Digital Double"));
            list.Add(new BookModel(counter++, "Story The Birth of the Digital Double"));
            list.Add(new BookModel(counter++, "The Secret of the Geographical Doppelgänger"));
            list.Add(new BookModel(counter++, "Story The Secret of the Geographical Doppelgänger"));
            list.Add(new BookModel(counter++, "Challenges and Temptations"));
            list.Add(new BookModel(counter++, "Story The Cosmic Connection"));
            list.Add(new BookModel(counter++, "Embracing Our Digital Doubles"));
            list.Add(new BookModel(counter++, "Story Embracing Our Digital Doubles"));
            list.Add(new BookModel(counter++, "Bertrand Russell’s Panpsychism"));
            list.Add(new BookModel(counter++, "Story Bertrand Russell's Panpsychism"));
            list.Add(new BookModel(counter++, "Yogic Thought and the Inner Self"));
            list.Add(new BookModel(counter++, "Story Yogic Thought and the Inner Self"));
            list.Add(new BookModel(counter++, "Darkness Before Dawn"));
            list.Add(new BookModel(counter++, "AI Chat"));
            list.Add(new BookModel(counter++, "Taoism and the Balance of Yin and Yang"));
            list.Add(new BookModel(counter++, "Story The Cosmic Dance Exploring Taoism and the Balance of Yin and Yang"));
            list.Add(new BookModel(counter++, "Gaia Hypothesis and the Earth as a Living Organism"));
            list.Add(new BookModel(counter++, "Story Gaia's Song Embracing the Earth as a Living Organism"));
            list.Add(new BookModel(counter++, "Buddhism and the Illusion of Self"));
            list.Add(new BookModel(counter++, "Story The Lotus's Dance Exploring Buddhism and the Illusion of Self"));
            list.Add(new BookModel(counter++, "The Electronic Doppelgänger and Significance in the Age of the Internet"));
            list.Add(new BookModel(counter++, "Story Echoes of the Digital Self Navigating the Electronic Doppelgänger in the Age of the Internet"));
            list.Add(new BookModel(counter++, "Historical Perspectives"));
            list.Add(new BookModel(counter++, "Story Echoes of Time Exploring Historical Perspectives"));
            list.Add(new BookModel(counter++, "Jainism and the Doctrine of Anatta"));
            list.Add(new BookModel(counter++, "Story Embracing Emptiness Exploring Jainism and the Doctrine of Anatta"));
            list.Add(new BookModel(counter++, "Scientific Perspectives"));
            list.Add(new BookModel(counter++, "Story The Tapestry of Science Exploring Perspectives on Reality and Identity"));
            list.Add(new BookModel(counter++, "Cultural Manifestations"));
            list.Add(new BookModel(counter++, "Story Reflections of Culture Exploring Duality Through Literature, Film, and Art"));
            list.Add(new BookModel(counter++, "Psychological Considerations"));
            list.Add(new BookModel(counter++, "Story Shadows of the Mind A Journey Through Psychological Considerations"));
            list.Add(new BookModel(counter++, "Ethical Implications"));
            list.Add(new BookModel(counter++, "Navigating the Digital Landscape"));
            list.Add(new BookModel(counter++, "Closing The Dance of Duality"));
            list.Add(new BookModel(counter++, "Reflection Prompts for Young Readers"));


        }

        public static LoadKeysElectronicDoppelgänger Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysElectronicDoppelgänger();
            }

            return _instance;
        }
    }
}