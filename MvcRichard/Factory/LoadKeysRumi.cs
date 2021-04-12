using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysRumi
    {
        private static LoadKeysRumi _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysRumi()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Aboriginal Dreamtime"));


            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Childhood"));
            list.Add(new BookModel(counter++, "Meeting his teacher Shams of Tabriz"));
            list.Add(new BookModel(counter++, "Wonderful Years With My Master"));
            list.Add(new BookModel(counter++, "Whirling Dervishes"));
            list.Add(new BookModel(counter++, "Rumi-Like this"));
            list.Add(new BookModel(counter++, "Rumi-Lovers"));
            list.Add(new BookModel(counter++, "Rumi-Love is the Water of Life"));
            list.Add(new BookModel(counter++, "Rumi-A moment of happiness"));
            list.Add(new BookModel(counter++, "Rumi-All through eternity"));
            list.Add(new BookModel(counter++, "Rumi-This is love to fly toward a secret sky"));
            list.Add(new BookModel(counter++, "Rumi-Love is reckless"));
            list.Add(new BookModel(counter++, "Rumi-I am a sculptor, a molder of form"));
            list.Add(new BookModel(counter++, "Rumi-Passion makes the old medicine new"));
            list.Add(new BookModel(counter++, "Rumi-The beauty of the heart"));
            list.Add(new BookModel(counter++, "Rumi-I am only the house of your beloved"));
            list.Add(new BookModel(counter++, "Rumi-The springtime of Lovers has come"));
            list.Add(new BookModel(counter++, "Rumi-Love has nothing to do with"));
            list.Add(new BookModel(counter++, "Rumi-When the rose is gone"));
            list.Add(new BookModel(counter++, "Rumi-Because I cannot sleep"));
            list.Add(new BookModel(counter++, "Rumi-Who is at my door"));
            list.Add(new BookModel(counter++, "Rumi-Confused and distraught"));
            list.Add(new BookModel(counter++, "Rumi-I will beguile him with the tongue"));
            list.Add(new BookModel(counter++, "Rumi-I have come so that, tugging your ear"));
            list.Add(new BookModel(counter++, "Rumi-A New Rule"));
            list.Add(new BookModel(counter++, "Rumi-Ode 2180"));
            list.Add(new BookModel(counter++, "Rumi-This is love to fly to heaven"));
            list.Add(new BookModel(counter++, "Rumi-Sweetly parading you go my soul of soul"));
            list.Add(new BookModel(counter++, "Rumi-Be Lost in the Call"));
            list.Add(new BookModel(counter++, "Rumi-O you who’ve gone on pilgrimage"));
            list.Add(new BookModel(counter++, "Rumi-if a tree could wander"));
            list.Add(new BookModel(counter++, "Rumi-Come, come, whoever you are"));
            list.Add(new BookModel(counter++, "Rumi-On the Deathbed"));
            list.Add(new BookModel(counter++, "Rumi-This Marriage"));
            list.Add(new BookModel(counter++, "Rumi-This World Which Is Made of Our Love"));
            list.Add(new BookModel(counter++, "Rumi-The drum of the realization"));
            list.Add(new BookModel(counter++, "Rumi-Mystic Odes 473"));
            list.Add(new BookModel(counter++, "Rumi-Our death is our wedding with eternity"));
            list.Add(new BookModel(counter++, "Rumi-Mystic Odes 833"));
            list.Add(new BookModel(counter++, "Rumi-These spiritual window-shoppers"));
            list.Add(new BookModel(counter++, "Rumi-I died"));
            list.Add(new BookModel(counter++, "Rumi-Gone to the Unseen"));
            list.Add(new BookModel(counter++, "Rumi-How did you get away"));
            list.Add(new BookModel(counter++, "Rumi-He Comes"));
            list.Add(new BookModel(counter++, "Rumi-Poor copies out of heaven’s originals"));
            list.Add(new BookModel(counter++, "Rumi-Departure"));
            list.Add(new BookModel(counter++, "Rumi-The Spirit Of The Saints"));
            list.Add(new BookModel(counter++, "Rumi-The True Sufi"));
            list.Add(new BookModel(counter++, "Rumi-The Unseen Power"));
            list.Add(new BookModel(counter++, "Rumi-The Progress Of Man"));
            list.Add(new BookModel(counter++, "Rumi-Reality And Appearance"));
            list.Add(new BookModel(counter++, "Rumi-Descent"));
            list.Add(new BookModel(counter++, "Rumi -I am part of the load"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - I Am The Soul"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Beauty of the Heart"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Ecstatic Motion"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Everything"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Raise Your Words"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Sorrow"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Be Like"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Guest House"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Something"));
            list.Add(new BookModel(counter++, "John Fletcher - Rumi - Hearts Desire"));
            list.Add(new BookModel(counter++, "Rumi On love"));

          


        }

        public static LoadKeysRumi Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysRumi();
            }

            return _instance;
        }
    }
}