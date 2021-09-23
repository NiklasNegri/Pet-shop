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
        // I set AnimalPrice to public since I need to access the value outside of the class
        // and its subclasses, and its setter to protected because I only want to assign the value within the subclasses
        // I set AnimalAge and AnimalName to protected because I only want to assign the values within the subclasses
        // and use the ToString method to print its values outside of this scope
        public double AnimalPrice { get; protected set; }
        protected int AnimalAge { get; set; }
        protected string AnimalName { get; set; }
        public override string ToString()
        {
            return string.Format($"Animal type: { GetType().Name }, name: { AnimalName }, age: { AnimalAge }, price: { AnimalPrice }\n");
        }
    }
}
