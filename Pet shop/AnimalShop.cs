using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Represents the pet shop and holds value for its money
    /// and current animals for sale. </summary>
    public class AnimalShop
    {
        // I put these properties to public since I want to access the values from outside the class
        // however I dont want to change the values outside of the class so I set the setter to private
        public double ShopMoney { get; private set; }
        public List<Animal> animalList { get; private set; }
        /// <summary>
        /// The default constructor of AnimalShop creates an instance of the animalList list
        /// and sets the value of ShopMoney to 0. </summary>
        public AnimalShop()
        {
            ShopMoney = 0;
            animalList = new List<Animal>();
        }
        /// <summary>
        /// This constructor of AnimalShop takes a double as a parameter and lets the user
        /// decide the value of ShopMoney when instancing an object of this class
        /// </summary>
        public AnimalShop(double _shopMoney)
        {
            ShopMoney = _shopMoney;
            animalList = new List<Animal>();
        }
        /// <summary>
        /// The method SellAnimal takes a string as a parameter and looks for a subclass of Animal with the
        /// same name as the string and returns that Animal if found, else returns null
        /// </summary>
        public Animal SellAnimal(string animalType)
        {
            Animal sellAnimal = null;
            foreach (var animal in animalList)
            {
                if (animal.GetType().Name == animalType)
                {
                    ShopMoney += animal.AnimalPrice;
                    Console.WriteLine($"Purchasing { animal.GetType().Name } for { animal.AnimalPrice }");
                    sellAnimal = animal;
                }
            }
            if (sellAnimal == null)
            {
                Console.WriteLine("Shop does not have that animal for sale!\n");
            }
            return sellAnimal;
        }
    }
}
