using System;
using System.Collections.Generic;

namespace Pet_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            // Answering the question:
            // 1. When should you use private instead of public?
            // 2. When is it useful to have multiple constructor functions?

            // 1. You should use private when you don't want or need to access the property, class, method etc outside
            // of the class. Public should only be used when you need access outside of the class itself.

            // 2. Having multiple constructor functions is useful if you need to instance a class with
            // different values. For example if you need to add a user with admin rights to an administrative program 
            // you can have a constructor that sets the admin rights to true automatically and then allows
            // parameters to input the users first and last name. In this case it would be useful to also have a default constructor
            // that sets the value of admin rights to false.
        }     
    }
}
