using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Polymorphism
{
    
    internal class Vehicle
    {
        
        public virtual void MakeSound()
        {
            Console.WriteLine("Vehicle made horn");
        }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started");
        }
    }
    internal class Bike : Vehicle
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bike sounded horn");
            base.MakeSound();
        }
        public new void Start()           //method hiding.. cannot be called using Base class reference.
        {
            Console.WriteLine("Bike started");
        }
    }
}
