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
        public bool IsPoisonous { get; private set; }
        public int AmountEyes { get; private set; }
        public string SpiderSpecies { get; private set; }
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
    }  
}
