using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Collections;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
      
        static void Main(string[] args)
        {
            System.Collections.Stack s = new System.Collections.Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(null);
            s.Push("hi");
            s.Push(0.12f);
            s.Push(4);

            foreach (Object obj in s)
            {
                Console.WriteLine(obj);
            }

               Console.WriteLine("elements " + s.Count);
                Console.WriteLine("it contains that element  " + s.Contains(3));
                s.Pop();
            Console.WriteLine("elements " + s.Count);
            s.Pop();
            s.Push(1);
            s.Pop();
            Console.WriteLine("elements " + s.Count);
            Console.WriteLine("it contains that element  " + s.Contains(0.21f));
                Console.ReadKey();
                
            
            
        }
        
    }
}
