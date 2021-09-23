using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Class Menu is used to test the program and make sure all its functions are working as intended.
    /// </summary>
    public class Menu
    {
        AnimalShop animalShop;
        List<Animal> purchasedAnimals;
        /// <summary>
        /// The default constructor of Menu instantiates objects of animalShop and purchasedAnimals
        /// and also populates the animalShop list with animals so that we can test the program,
        /// after that it runs the RunMenu method which starts the program.
        /// </summary>
        public Menu()
        {
            animalShop = new AnimalShop();
            purchasedAnimals = new List<Animal>();
            animalShop.animalList.Add(new Bird("Jago", 10, 153.54, true, 12, "Parrot"));
            animalShop.animalList.Add(new Dog("Fido", 12, 120.13, false, "Chihuahua"));
            animalShop.animalList.Add(new Spider("Aragog", 150, 1200.12, true, 12, "Giant Spider"));
            RunMenu();
        }
        /// <summary>
        /// The RunMenu method has a loop that wont break until the user wants to exit the program
        /// which lets the user test the program without having to restart it.
        /// It outputs text to the console to help the user navigate the program via a switch case menu.
        /// </summary>
        public void RunMenu()
        {
            bool stopLoop = false;
            Console.WriteLine(
                "1. Check pet shop inventory\n" +
                "2. Purchase a pet\n" +
                "3. Check pet shop funds\n" +
                "4. Check your purchased animals\n" +
                "5. Exit the pet shop");
            do
            {
                string parseChoice = Console.ReadLine();
                int.TryParse(parseChoice, out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        foreach (var animal in animalShop.animalList)
                        {
                            Console.WriteLine(animal.GetType().Name);
                        }
                        continue;
                    case 2:
                        Console.WriteLine("What type of animal do you want to buy?\n");
                        string requestedAnimal = Console.ReadLine();
                        purchasedAnimals.Add(animalShop.SellAnimal(requestedAnimal));
                        continue;
                    case 3:
                        Console.WriteLine($"Current pet shop funds: { animalShop.ShopMoney }\n");
                        continue;
                    case 4:
                        if (purchasedAnimals.Count != 0)
                        {
                            Console.WriteLine("Purchased animals: \n");
                            foreach (var animal in purchasedAnimals)
                            {
                                Console.WriteLine(animal);
                            }                     
                        }
                        else
                        {
                            Console.WriteLine("You have not purchased any animals!");
                        }
                        continue;
                    case 5:
                        Console.WriteLine("Exiting the pet shop ...");
                        stopLoop = true;
                        break;
                    default:
                        Console.WriteLine("Only accepts 1-4 as input!");
                        continue;
                }
            } while (!stopLoop);
        }
    }
}
