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
        // I set the properties of all subclasses of animal to private since I dont need to 
        // access or print the values directly from the subclass
        // instead I print the values of the properties through the ToString method
        private bool IsCastrated { get; set; }
        private double DogAge { get; set; }
        private string DogBreed { get; set; }
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
        public override string ToString()
        {
            // I dont return the base.ToString for dog since I only want to print DogAge and not AnimalAge
            // therefore I override the whole method inherited from Animal
            return string.Format($"Animal type: { GetType().Name }, name: { AnimalName }, age (dog years): { DogAge }, price: { AnimalPrice }\n" +
                $"Dog breed: { DogBreed }, is castrated: { IsCastrated }\n");
        }
    }
}
