using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysActions
    {
        private static LoadKeysActions _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysActions()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "intro"));

            //sayings 7

            list.Add(new BookModel(counter++, "Are we wired for God"));
            list.Add(new BookModel(counter++, "Can you experience God while you are alive"));
            list.Add(new BookModel(counter++, "I respect all religions"));
            list.Add(new BookModel(counter++, "Change your attitude"));
            list.Add(new BookModel(counter++, "The amount of effort"));

            list.Add(new BookModel(counter++, "Dew drops in the desert"));
            list.Add(new BookModel(counter++, "Feet on the ground"));
            list.Add(new BookModel(counter++, "Five internal senses"));
            list.Add(new BookModel(counter++, "Forgiveness is the way"));
            list.Add(new BookModel(counter++, "From darkness to light"));
            list.Add(new BookModel(counter++, "The light of God")); //not found
            list.Add(new BookModel(counter++, "The savior"));
            list.Add(new BookModel(counter++, "What is your higher self"));
            list.Add(new BookModel(counter++, "Why were we never told"));


            list.Add(new BookModel(counter++, "What if"));
            list.Add(new BookModel(counter++, "Words have power"));
            list.Add(new BookModel(counter++, "Crystal Clear"));
            list.Add(new BookModel(counter++, "Five internal senses"));
            list.Add(new BookModel(counter++, "I don’t know why people pass this up"));
            list.Add(new BookModel(counter++, "There are sign post of God everywhere"));
            list.Add(new BookModel(counter++, "It’s time for a new act"));

            //sayings 8

            list.Add(new BookModel(counter++, "The breath"));
            list.Add(new BookModel(counter++, "The mind is a powerful thing"));
            list.Add(new BookModel(counter++, "The mirror"));
            list.Add(new BookModel(counter++, "Sit still and listen"));
            list.Add(new BookModel(counter++, "You are what you think you are"));
            list.Add(new BookModel(counter++, "Masters and students"));
            list.Add(new BookModel(counter++, "Dance with life"));
            list.Add(new BookModel(counter++, "Distracted"));
            list.Add(new BookModel(counter++, "Angels falling from heaven"));
            list.Add(new BookModel(counter++, "The enlightened one"));
            list.Add(new BookModel(counter++, "Tolearance"));
            list.Add(new BookModel(counter++, "Balance the ego"));
            list.Add(new BookModel(counter++, "The drug within"));
            list.Add(new BookModel(counter++, "Take care of your body"));
            list.Add(new BookModel(counter++, "Silence"));
            list.Add(new BookModel(counter++, "How do I meditate"));
            list.Add(new BookModel(counter++, "If I could recommend one thing"));
            list.Add(new BookModel(counter++, "Man biggest obstacle"));
           

            //sayings 9

            list.Add(new BookModel(counter++, "Why weren’t we taught where to look for God"));
            list.Add(new BookModel(counter++, "Impersonal God"));
            list.Add(new BookModel(counter++, "Prison"));
            list.Add(new BookModel(counter++, "Guru"));
            list.Add(new BookModel(counter++, "The wheel of life"));
            list.Add(new BookModel(counter++, "Brainwash"));
            list.Add(new BookModel(counter++, "Questions"));
            list.Add(new BookModel(counter++, "Ponder it over"));
            list.Add(new BookModel(counter++, "Goodie two shoes"));
            list.Add(new BookModel(counter++, "Converting"));
            list.Add(new BookModel(counter++, "Where are you going my friend"));
            list.Add(new BookModel(counter++, "The spark of the divine"));
            list.Add(new BookModel(counter++, "The afterlife"));
            list.Add(new BookModel(counter++, "Books"));
            list.Add(new BookModel(counter++, "Eons"));
            list.Add(new BookModel(counter++, "The journey"));
            list.Add(new BookModel(counter++, "To solve a problem"));
            list.Add(new BookModel(counter++, "The sweet spot"));
            list.Add(new BookModel(counter++, "Mother’s little helpers"));
            list.Add(new BookModel(counter++, "Does the shoe fit"));
            list.Add(new BookModel(counter++, "Help is already there"));
            list.Add(new BookModel(counter++, "I like the wine that I have been become"));
            list.Add(new BookModel(counter++, "Passages of time"));
            list.Add(new BookModel(counter++, "Prison"));
            list.Add(new BookModel(counter++, "Light your candle"));
            list.Add(new BookModel(counter++, "The peace bomb"));
            list.Add(new BookModel(counter++, "The calculator"));
            list.Add(new BookModel(counter++, "Cross the bridge"));
           
            //sayings 10
            list.Add(new BookModel(counter++, "Does life throws you a curve ball"));
            list.Add(new BookModel(counter++, "Happiness lies inside"));
            list.Add(new BookModel(counter++, "One rain drop"));
            list.Add(new BookModel(counter++, "Who am I"));
            list.Add(new BookModel(counter++, "The mind is a mirror"));
            list.Add(new BookModel(counter++, "Mosquito itch"));
            list.Add(new BookModel(counter++, "The universe exists inside of you"));
            list.Add(new BookModel(counter++, "We are all actors in life"));
            list.Add(new BookModel(counter++, "Who were you before you were born"));
            list.Add(new BookModel(counter++, "There are many rooms in the mansion"));
            list.Add(new BookModel(counter++, "This is a practical path"));
            list.Add(new BookModel(counter++, "All religions are pointing the way"));
            list.Add(new BookModel(counter++, "The book of life"));
            list.Add(new BookModel(counter++, "Throw away the anger"));
            list.Add(new BookModel(counter++, "True nature of the mind"));
            list.Add(new BookModel(counter++, "Your mind wants peace"));
            list.Add(new BookModel(counter++, "You are a genie"));
            list.Add(new BookModel(counter++, "Take care of your body"));
            list.Add(new BookModel(counter++, "Signs are everywhere"));
            list.Add(new BookModel(counter++, "Give up"));
            list.Add(new BookModel(counter++, "Do you remember who you are"));
            list.Add(new BookModel(counter++, "Behind a challenge is a solution"));
            list.Add(new BookModel(counter++, "Have you ever tries to meditate"));
            



        }

        public static LoadKeysActions Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysActions();
            }

            return _instance;
        }
    }
}