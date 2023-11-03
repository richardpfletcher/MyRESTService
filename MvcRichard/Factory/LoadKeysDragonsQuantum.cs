using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDragonsQuantum
    {
        private static LoadKeysDragonsQuantum _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDragonsQuantum()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Mike Reed"));
            list.Add(new BookModel(counter++, "Mike to ChatGBT Can you explain my theory through the eyes of a mystic"));
            list.Add(new BookModel(counter++, "We See Only 1 % Of The Light Spectrum"));
            list.Add(new BookModel(counter++, "Zoran the dragon and the Quantum World"));
            list.Add(new BookModel(counter++, "Adventure"));
            list.Add(new BookModel(counter++, "What is Quantum Physics"));
            list.Add(new BookModel(counter++, "Think Outside Of The Box"));
            list.Add(new BookModel(counter++, "Wave - Particle Duality"));
            list.Add(new BookModel(counter++, "The scientist"));
            list.Add(new BookModel(counter++, "Superposition"));
            list.Add(new BookModel(counter++, "Fine Tune Your Radio Station"));
            list.Add(new BookModel(counter++, "Entanglement Theroy"));
            list.Add(new BookModel(counter++, "Entanglement With God"));
            list.Add(new BookModel(counter++, "The Uncertainty Principle"));
            list.Add(new BookModel(counter++, "Does the universe stop and pay attention"));
            list.Add(new BookModel(counter++, "The Quantum World"));
            list.Add(new BookModel(counter++, "Zoran’s Journey Begins"));
            list.Add(new BookModel(counter++, "Galileo's Telescope"));
            list.Add(new BookModel(counter++, "Zoran, the Dragon and the Quantum Adventure"));
            list.Add(new BookModel(counter++, "The Quantum Realm"));
            list.Add(new BookModel(counter++, "Universe"));
            list.Add(new BookModel(counter++, "Photons, Electrons, and Quarks"));
            list.Add(new BookModel(counter++, "The interaction between photons, electrons, and quarks"));
            list.Add(new BookModel(counter++, "Photons, electrons, and quarks are fundamental particles"));
            list.Add(new BookModel(counter++, "The double split experminent.mThe double split experminent"));
            list.Add(new BookModel(counter++, "Fundamental particles that make up all matter and energy in the universe"));
            list.Add(new BookModel(counter++, "05-05-2022 Double split experiment 2"));
            list.Add(new BookModel(counter++, "Quarks and leptons are fundamental particles"));
            list.Add(new BookModel(counter++, "Dark Matter"));
            list.Add(new BookModel(counter++, "Black Holes"));
            list.Add(new BookModel(counter++, "How do black holes get created"));
            list.Add(new BookModel(counter++, "Stephen Hawking did propose a theory that black holes could be a gateway to another universe"));
            list.Add(new BookModel(counter++, "UFO’s Ridding Gravity Waves"));
            list.Add(new BookModel(counter++, "General relativity"));
            list.Add(new BookModel(counter++, "At the speed of light"));
            list.Add(new BookModel(counter++, "The creatures in this realm"));
            list.Add(new BookModel(counter++, "Emptiness or nothingness"));
            list.Add(new BookModel(counter++, "There are many other dimensions that Zoran could explore"));
            list.Add(new BookModel(counter++, "Zoran and the Quantum Quest"));
            list.Add(new BookModel(counter++, "Space and Time"));
            list.Add(new BookModel(counter++, "The Mysteries of Quantum Physics"));
            list.Add(new BookModel(counter++, "Life’s mystery"));
            list.Add(new BookModel(counter++, "Space and time 2"));
            list.Add(new BookModel(counter++, "Time dilation"));
            list.Add(new BookModel(counter++, "Black Holes and Wormholes"));
            list.Add(new BookModel(counter++, "Quantum Entanglement"));
            list.Add(new BookModel(counter++, "The Fundamental Laws of Nature"));
            list.Add(new BookModel(counter++, "What was his true purpose"));
            list.Add(new BookModel(counter++, "Lesions learned"));
            list.Add(new BookModel(counter++, "Comparison between the traditional school model and Zoran’s approach"));
            list.Add(new BookModel(counter++, "How To Use The Quantum Field 2"));
            list.Add(new BookModel(counter++, "Wow Wow Wow"));
            list.Add(new BookModel(counter++, "Closing"));



        }

        public static LoadKeysDragonsQuantum Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDragonsQuantum();
            }

            return _instance;
        }
    }
}