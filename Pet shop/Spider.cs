using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Subclass of Animal.
    /// </summary>
    public class Spider : Animal
    {
        // I set the properties of all subclasses of animal to private since I dont need to 
        // access or print the values directly from the subclass
        // instead I print the values of the properties through the ToString method
        private bool IsPoisonous { get; set; }
        private int AmountEyes { get; set; }
        private string SpiderSpecies { get; set; }
        /// <summary>
        /// When generating a new object of Spider, the inherited property AnimalSpecies will always be set to "Spider".
        /// The rest have to be passed in on creation. </summary>
        public Spider(string _animalName, int _animalAge, double _animalPrice, bool _isPoisonous, int _amountEyes, string _spiderSpecies)
        {
            AnimalName = _animalName;
            AnimalAge = _animalAge;
            AnimalPrice = _animalPrice;
            IsPoisonous = _isPoisonous;
            AmountEyes = _amountEyes;
            SpiderSpecies = _spiderSpecies;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"Spider species: { SpiderSpecies }, amount of eyes: { AmountEyes }, is poisonous: { IsPoisonous }\n");
        }
    }  
}
