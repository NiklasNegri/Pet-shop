using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Subclass of Animal.
    /// </summary>
    public class Bird : Animal
    {      
        public bool CanFly { get; private set; }
        public double WingSpan { get; private set; }
        public string BirdBreed { get; private set; }
        /// <summary>
        /// When generating a new object of Bird, the inherited property AnimalSpecies will always be set to "Bird".
        /// The rest have to be passed in on creation. </summary>
        public Bird(string _animalName, int _animalAge, double _animalPrice, bool _canFly, double _wingSpan, string _birdBreed)
        {
            AnimalName = _animalName;
            AnimalAge = _animalAge;
            AnimalPrice = _animalPrice;
            CanFly = _canFly;
            WingSpan = _wingSpan;
            BirdBreed = _birdBreed;
        }
    }
}
