using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Represents the pet shop and holds value for its money
    /// and current animals for sale.
    /// </summary>
    public class AnimalShop
    {    
        private int ShopMoney { get; set; }
        private List<Animal> animalList { get; set; }
        /// <summary>
        /// The default constructor of AnimalShop creates an object of each Animal subclass 
        /// and adds them to its animalList, also assigns value to ShopMoney. </summary>
        public AnimalShop()
        {
            ShopMoney = 1000;
            Dog defaultDog = new Dog();
            Bird defaultBird = new Bird();
            Spider defaultSpider = new Spider();
            animalList.Add(defaultBird);
            animalList.Add(defaultDog);
            animalList.Add(defaultSpider);
        }
    }
}
