using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Inheritance
{
    //inheritance main purpose is to implement code reusability.
    //used to modify the behaviour of an existing class without changing the structure of that class.
    internal class Animal
    {
        protected string NoOfLegs { get; set; }
        public Animal()
        {
            Console.WriteLine("Hi i am an animal");
        }
        public Animal(string name)
        {
            Console.WriteLine($"Hi i am {name}");
        }
        public static void SayHello()
        {
            Console.WriteLine("Helloo!!");
        }


    }
    internal class Dog : Animal
    {
        public Dog() : base("Dog")
        {
            Bark();
        }
        public void Bark()
        {
            Console.WriteLine("Bow Bow");
        }

    }
    internal class Cat : Animal
    {
        public string Type { get; set; }
        public Cat() : base("cat")
        {
            Meow();
            NoOfLegs = "4";   //protected properties cannot be accessed using child instances.. but accessible only in child classes
        }

        public void Meow()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
