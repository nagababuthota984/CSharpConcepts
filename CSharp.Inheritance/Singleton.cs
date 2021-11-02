using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public sealed  class Singleton
    {
        private static Singleton instance = null;
        private static int count = 0;
        private Singleton()
        {
            count++;
        }
        public static Singleton Instance
        {
            get { return instance ??= new Singleton(); }
        }
        public static int Count { get { return count; } }
    }
    internal  class SealedClass
    {
        private SealedClass()
        {  }
        internal class SubClass : SealedClass
        {

        }

    }
    
}
