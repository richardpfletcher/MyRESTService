using MvcRichard.Models;
using System.Collections.Generic;

namespace MvcRichard.Factory
{
    internal class LoadKeysDreamTime
    {
        private static LoadKeysDreamTime _instance;

        public static List<BookModel> list = new List<BookModel>();

        // Constructor is 'protected'
        protected LoadKeysDreamTime()
        {
            int counter = 0;
            //talks

            list.Add(new BookModel(counter++, "Intro"));
            list.Add(new BookModel(counter++, "Aboriginal Dreamtime"));

            list.Add(new BookModel(counter++, "Aboriginal-Quotes 1"));
            list.Add(new BookModel(counter++, "Instructors"));
            list.Add(new BookModel(counter++, "Seed language"));
            
            list.Add(new BookModel(counter++, "You know me but you don’t know me"));
            list.Add(new BookModel(counter++, "Message8"));
            list.Add(new BookModel(counter++, "Altered states of consciousness"));
            list.Add(new BookModel(counter++, "Painting ourselves"));

            list.Add(new BookModel(counter++, "Deep listening (dadirri)"));
            list.Add(new BookModel(counter++, "Listening"));
            list.Add(new BookModel(counter++, "I Can't See It So It Can't Be Real"));
            list.Add(new BookModel(counter++, "Inside Outside"));

            list.Add(new BookModel(counter++, "Beings"));
            list.Add(new BookModel(counter++, "Songlines"));
            list.Add(new BookModel(counter++, "Excerpt 1"));
            list.Add(new BookModel(counter++, "Excerpt 2"));
            list.Add(new BookModel(counter++, "The seven sisters of the Pleiades"));
            list.Add(new BookModel(counter++, "Excerpt 3"));
            list.Add(new BookModel(counter++, "Take Me To Your Leader"));
            list.Add(new BookModel(counter++, "Pleasant surprise"));
            list.Add(new BookModel(counter++, "Sedona"));
            list.Add(new BookModel(counter++, "Naval Special Warfare - Meeting Alien"));
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side a"));
            list.Add(new BookModel(counter++, "Zoran May 20 1990 side b"));
            list.Add(new BookModel(counter++, "Gaia Principle"));

            list.Add(new BookModel(counter++, "Message1"));
            list.Add(new BookModel(counter++, "Message2"));
            list.Add(new BookModel(counter++, "Message3"));
            list.Add(new BookModel(counter++, "Message4"));
            list.Add(new BookModel(counter++, "Message5"));
            list.Add(new BookModel(counter++, "Message6"));
            list.Add(new BookModel(counter++, "Message7"));
            
            list.Add(new BookModel(counter++, "Message9)"));
            list.Add(new BookModel(counter++, "Message10"));
            list.Add(new BookModel(counter++, "Message11"));
            list.Add(new BookModel(counter++, "Message12"));
            list.Add(new BookModel(counter++, "Message13"));
            list.Add(new BookModel(counter++, "Message14"));
            list.Add(new BookModel(counter++, "Message15"));

            list.Add(new BookModel(counter++, "Bandaiyan"));
            list.Add(new BookModel(counter++, "Sacred Sites Sacred Sights"));
            list.Add(new BookModel(counter++, "Walking Pilgrimage"));
            list.Add(new BookModel(counter++, "Epiphany"));
            list.Add(new BookModel(counter++, "Souls of our feet Souls"));
            list.Add(new BookModel(counter++, "Sacred Fires"));

            list.Add(new BookModel(counter++, "Fire Walking"));
            list.Add(new BookModel(counter++, "WuDu"));
            list.Add(new BookModel(counter++, "Birds taught aboriginals to sing"));
            list.Add(new BookModel(counter++, "Dreaming ears dreaming eyes"));
            list.Add(new BookModel(counter++, "Sound of the grass growing"));

            list.Add(new BookModel(counter++, "Source"));
           

            
          

           

            





































        }

        public static LoadKeysDreamTime Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new LoadKeysDreamTime();
            }

            return _instance;
        }
    }
}