using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public sealed class SealedClassDemo
    {
        public class MyLibrary
        {
            public void ProductPricingAlgorithm()
            {
                Console.WriteLine("Analyse the market and estimate price for the product");
            }
            public void ApplicationSecurity()
            {
                Console.WriteLine("Provides security to the application");
            }
            public void Description()
            {
                Console.WriteLine("Make use of this library.. but please don't try to mess it up by inheriting it");
            }
        }
    }
}
