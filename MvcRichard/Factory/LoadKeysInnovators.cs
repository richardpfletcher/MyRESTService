using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysInnovators
    {
        private static LoadKeysInnovators _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysInnovators()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "House Of The Future"));
            list.Add(new BookModel(counter++, "My Father Teaching Us Exercises"));
            list.Add(new BookModel(counter++, "Mentors"));
            list.Add(new BookModel(counter++, "Betty Topalion Poetry Assignment"));
            list.Add(new BookModel(counter++, "Joe "));
            list.Add(new BookModel(counter++, "Monroe Institute"));
            list.Add(new BookModel(counter++, "Monroe side a part 1"));
            list.Add(new BookModel(counter++, "Monroe side a part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 1"));
            list.Add(new BookModel(counter++, "Monroe Experience Part 2"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 1 side a"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 2 side a"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 3 side a"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 4"));
            list.Add(new BookModel(counter++, "Monroe Adventure 1985 part 5"));
            list.Add(new BookModel(counter++, "35 years later"));
            list.Add(new BookModel(counter++, "John Baier"));
            list.Add(new BookModel(counter++, "Harry Bartz"));
            list.Add(new BookModel(counter++, "Donn Rochlin"));
            list.Add(new BookModel(counter++, "Talk Story with Donn Rochlin"));
            list.Add(new BookModel(counter++, "Donn Rochlin-Dancing Ants"));
            list.Add(new BookModel(counter++, " Schweizer"));
            list.Add(new BookModel(counter++, "Talk Story with David Schweizer"));
            list.Add(new BookModel(counter++, "John Slowsky"));
            list.Add(new BookModel(counter++, "NICK ROTH"));
            list.Add(new BookModel(counter++, "Talk Story with Nick Roth"));
            list.Add(new BookModel(counter++, "First Time Meeting Zoran"));
            list.Add(new BookModel(counter++, "Ancestors"));
            list.Add(new BookModel(counter++, "The Lyrics Of The Song"));
            list.Add(new BookModel(counter++, "Johnny The Music Maker"));
            list.Add(new BookModel(counter++, "My Twin Brother"));
            list.Add(new BookModel(counter++, "Galileo's Telescope Instrumental"));
            list.Add(new BookModel(counter++, "Zach GLYPHOSATE +TOXINS"));
            list.Add(new BookModel(counter++, "Zack Bush"));
            list.Add(new BookModel(counter++, "Zach Proactive Ways"));
            list.Add(new BookModel(counter++, "Zach Roll in the dirt"));
            list.Add(new BookModel(counter++, "THIS Is Harming Your Brain Everyday with Zach Bush"));
            list.Add(new BookModel(counter++, "05-08-2022 Science can be very biased"));
            list.Add(new BookModel(counter++, "09-01-2019 Age Is Timeless"));
            list.Add(new BookModel(counter++, "Jason Fong"));
            list.Add(new BookModel(counter++, "Interview With Dr Jason Fung and Gary Taubes"));
            list.Add(new BookModel(counter++, "David "));
            list.Add(new BookModel(counter++, "REVERSE AGING How To Extend Your Lifespan OVER 120 YEARS David Sinclair Lewis Howes"));
            list.Add(new BookModel(counter++, " Designed By God"));
            list.Add(new BookModel(counter++, "Did Jainism Help Shape the American Civil Rights Movemenl"));
            list.Add(new BookModel(counter++, "Buck the system"));
            list.Add(new BookModel(counter++, "Jain Intro"));
            list.Add(new BookModel(counter++, "Jain Intro Take Two"));
            list.Add(new BookModel(counter++, "Jainism Mahavira quotes"));
            list.Add(new BookModel(counter++, "Joe Dispenza"));
            list.Add(new BookModel(counter++, "Kryon"));
            list.Add(new BookModel(counter++, "KRYON Can You Change Your Biology"));
            list.Add(new BookModel(counter++, "Jason Fong"));
            list.Add(new BookModel(counter++, "Zoran 5-2-87 side a"));
            list.Add(new BookModel(counter++, "Zoran 5-2-87 side b"));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 1 side a"));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 1 side b"));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 2 side "));
            list.Add(new BookModel(counter++, "Zoran 7-19-87 part 2 side b"));
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side a"));
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side b"));
            list.Add(new BookModel(counter++, "Space Ride -Zoran"));
            list.Add(new BookModel(counter++, "Michah"));
            list.Add(new BookModel(counter++, "Inner Game of Tennis"));
            list.Add(new BookModel(counter++, "Peace Education Program"));
            list.Add(new BookModel(counter++, "Man Is At His Best When In Peace – Prem Rawat"));
            list.Add(new BookModel(counter++, "Inside peace"));
            list.Add(new BookModel(counter++, "Hallelujah Leonard Cohen"));
            list.Add(new BookModel(counter++, "Hallelujah Leonard Cohen Original Best Version"));
            list.Add(new BookModel(counter++, "KD Lang sings Leonard Cohens Hallelujah"));
            list.Add(new BookModel(counter++, "Closing"));




        }

        public static LoadKeysInnovators Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysInnovators();
            }

            return _instance;
        }
    }
}