using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysTransformation
    {
        private static LoadKeysTransformation _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysTransformation()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));


            list.Add(new BookModel(counter++, "Transform"));
            list.Add(new BookModel(counter++, "Video game of life"));
            list.Add(new BookModel(counter++, "Dog training for the mind"));
            list.Add(new BookModel(counter++, "Kudos"));
            list.Add(new BookModel(counter++, "Faith"));
            list.Add(new BookModel(counter++, "Meditation"));
            list.Add(new BookModel(counter++, "The five omnipresent mental factors"));
            list.Add(new BookModel(counter++, "Feeling"));
            list.Add(new BookModel(counter++, "Discernment"));
            list.Add(new BookModel(counter++, "Intention"));
            list.Add(new BookModel(counter++, "Contact"));
            list.Add(new BookModel(counter++, "Attention"));
            list.Add(new BookModel(counter++, "The five object-ascertaining mental factors"));
            list.Add(new BookModel(counter++, "Aspiration"));
            list.Add(new BookModel(counter++, "Resolve"));
            list.Add(new BookModel(counter++, "Mindfulness"));
            list.Add(new BookModel(counter++, "Wisdom"));
            list.Add(new BookModel(counter++, "Concentration"));
            list.Add(new BookModel(counter++, "The eleven virtuous mental factors are"));
            list.Add(new BookModel(counter++, "Faith"));
            list.Add(new BookModel(counter++, "Shame Self-respect"));
            list.Add(new BookModel(counter++, "Consideration"));
            list.Add(new BookModel(counter++, "Non-attachment Detachment"));
            list.Add(new BookModel(counter++, "Mediation"));
            list.Add(new BookModel(counter++, "Non-hatred"));
            list.Add(new BookModel(counter++, "Non-ignorance"));
            list.Add(new BookModel(counter++, "Diligence"));
            list.Add(new BookModel(counter++, "Mental pliancy")); 
            list.Add(new BookModel(counter++, "Conscientiousness"));
            list.Add(new BookModel(counter++, "Equanimity"));
            list.Add(new BookModel(counter++, "Non-harmfulness"));
            list.Add(new BookModel(counter++, "Contact"));
            list.Add(new BookModel(counter++, "Attention"));
            list.Add(new BookModel(counter++, "The six primary afflictions"));
            list.Add(new BookModel(counter++, "Ignorance"));
            list.Add(new BookModel(counter++, "Innate ignorance"));
            list.Add(new BookModel(counter++, "Intellectually acquired ignorance"));
            list.Add(new BookModel(counter++, "Ignorance that is the root of cyclic existence"));
            list.Add(new BookModel(counter++, "The ten afflictions are"));
            list.Add(new BookModel(counter++, "Attachment"));
            list.Add(new BookModel(counter++, "Anger"));
            list.Add(new BookModel(counter++, "Arrogance"));
            list.Add(new BookModel(counter++, "Lesser arrogance"));
            list.Add(new BookModel(counter++, "Greater arrogance"));
            list.Add(new BookModel(counter++, "Arrogance beyond arrogance"));
            list.Add(new BookModel(counter++, "Arrogance of thinking"));
            list.Add(new BookModel(counter++, "Arrogance of conceit"));
            list.Add(new BookModel(counter++, "Arrogance of slight inferiority"));
            list.Add(new BookModel(counter++, "Wrongful arrogance"));
            list.Add(new BookModel(counter++, "Ignorance afflication"));
            list.Add(new BookModel(counter++, "View of the transitory collection"));
            list.Add(new BookModel(counter++, "View holding to extremes"));
            list.Add(new BookModel(counter++, "Belief in the supremacy of wrong views"));
            list.Add(new BookModel(counter++, "Belief in the supremacy of mistaken ethics"));
            list.Add(new BookModel(counter++, "Afflictive Doubt"));
            list.Add(new BookModel(counter++, "Wrong view"));
            list.Add(new BookModel(counter++, "The twenty secondary afflictions"));
            list.Add(new BookModel(counter++, "Vindictiveness"));
            list.Add(new BookModel(counter++, "Concealment"));
            list.Add(new BookModel(counter++, "Pretension"));
            list.Add(new BookModel(counter++, "Dissimulation"));
            list.Add(new BookModel(counter++, "Harmfulness"));
            list.Add(new BookModel(counter++, "Shamelessness"));
            list.Add(new BookModel(counter++, "Inconsideration"));
            list.Add(new BookModel(counter++, "Dullness"));
            list.Add(new BookModel(counter++, "Afflictive"));
            list.Add(new BookModel(counter++, "Non-faith"));
            list.Add(new BookModel(counter++, "Laziness"));
            list.Add(new BookModel(counter++, "Non-conscientiousness"));
            list.Add(new BookModel(counter++, "Forgetfulness"));
            list.Add(new BookModel(counter++, "Non-alertness"));
            list.Add(new BookModel(counter++, "Distraction"));
            list.Add(new BookModel(counter++, "Sleep"));
            list.Add(new BookModel(counter++, "Sleeping Meditation"));
            list.Add(new BookModel(counter++, "Regret"));
            list.Add(new BookModel(counter++, "General Investigation"));
            list.Add(new BookModel(counter++, "Analysis"));



        }

        public static LoadKeysTransformation Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysTransformation();
            }

            return _instance;
        }
    }
}