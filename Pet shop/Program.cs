using System;

namespace Pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // commenting out all below when not testing, cleaning up before release

            AnimalShop defaultAnimalShop = new AnimalShop();

            Bird defaultBird = new Bird();
            Dog defaultDog = new Dog();
            Spider defaultSpider = new Spider();

            Console.ReadKey();
        }
    }
}
