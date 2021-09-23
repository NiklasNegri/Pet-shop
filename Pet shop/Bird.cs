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
        // I set the properties of all subclasses of animal to private since I dont need to 
        // access or print the values directly from the subclass
        // instead I print the values of the properties through the ToString method
        private bool CanFly { get; set; }
        private double WingSpan { get; set; }
        private string BirdBreed { get; set; }
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
        public override string ToString()
        {
            return base.ToString() + string.Format($"Bird breed: { BirdBreed }, wing span: { WingSpan }, can fly: { CanFly }\n");
        }
    }
}
