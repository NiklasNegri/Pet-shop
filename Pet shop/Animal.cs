using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_shop
{
    /// <summary>
    /// Class Animal holds shared variables for all inheriting subclasses.
    /// </summary>
    public abstract class Animal
    {
        public double AnimalPrice { get; protected set; }
        public int AnimalAge { get; protected set; }
        public string AnimalName { get; protected set; }
    }
}
