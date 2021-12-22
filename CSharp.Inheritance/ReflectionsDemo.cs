using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class ReflectionsDemo
    {
        public void demo()
        {
            Type t = typeof(StaticClassDemo);
            Console.WriteLine(t.Assembly);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Attributes);
            Console.WriteLine(t.MemberType);
            Console.WriteLine(t.IsAbstract);
            Console.WriteLine(t.IsByRef);
            MethodInfo[] mi = t.GetMethods(BindingFlags.Public | BindingFlags.Static);
            foreach( var m in mi)
            {
                Console.WriteLine(m);
            }
        }
    }
}
