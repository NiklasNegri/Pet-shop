using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    public class Menu
    {
        AnimalShop animalShop = new AnimalShop();
        static void StartMenu()
        {
            List<Animal> purchasedAnimals = new List<Animal>();
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
                            Console.WriteLine(animal.ToString());
                        }
                        continue;
                    case 2:
                        Console.WriteLine("What type of animal do you want to buy?\n");
                        string requestedAnimal = Console.ReadLine();
                        purchasedAnimals.Add(SellAnimal(requestedAnimal));
                        continue;
                    case 3:
                        Console.WriteLine($"Current pet shop funds: { animalShop.ShopMoney }\n");
                        continue;
                    case 4:
                        Console.WriteLine("Purchased animals: \n");
                        foreach (var animal in purchasedAnimals)
                        {
                            Console.WriteLine(animal.ToString());
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
