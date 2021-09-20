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
        private double shopMoney;
        private List<Animal> animalList;
        /// <summary>
        /// The default constructor of AnimalShop creates an object of each Animal subclass 
        /// and adds them to its animalList, also assigns value to ShopMoney. </summary>
        public AnimalShop()
        {
            shopMoney = 0;
            animalList = new List<Animal>();
            animalList.Add(new Bird("Bert", 10, 150.50, false, 12.5, "Havsörn"));
            animalList.Add(new Dog("Fido", 7, 200, true, "Chihuahua"));
            animalList.Add(new Spider("Aragog", 105, 1050, true, 12, "Giant Arachnid"));
        }
        public Animal SellAnimal(string animalType)
        {
            Animal sellAnimal = null;
            foreach (var animal in animalList)
            {
                if (animal.GetType().Name == animalType)
                {
                    ShopMoney += animal.AnimalPrice;
                    Console.WriteLine(
                        $"{ animal } found!\n" +
                        $"Purchasing { animal } for { animal.AnimalPrice }");
                    sellAnimal = animal;
                }
            }
            return sellAnimal;
        }
    }
}
