using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysJaiJinendra
    {
        private static LoadKeysJaiJinendra _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysJaiJinendra()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Intro Take Two"));
            
            list.Add(new BookModel(counter++, "Jainism Mahavira quotes"));
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
            list.Add(new BookModel(counter++, "Jain Meditation Old School"));
            list.Add(new BookModel(counter++, "Preksha Meditation"));
            list.Add(new BookModel(counter++, "Perception Of Breathing"));
            list.Add(new BookModel(counter++, "Perception Of Alternate Breathing"));
            list.Add(new BookModel(counter++, "Perception Of Alternate Breathing Exercise"));
            list.Add(new BookModel(counter++, "The Kayotsarga"));
            list.Add(new BookModel(counter++, "Pindāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Padāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Rūpāstha Dhyāna"));
            list.Add(new BookModel(counter++, "Rūpātita Dhyāna"));
            list.Add(new BookModel(counter++, "The Spiritual Elevation And Salvation Of The Soul"));
            list.Add(new BookModel(counter++, "Jain Meditation New School"));
            list.Add(new BookModel(counter++, "Relaxation"));
            list.Add(new BookModel(counter++, "Internal Journey"));
            list.Add(new BookModel(counter++, "Modern day version"));
            list.Add(new BookModel(counter++, "Modern day version meditation"));
            list.Add(new BookModel(counter++, "Perception of Breathing New"));
            list.Add(new BookModel(counter++, "SOHUM"));
            list.Add(new BookModel(counter++, "Om Meditation"));
            list.Add(new BookModel(counter++, "Perception of Breathing New"));
            list.Add(new BookModel(counter++, "How To Do Alternate Nostril Breathing(Nadi Shodhana)"));
            list.Add(new BookModel(counter++, "The Breath"));
            list.Add(new BookModel(counter++, "Breathing Through Your Mouth"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Monitoring Your Thoughts And Emotions"));
            list.Add(new BookModel(counter++, "Mind Movies"));
            list.Add(new BookModel(counter++, "11-28-2020 40 Days 40 Nights"));
            list.Add(new BookModel(counter++, "Teachers Pramilaji and Priyaji"));
            list.Add(new BookModel(counter++, "Asanas"));
            list.Add(new BookModel(counter++, "Jain Prānāyāma"));
            list.Add(new BookModel(counter++, "Arugga Bohi Labham Meditation"));
            list.Add(new BookModel(counter++, "Arugga Bohi Labham Chakras"));
            list.Add(new BookModel(counter++, "Arugga Bohi Acupressure"));
            list.Add(new BookModel(counter++, "Arugga Bohi Mantras"));
            list.Add(new BookModel(counter++, "Arugga Bohi Human Anatomy"));
            list.Add(new BookModel(counter++, "Arugga Bohi Seed Therapy"));
            list.Add(new BookModel(counter++, "Arugga Bohi Mudra Healing"));
            list.Add(new BookModel(counter++, "Arugga Bohi Detox Diet and others"));
            list.Add(new BookModel(counter++, "Arugga Bohi Rog Anusar Yoga"));
            list.Add(new BookModel(counter++, "Arugga Bohi Rog Saptu Dhatu 7 tissues"));
            list.Add(new BookModel(counter++, "Arugga Bohi Rog Ritu Charya Seasonings"));


        }

        public static LoadKeysJaiJinendra Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysJaiJinendra();
            }

            return _instance;
        }
    }
}