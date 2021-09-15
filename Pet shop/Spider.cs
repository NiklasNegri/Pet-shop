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
        private bool IsPoisonous { get; set; }
        private int AmountEyes { get; set; }
        private string SpiderSpecies { get; set; }
        /// <summary>
        /// The default constructor of <c>Spider</c> assigns values to all of its properties
        /// when generating new objects. </summary>
        public Spider()
        {
            AnimalSpecies = "Spider";
            AnimalName = "Chicken";
            AnimalAge = 5;
            AnimalPrice = 5;
            IsPoisonous= false;
            AmountEyes = 8;
            SpiderSpecies = "Tarantula";
        }
        /// <summary>
        /// When generating a new object of Spider, the inherited property AnimalSpecies will always be set to "Spider".
        /// The rest have to be passed in on creation. </summary>
        public Spider(string _animalName, int _animalAge, double _animalPrice, bool _isPoisonous, int _amountEyes, string _spiderSpecies)
        {
            AnimalSpecies = "Spider";
            AnimalName = _animalName;
            AnimalAge = _animalAge;
            AnimalPrice = _animalPrice;
            IsPoisonous = _isPoisonous;
            AmountEyes = _amountEyes;
            SpiderSpecies = _spiderSpecies;
        }
        /// <summary>
        /// Returns inherited ToString() method from Animal first
        /// then the overridden version with private variables.</summary>
        public override string ToString()
        {
            return base.ToString() + string.Format($"Spider species: { SpiderSpecies }, is poisonous: { IsPoisonous } and it has { AmountEyes } eyes\n");
        }
    }  
}
