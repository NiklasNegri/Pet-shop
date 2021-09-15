using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Class Animal holds shared variables for all inheriting subclasses.
    /// </summary>
    public class Animal
    {
        protected double AnimalPrice { get; set; }
        protected int AnimalAge { get; set; }
        protected string AnimalName { get; set; }
        protected string AnimalSpecies { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: { AnimalName }, age: { AnimalAge }, cost to purchase: { AnimalPrice }\n");
        }
    }
}
