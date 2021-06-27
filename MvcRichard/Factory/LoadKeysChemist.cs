using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysChemist
    {
        private static LoadKeysChemist _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysChemist()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Eight limbs on the tree of life")); 
            list.Add(new BookModel(counter++, "Fourteen Video Game Stages Of Spiritual Development"));
            list.Add(new BookModel(counter++, "Video game of life"));
            list.Add(new BookModel(counter++, "Jain ethics and five vows"));
            list.Add(new BookModel(counter++, "Sat Chit Ananda"));
            list.Add(new BookModel(counter++, "Violence in our leaders"));
            list.Add(new BookModel(counter++, "Did Jainism Help Shape the American Civil Rights Movement"));
            list.Add(new BookModel(counter++, "My Trip to the Land of Gandhi"));
            list.Add(new BookModel(counter++, "My Trip to the Land of Gandhi 2"));
            list.Add(new BookModel(counter++, "Non-violence in protests"));
            list.Add(new BookModel(counter++, "Non-violence in schools"));
            list.Add(new BookModel(counter++, "Non-violence in relationships"));
            list.Add(new BookModel(counter++, "Non-violence in your mind and body"));
            list.Add(new BookModel(counter++, "Emotions"));
            list.Add(new BookModel(counter++, "New Thought"));
            list.Add(new BookModel(counter++, "New Concepts"));
            list.Add(new BookModel(counter++, "New Wiring"));
            list.Add(new BookModel(counter++, "New Personality"));
            list.Add(new BookModel(counter++, "New Human"));
            list.Add(new BookModel(counter++, "You Are Closer Than You Think"));
            list.Add(new BookModel(counter++, "Non-violence in media"));
            list.Add(new BookModel(counter++, "The Drama Queen"));
            list.Add(new BookModel(counter++, "Non-violence in Politics"));
            list.Add(new BookModel(counter++, "Non-violence in economy"));
            list.Add(new BookModel(counter++, "Non-violence in personal beliefs"));
            list.Add(new BookModel(counter++, "Non-violence in diet"));

            list.Add(new BookModel(counter++, "Yamas list of do’s"));
            list.Add(new BookModel(counter++, "Yamas-Sat Chit Ananda"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-What Is Panpsychism"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-Mind and Body"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-Emotions"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-New Thought"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-New Concepts"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-New Wiring"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-New Personalit"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-New Human"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-You Are Closer Than You Think"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-Where Do These Memories Come From"));
            list.Add(new BookModel(counter++, "Shaucha(शौच) purity-Mindfulness"));
            list.Add(new BookModel(counter++, "Āsana Postures"));
            list.Add(new BookModel(counter++, "Āsana Postures-Temple Of God"));
            list.Add(new BookModel(counter++, "Āsana Postures-Chakras"));
            list.Add(new BookModel(counter++, "Āsana Postures-DNA"));
            list.Add(new BookModel(counter++, "Āsana Postures-Bruce Lipton"));
            list.Add(new BookModel(counter++, "Āsana Postures-Endocrine System"));
            list.Add(new BookModel(counter++, "Prānāyāma"));
            list.Add(new BookModel(counter++, "Prānāyāma-The Breath"));
            list.Add(new BookModel(counter++, "Prānāyāma-Breathing Through Your Mouth"));
            list.Add(new BookModel(counter++, "Prānāyāma-Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Pratyāhāra withdrawing of the external senses"));
            list.Add(new BookModel(counter++, "Pratyāhāra-Five Internal Senses"));
            list.Add(new BookModel(counter++, "Dhāraṇā Fixity--Breathe"));
            list.Add(new BookModel(counter++, "Dhāraṇā Fixity-Fixity"));
            list.Add(new BookModel(counter++, "Dhāraṇā Fixity--Recalibrate"));
            list.Add(new BookModel(counter++, "Dhyāna Meditation"));
            list.Add(new BookModel(counter++, "Dhyana Meditation-Simple Meditation"));
            list.Add(new BookModel(counter++, "Dhyana Meditation-Anima"));
            list.Add(new BookModel(counter++, "Dhyana Meditation-Where Would I Be Without Meditation"));
            list.Add(new BookModel(counter++, "Dhyana Meditation-Mediation"));
            list.Add(new BookModel(counter++, "Dhyana Meditation-Carry Your Meditation Into Your Daily Life"));
            list.Add(new BookModel(counter++, "Dhyana Meditation-The Word"));
            list.Add(new BookModel(counter++, "Samādhi समाधि"));
            list.Add(new BookModel(counter++, "Tricks Of the Trade"));
            list.Add(new BookModel(counter++, "The Wonderous Human Body"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "07-14-2019 Your Body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "07-21-2019 How To Use The Quantum Field"));
            list.Add(new BookModel(counter++, "07-21-2019 How To Use The Quantum Field 2"));
            list.Add(new BookModel(counter++, "It's Been There All The Time"));
            list.Add(new BookModel(counter++, "Playing With Your Chemistry Kit"));
            list.Add(new BookModel(counter++, "Your body Is Your Drug Store"));
            list.Add(new BookModel(counter++, "Five Internal Senses"));
            list.Add(new BookModel(counter++, "Garbage Collector For The Mind"));
            list.Add(new BookModel(counter++, "Relax Your Muscles Every Day"));
            list.Add(new BookModel(counter++, "The Path Is what You think It Is"));
            list.Add(new BookModel(counter++, "Is This From A Mystic Or A Sceintist"));
            list.Add(new BookModel(counter++, "Self-Regulate"));
            list.Add(new BookModel(counter++, "Disengage"));
            list.Add(new BookModel(counter++, "Art Of Practice And Creativity" ));

            list.Add(new BookModel(counter++, "Old self and new self"));



            list.Add(new BookModel(counter++, "Your actions create your own future"));

            list.Add(new BookModel(counter++, "Rehearsing"));
            list.Add(new BookModel(counter++, ""));
            list.Add(new BookModel(counter++, "People see the future through the lenses of the past"));

            list.Add(new BookModel(counter++, "Lower the audio of a negative emotion"));

            list.Add(new BookModel(counter++, "Are You Curious or Dull About Life"));

            list.Add(new BookModel(counter++, "Transcendental"));

            list.Add(new BookModel(counter++, "Memory without emotional charge is called wisdom"));

            list.Add(new BookModel(counter++, "Nerve cells that fire together wire together"));

            list.Add(new BookModel(counter++, "You can turn on the stress control by your thoughts alone"));

            list.Add(new BookModel(counter++, "Modify our behaviors reprogram the mind"));

            list.Add(new BookModel(counter++, "Observe vs participate"));

            list.Add(new BookModel(counter++, "The Mind is the brain in action"));

            list.Add(new BookModel(counter++, "Behaviors to match the intention"));

            list.Add(new BookModel(counter++, "BMemorize and act consciously over and over again"));



            list.Add(new BookModel(counter++, "BVictim of your environment"));

            list.Add(new BookModel(counter++, "BNegative Energy of the past"));

            list.Add(new BookModel(counter++, "BNobody changes until you change your energy"));

            list.Add(new BookModel(counter++, "BYour body is your subconscious mind"));

            list.Add(new BookModel(counter++, "BBeing a victim vs being a creator"));

            list.Add(new BookModel(counter++, "BNon - Placebo effect"));

            list.Add(new BookModel(counter++, "BHabits take at least three weeks"));
            list.Add(new BookModel(counter++, "Closing"));










        }

        public static LoadKeysChemist Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysChemist();
            }

            return _instance;
        }
    }
}