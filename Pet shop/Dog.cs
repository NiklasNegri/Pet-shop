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
        private bool IsCastrated { get; set; } = false;
        private double DogAge { get; set; }
        private string DogBreed { get; set; }
        /// <summary>
        /// The default constructor of <c>Dog</c> assigns values to all of its properties
        /// when generating new objects without sending in parameters. </summary>
        public Dog()
        {
            AnimalSpecies = "Dog";
            AnimalName = "Fido";
            AnimalPrice = 5;
            AnimalAge = 12;
            DogAge = AnimalAge * 7;
            IsCastrated = false;
            DogBreed = "Labrador";
        }
        /// <summary>
        /// When generating a new object of Dog, the inherited property AnimalSpecies will always be set to "Dog".
        /// The rest have to be passed in on creation. </summary>
        public Dog(string _animalName, int _animalAge, double _animalPrice, bool _isCastrated, string _dogBreed)
        {
            AnimalSpecies = "Dog";
            AnimalName = _animalName;
            AnimalAge = _animalAge;
            AnimalPrice = _animalPrice;
            DogAge = AnimalAge * 7;
            IsCastrated = _isCastrated;
            DogBreed = _dogBreed;
        }
    }
}
