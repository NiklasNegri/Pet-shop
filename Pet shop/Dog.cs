using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Subclass of Animal.
    /// </summary>
    public class Dog : Animal
    {
        public bool IsCastrated { get; private set; }
        public double DogAge { get; private set; }
        public string DogBreed { get; private set; }
        /// <summary>
        /// When generating a new object of Dog, the inherited property AnimalSpecies will always be set to "Dog".
        /// The rest have to be passed in on creation. </summary>
        public Dog(string _animalName, int _animalAge, double _animalPrice, bool _isCastrated, string _dogBreed)
        {
            AnimalName = _animalName;
            AnimalAge = _animalAge;
            AnimalPrice = _animalPrice;
            DogAge = AnimalAge * 7;
            IsCastrated = _isCastrated;
            DogBreed = _dogBreed;
        }
    }
}
