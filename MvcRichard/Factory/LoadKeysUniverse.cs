using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysUniverse
    {
        private static LoadKeysUniverse _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysUniverse()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Life’sMmystery"));
            list.Add(new BookModel(counter++, "Meditation Advice 1"));
            list.Add(new BookModel(counter++, "Patience"));
            list.Add(new BookModel(counter++, "Kindness Is More Powerful Than Anger"));
            list.Add(new BookModel(counter++, "Frustrations"));

            list.Add(new BookModel(counter++, "Change Our Attitudes"));
            list.Add(new BookModel(counter++, "Did You Know That The Universe Is Alive"));
            list.Add(new BookModel(counter++, "Meditation 2-13-2017"));
            list.Add(new BookModel(counter++, "Meditation 2-14-2017"));
            list.Add(new BookModel(counter++, "Meditation Anima"));
            list.Add(new BookModel(counter++, "Evolution Revolution")); //not found
            list.Add(new BookModel(counter++, "Job Interview"));
            list.Add(new BookModel(counter++, "Gasoline On Fire"));
            list.Add(new BookModel(counter++, "Responsive Design"));

            //Sayings 2
            list.Add(new BookModel(counter++, "Are you Experienced"));
            list.Add(new BookModel(counter++, "Behold The Palace In The Sky"));
            list.Add(new BookModel(counter++, "Bird In a Cage"));
            list.Add(new BookModel(counter++, "Brainwash"));
            list.Add(new BookModel(counter++, "Dahlia Lama"));
            list.Add(new BookModel(counter++, "Grace"));
            list.Add(new BookModel(counter++, "How Can You Use An Old Map In The New world"));
            list.Add(new BookModel(counter++, "I listen to the wind of my soul"));
            list.Add(new BookModel(counter++, "I wanted to scream"));
            list.Add(new BookModel(counter++, "Little drops"));
            list.Add(new BookModel(counter++, "My heart is singing"));

            list.Add(new BookModel(counter++, "The candle"));
            list.Add(new BookModel(counter++, "The Christ"));
            list.Add(new BookModel(counter++, "The compass"));
            list.Add(new BookModel(counter++, "The diamond is in the safe"));
            list.Add(new BookModel(counter++, "The Ray of Empowerment"));
            list.Add(new BookModel(counter++, "Tree of Life Prayer"));
            list.Add(new BookModel(counter++, "The Ferry"));
            list.Add(new BookModel(counter++, "The greatest Coach"));
            list.Add(new BookModel(counter++, "The Lighthouse"));
            list.Add(new BookModel(counter++, "The world is not flat"));
            list.Add(new BookModel(counter++, "Your ancestors did not live in a quasar"));
            list.Add(new BookModel(counter++, "Unlimited thought"));
            list.Add(new BookModel(counter++, "Waves upon the shore"));
            list.Add(new BookModel(counter++, "What if"));
            list.Add(new BookModel(counter++, "What precede creation"));

            //sayings 3

            list.Add(new BookModel(counter++, "Anger"));
            list.Add(new BookModel(counter++, "Embrace the monster"));

            list.Add(new BookModel(counter++, "Get rid of your baggage"));
            list.Add(new BookModel(counter++, "Do you know how to listen"));
            list.Add(new BookModel(counter++, "He who hesitates is lost"));
            list.Add(new BookModel(counter++, "Hold your own reins"));
            list.Add(new BookModel(counter++, "Hold your tongue"));
            list.Add(new BookModel(counter++, "How much do your problems weigh"));
            list.Add(new BookModel(counter++, "I’m better than you are"));
            list.Add(new BookModel(counter++, "Look in the mirror"));
            list.Add(new BookModel(counter++, "Man is living in a prison"));
            list.Add(new BookModel(counter++, "Take the elevator"));

            //sayings 4

            list.Add(new BookModel(counter++, "DNA"));
            list.Add(new BookModel(counter++, "Enlightenment"));

            list.Add(new BookModel(counter++, "God talks and listens"));
            list.Add(new BookModel(counter++, "What are you trying to say"));
            list.Add(new BookModel(counter++, "The bridge"));
            list.Add(new BookModel(counter++, "The Mind"));
            list.Add(new BookModel(counter++, "The enemy lies within"));
            list.Add(new BookModel(counter++, "The well"));
            list.Add(new BookModel(counter++, "The Empty Lot"));
            list.Add(new BookModel(counter++, "True knowledge"));
            list.Add(new BookModel(counter++, "Time fly’s"));
            list.Add(new BookModel(counter++, "Voices of the wind"));

            //sayings 5

            list.Add(new BookModel(counter++, "Convert"));
            list.Add(new BookModel(counter++, "Does God have a face"));

            list.Add(new BookModel(counter++, "Entanglement with God"));
            list.Add(new BookModel(counter++, "Feet on the ground head in heaven"));
            list.Add(new BookModel(counter++, "God is ever where but I can’t see it"));
            list.Add(new BookModel(counter++, "Higher Self"));
            list.Add(new BookModel(counter++, "Is a spiritual life boring"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "Practice is the key"));
            list.Add(new BookModel(counter++, "The sound of silence"));
            list.Add(new BookModel(counter++, "You are the company that your keep"));
            list.Add(new BookModel(counter++, "Your house needs dusting"));
            list.Add(new BookModel(counter++, "You can take a horse to water"));


            //sayings 6

            list.Add(new BookModel(counter++, "At the speed of light"));
            list.Add(new BookModel(counter++, "Did Christ meditate"));
            list.Add(new BookModel(counter++, "Laughter"));
            list.Add(new BookModel(counter++, "You are your own doctor"));
            list.Add(new BookModel(counter++, "Listen to your body"));
            list.Add(new BookModel(counter++, "Recalibration"));
            list.Add(new BookModel(counter++, "The inner scientist"));
            list.Add(new BookModel(counter++, "The palace in the sky"));
            list.Add(new BookModel(counter++, "The signs of God are everywhere"));
            list.Add(new BookModel(counter++, "The tuning fork of life"));
            list.Add(new BookModel(counter++, "We are wired for God"));
            list.Add(new BookModel(counter++, "What a game this is"));
            list.Add(new BookModel(counter++, "Your treasure chest"));
            list.Add(new BookModel(counter++, "Hey slow down"));
            list.Add(new BookModel(counter++, "Are there new rules to discover God"));
            list.Add(new BookModel(counter++, "Kindness is my religion"));
            list.Add(new BookModel(counter++, "How many different ways can you say it"));
            list.Add(new BookModel(counter++, "Is there empty space"));
            list.Add(new BookModel(counter++, "The probability of God"));
            list.Add(new BookModel(counter++, "No free rides"));
            list.Add(new BookModel(counter++, "Sat chit ananda"));
            list.Add(new BookModel(counter++, "The storm"));
            



        }

        public static LoadKeysUniverse Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysUniverse();
            }

            return _instance;
        }
    }
}