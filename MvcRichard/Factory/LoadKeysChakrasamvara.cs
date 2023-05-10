using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysChakrasamvara
    {
        private static LoadKeysChakrasamvara _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysChakrasamvara()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Commentary"));
            list.Add(new BookModel(counter++, "You are your own master chemist"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Nerve cells that fire together wire togethe"));
            list.Add(new BookModel(counter++, "Nobody changes until you change your energy"));
            list.Add(new BookModel(counter++, "Your body is your subconscious mind"));
            list.Add(new BookModel(counter++, "Are you heading in the right direction"));
            list.Add(new BookModel(counter++, "Eight limbs on the tree of life"));
            list.Add(new BookModel(counter++, "Behaviors to match the intention"));
            list.Add(new BookModel(counter++, "Have you ever seen an unhappy Buddhist Lama"));
            list.Add(new BookModel(counter++, "victim - of - your - environment"));
            list.Add(new BookModel(counter++, "Modify our behaviors reprogram the mind"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "How would you like the Dalai Lama to be your Grand Parent"));
            list.Add(new BookModel(counter++, "If you have read this far"));
            list.Add(new BookModel(counter++, "Ponder It Over"));
            list.Add(new BookModel(counter++, "Mm I get high with a little help from my friends"));
            list.Add(new BookModel(counter++, "Just wing it"));
            list.Add(new BookModel(counter++, "6 Yogas Of Naropa"));
            list.Add(new BookModel(counter++, "Tummo and Tantra"));
            list.Add(new BookModel(counter++, "Dragon History And Tummo"));
            list.Add(new BookModel(counter++, "6 Afflictions"));
            list.Add(new BookModel(counter++, "Are You Curious or Dull About Life"));
            list.Add(new BookModel(counter++, "Nerve cells that fire together wire together"));
            list.Add(new BookModel(counter++, "Illusory Body"));
            list.Add(new BookModel(counter++, "Clear Light"));
            list.Add(new BookModel(counter++, "Dream Yoga"));
            list.Add(new BookModel(counter++, "Bardo Yoga"));
            list.Add(new BookModel(counter++, "The 8 Stages of Dissolution"));
            list.Add(new BookModel(counter++, "Going Home"));
            list.Add(new BookModel(counter++, "Phowa"));
            list.Add(new BookModel(counter++, "Phowa 2"));
            list.Add(new BookModel(counter++, "Stop The Noise In Your Head"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "Board Of Directors"));
            list.Add(new BookModel(counter++, "Funny Story"));
            list.Add(new BookModel(counter++, "What Is Chakrasamvara Practice"));
            list.Add(new BookModel(counter++, "Meditations to Transform the Mind"));
            list.Add(new BookModel(counter++, "Song of the Tantric Path"));
            list.Add(new BookModel(counter++, "Brahmanand - Palace in the sky"));
            list.Add(new BookModel(counter++, "Intro Sine Waves"));
            list.Add(new BookModel(counter++, "Sine waves"));
            list.Add(new BookModel(counter++, "Closing"));





        }

        public static LoadKeysChakrasamvara Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysChakrasamvara();
            }

            return _instance;
        }
    }
}