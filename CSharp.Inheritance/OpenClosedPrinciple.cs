using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class OpenClosedPrinciple
    {
        public interface PizzaMaker
        {
            void MakeCrust();
            void AddSauce();
            void AddToppings();
        }
        public class VegPizzaMaker : PizzaMaker
        {
            public void MakeCrust()
            {
                Console.WriteLine("Crust prepared");
            }
            public void AddSauce()
            {
                Console.WriteLine("Sauce added");
            }
            public void AddToppings()
            {
                Console.WriteLine("Toppings added");
            }
            public void AddVegToppings()
            {
                Console.WriteLine("Veg Toppings Added");
            }
        }
        public class NonVegPizzaMaker : PizzaMaker
        {
            public void MakeCrust()
            {
                Console.WriteLine("Crust prepared");
            }
            public void AddSauce()
            {
                Console.WriteLine("Sauce added");
            }
            public void AddToppings()
            {
                Console.WriteLine("Toppings added");
            }
            public void AddNonVegToppings()
            {
                Console.WriteLine("Non Veg Toppings Added");
            }
        }

    }
}
