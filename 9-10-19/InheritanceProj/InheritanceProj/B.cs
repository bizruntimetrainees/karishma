using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProj
{
    class B : A
    {
        B()
        {
            Console.WriteLine("B constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine(" Test3 method is called");
        }
        static void Main(string[] args)
        {
            B b = new B();
            b.Test1();
            b.Test2();
            b.Test3();
           A a;
           a = b;
           a.Test1();
           a.Test2();
            Console.ReadLine();
        }
    }
}
