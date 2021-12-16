using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class VariableTypes
    {
        public void DemonstrateValueTypes()
        {
            int a = 10;
            int b;
            b = a;
            unsafe
            {
                int *ptrA = &a;
                int *ptrB = &b;
                Console.WriteLine((int)ptrA);
                Console.WriteLine((int)ptrB);
                Console.WriteLine("a-->{0}", a);
                Console.WriteLine("b-->{0}", b);
            }
            b = 20;
            unsafe
            {
                int* ptrA = &a;
                int* ptrB = &b;
                Console.WriteLine((int)ptrA);
                Console.WriteLine((int)ptrB);
                Console.WriteLine("a-->{0}", a);
                Console.WriteLine("b-->{0}", b);
            }
        }
        public void DemonstrateRefTypes()
        {
            Node node = new Node { data = 1, nextLocation = 983938 };
            List<Node> nodes = new List<Node>();
            for(int i = 0; i < 10; i++)
            {
                nodes.Add(node);
            }

            node.data = 2;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nodes[i].data);
            }

        }
        public class Node
        {
            public int data;
            public double nextLocation;
        }
    }
}
