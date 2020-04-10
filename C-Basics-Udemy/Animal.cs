using System;
using System.Collections.Generic;
using System.Text;

namespace C_Basics_Udemy
{
    public class Animal
    {
        public string name;
        public int age;

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }

        //With public you can modify the value, when the class is private
        //public string name = "Teddy";

        //Acces modifiers for a class:
        //public
        //private < default
        //static
    }
}
