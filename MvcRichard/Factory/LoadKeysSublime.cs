using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysSublime
    {
        //private static LoadKeysSublime _instance;

        public static List<BookModel> list = new List<BookModel>();
        public int counter;


        // Constructor is 'protected'
        public LoadKeysSublime(string chapter)
        {
            list = new List<BookModel>();
            if (chapter == "Sublime")
            {
                list.Add(new BookModel(counter++, "Intro"));
                list.Add(new BookModel(counter++, "The Sublime A Literary and Philosophical Conceptt"));
                list.Add(new BookModel(counter++, "The Sublime in Nature Examples and Analysis"));
                list.Add(new BookModel(counter++, "The Sublime A Feeling of Wonder and Fear"));
                list.Add(new BookModel(counter++, "The Sublime in Eastern Traditions"));
                list.Add(new BookModel(counter++, "Six Yogas of Naropa."));
                list.Add(new BookModel(counter++, "Teachings Of The Dragons Naropa Part 2"));
                list.Add(new BookModel(counter++, "Naropa Commentary"));
                list.Add(new BookModel(counter++, "This is just the start of your training"));
                list.Add(new BookModel(counter++, "The Sublime Unveiled - The Secret Yogas of Tibet by Ian A.Baker"));
                list.Add(new BookModel(counter++, "The Yogis and the Sublime A Spiritual Journey"));
                list.Add(new BookModel(counter++, "The Yoga Sutras Discovering the Sublime"));
                list.Add(new BookModel(counter++, "The Sublime in the Works of Famous Yogis and Mystics"));
                list.Add(new BookModel(counter++, "Tao Te Ching Finding the Sublime in Simplicity"));
                list.Add(new BookModel(counter++, "The Way"));

            }

            if (chapter == "Sublime Kabir and the Sublime")
            {
                list.Add(new BookModel(counter++, "Kabir and the Sublime"));
                list.Add(new BookModel(counter++, "Kabir-Thristy Fish"));
                list.Add(new BookModel(counter++, "Kabir-Thristy Fish"));
                list.Add(new BookModel(counter++, "Kabir-Oh Companion That Abode Is Unmatched"));
                list.Add(new BookModel(counter++, "Kabir-Are you looking for me"));
                list.Add(new BookModel(counter++, "Kabir-Illusion and Reality"));
                list.Add(new BookModel(counter++, "Kabir-Where do you search me"));
                list.Add(new BookModel(counter++, "Kabir-Looking at the grinding stones"));
                list.Add(new BookModel(counter++, "Kabir-I Said To The Wanting-Creature Inside Me"));
                list.Add(new BookModel(counter++, "Kabir-The moon shines in my body"));
                list.Add(new BookModel(counter++, "Kabir-Raindrop"));
                list.Add(new BookModel(counter++, "Kabir-Knowing nothing shuts the iron gates"));
                list.Add(new BookModel(counter++, "Kabir-My body is flooded"));
                list.Add(new BookModel(counter++, "Kabir-The Word"));
                list.Add(new BookModel(counter++, "Kabir-WITHIN this earthen vessel"));
                list.Add(new BookModel(counter++, "Kabir-The Lord is in me"));
                list.Add(new BookModel(counter++, "Kabir-My swan, let us fly to that land"));
                list.Add(new BookModel(counter++, "Kabir-O Slave, liberate yourself"));
                list.Add(new BookModel(counter++, "Kabir-The Bride - Soul"));
                list.Add(new BookModel(counter++, "Kabir-The Guest is inside you, and also inside me"));
                list.Add(new BookModel(counter++, "Kabir-To Be A Slave Of Intensity"));
                list.Add(new BookModel(counter++, "Kabir-O servant, where dost thou seek Me"));
                list.Add(new BookModel(counter++, "Kabir-The Impossible Pass"));
                list.Add(new BookModel(counter++, "Kabir-Plucking your eyebrows"));
                list.Add(new BookModel(counter++, "Kabir-When the Day came"));
                list.Add(new BookModel(counter++, "Kabir-The self forgets itself"));
                list.Add(new BookModel(counter++, "Kabir-Many hoped"));
                list.Add(new BookModel(counter++, "Kabir-It is needless to ask of a saint"));
                list.Add(new BookModel(counter++, "Kabir-Lamps burn in every house"));
                list.Add(new BookModel(counter++, "Kabir-Lift the veil"));
                list.Add(new BookModel(counter++, "Kabir-My body and my mind"));
                list.Add(new BookModel(counter++, "Kabir-O friend!hope for Him whilst you live"));
                list.Add(new BookModel(counter++, "Kabir-O How may I ever express that secret word"));
                list.Add(new BookModel(counter++, "Kabir-Tell me, Brother"));
                list.Add(new BookModel(counter++, "Kabir-Oh Sadhu"));
                list.Add(new BookModel(counter++, "Kabir-THE light of the sun"));
                list.Add(new BookModel(counter++, "Kabir-The middle region of the sky"));
                list.Add(new BookModel(counter++, "Kabir-The river and its waves are one"));
                list.Add(new BookModel(counter++, "Kabir-To what shore would you cross"));
                list.Add(new BookModel(counter++, "Kabir-What kind of God would He be"));
                list.Add(new BookModel(counter++, "Kabir-When He Himself Reveals Himself"));
                list.Add(new BookModel(counter++, "Kabir-Where Spring, the lord of the seasons"));
             

            }

            if (chapter == "Hafiz A Master of Persian Poetry and Mysticism")
            {

                list.Add(new BookModel(counter++, "Hafiz-The Hatcheck Girl"));
                list.Add(new BookModel(counter++, "Hafiz-For years my heart inquired of me‚"));
                list.Add(new BookModel(counter++, "Hafiz-Like The Morning Breeze"));
                list.Add(new BookModel(counter++, "Hafiz-Let Thought Become Your Beautiful Lover"));
                list.Add(new BookModel(counter++, "Hafiz-I Have Learned So Much"));
                list.Add(new BookModel(counter++, "Hafiz-School of Truth"));
                list.Add(new BookModel(counter++, "Hafiz-I've Said It Before and I'll Say It Again"));
                list.Add(new BookModel(counter++, "Hafiz-We Might Have To Medicate You"));
                list.Add(new BookModel(counter++, "Hafiz-No More Leaving"));


            }
            if (chapter == "Sublime Rumi")
            {
                list.Add(new BookModel(counter++, "Rumi-Like this"));
                list.Add(new BookModel(counter++, "Rumi-Love is the Water of Life"));
                list.Add(new BookModel(counter++, "Rumi-A moment of happiness"));
                list.Add(new BookModel(counter++, "Rumi-Lovers"));
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
                list.Add(new BookModel(counter++, "Rumi-I am part of the load"));
            

            }

        

            if (chapter == "Sublime Poets, Mystics and Teachers")
            {

                list.Add(new BookModel(counter++, "Guru Nanak and the Sublime"));
                list.Add(new BookModel(counter++, "Guru Nanak Dev-Quotes 1"));
                list.Add(new BookModel(counter++, "Guru Nanak Dev-Quotes 2"));
                list.Add(new BookModel(counter++, "The Physics of Spirituality"));
                list.Add(new BookModel(counter++, "Bhramand and the Sublime"));
                list.Add(new BookModel(counter++, "Brahmanand-Palace in the sky"));
                list.Add(new BookModel(counter++, "Panpsychism and the Sublime"));
                list.Add(new BookModel(counter++, "Spinoza and the Sublime."));
                list.Add(new BookModel(counter++, "Kabbalah-Revealing the Sublime"));
                list.Add(new BookModel(counter++, "Mitch Ditkoff"));
                list.Add(new BookModel(counter++, "Mitch WHY CHAT GBT THINKS IT'S A GOOD IDEA TO BUY MY NEW BOOK OF POETRY"));
                list.Add(new BookModel(counter++, "Mitch RUMI AND KABIR BOWLING"));
                list.Add(new BookModel(counter++, "Mitch WHY I QUIT POETRY GRADUATE SCHOOL WHEN I WAS 22"));
                list.Add(new BookModel(counter++, "The Incredible Story of Prem Rawat Sharing Inner Peace with the World"));
                list.Add(new BookModel(counter++, "Knowledge"));



            }

            if (chapter == "Sublime Elixers that Exist inside of you")
            {

                list.Add(new BookModel(counter++, "Amrita - The Divine Nectar"));
                list.Add(new BookModel(counter++, "Amrita - our true identity and nectar of immortality"));
                list.Add(new BookModel(counter++, "Kurma Nadi Churning the Ocean for Nectar"));
                list.Add(new BookModel(counter++, "Khechari Mudra (Tongue Lock) Steps, Benefits & More"));
                list.Add(new BookModel(counter++, "Perseverance"));
                list.Add(new BookModel(counter++, "Trillions of nerve cells fire off together"));
                list.Add(new BookModel(counter++, "Karmamudra and the Sublime A Journey of Spiritual Union"));
                list.Add(new BookModel(counter++, "Metaphysical meaning of water(mbd)"));
                list.Add(new BookModel(counter++, "Raising The Chrism"));
                list.Add(new BookModel(counter++, "The Sacred Secret"));
                list.Add(new BookModel(counter++, "Surfing"));
                list.Add(new BookModel(counter++, "Joyce Caldwell"));
                list.Add(new BookModel(counter++, "The Fantastic Connection Between the Sublime and the Monroe Institute"));
                list.Add(new BookModel(counter++, "Closing"));



            }



        }

        //public static LoadKeysSublime Instance()
        //{
        //    // Uses lazy initialization.
        //    // Note: this is not thread safe.
        //    if (_instance == null)
        //    {
        //        _instance = new LoadKeysSublime();
        //    }

        //    return _instance;
        //}
    }
}