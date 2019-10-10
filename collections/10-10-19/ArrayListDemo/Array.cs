using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Array
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList a = new System.Collections.ArrayList();
            a.Add("null");
            a.Add("hi");
            a.Add(3);
            a.Add(false);

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a.Count);
            Console.WriteLine(a.Contains("hi"));
            Console.WriteLine(a[1]);
            a.RemoveAt(1);
            Console.WriteLine(a[1]);
            Console.WriteLine(a.Contains(1));
            Console.ReadKey();
        }
    }
}
    

