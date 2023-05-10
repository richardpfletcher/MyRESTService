using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysBeyond
    {
        private static LoadKeysBeyond _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysBeyond()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));

            list.Add(new BookModel(counter++, "Stunning James Webb Space Telescope photo shows merging galaxies shining with light of a trillion suns"));
            list.Add(new BookModel(counter++, "Webb telescope captures glowing starburst as galaxies collide"));
            list.Add(new BookModel(counter++, "JWST spectrometer refines redshifts of distant galaxies"));
list.Add(new BookModel(counter++, "Webb space telescope shows off ‘amazing’ power by spotting compact galaxy"));
            list.Add(new BookModel(counter++, "James Webb Space Telescope keeps finding galaxies that shouldn’t exist, scientist warns"));
            list.Add(new BookModel(counter++, "James Webb discoveries are challenging what we know about the universe’s evolution"));
            list.Add(new BookModel(counter++, "One of the oldest galaxies ever was found with James Webb Space Telescope"));
            list.Add(new BookModel(counter++, "This JWST Photo Of The Youngest Known Exploding Star In Our Galaxy Is Incredible"));
            list.Add(new BookModel(counter++, "Webb telescope flexes its muscle with this deep, deep view into space"));
            list.Add(new BookModel(counter++, "James Webb Space Telescope Captures Youngest Supernova Remnant in the Milky Way"));
            list.Add(new BookModel(counter++, "Space Telescope revealing new details of the early universe"));
            list.Add(new BookModel(counter++, "The Science of Sirius Mythology"));
            list.Add(new BookModel(counter++, "Sine waves"));
            list.Add(new BookModel(counter++, "Binary Stars"));
            list.Add(new BookModel(counter++, "The Great Central Sun"));
            list.Add(new BookModel(counter++, "The central sun"));
            list.Add(new BookModel(counter++, "Imagine the whole universe wisdom exists inside of your DNA"));
            list.Add(new BookModel(counter++, "Closing"));





        }

        public static LoadKeysBeyond Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysBeyond();
            }

            return _instance;
        }
    }
}