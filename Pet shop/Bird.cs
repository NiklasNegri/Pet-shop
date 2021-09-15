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
        private bool CanFly { get; set; }
        private double WingSpan { get; set; }
        private string BirdBreed { get; set; }
        /// <summary>
        /// The default constructor of <c>Bird</c> assigns values to all of its properties
        /// when generating new objects. </summary>
        public Bird()
        {      
            AnimalSpecies = "Bird";
            AnimalName = "Chicken";
            AnimalAge = 5;
            AnimalPrice = 5;
            CanFly = false;
            WingSpan = 7.3;
            BirdBreed = "Hen";
        }
        /// <summary>
        /// When generating a new object of Bird, the inherited property AnimalSpecies will always be set to "Bird".
        /// The rest have to be passed in on creation. </summary>
        public Bird(string _animalName, int _animalAge, double _animalPrice, bool _canFly, double _wingSpan, string _birdBreed)
        {           
            AnimalSpecies = "Bird";
            AnimalName = _animalName;
            AnimalAge = _animalAge;
            AnimalPrice = _animalPrice;
            CanFly = _canFly;
            WingSpan = _wingSpan;
            BirdBreed = _birdBreed;
        }
        /// <summary>
        /// Gives access to values of inherited and private properties. </summary>
        public override string ToString()
        {
            return base.ToString() + string.Format($"Bird breed: { BirdBreed }, wing span: { WingSpan }, able to fly: { CanFly }\n");
        }
    }
}
