using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject
{


    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
        }
    }



    public delegate void DelegateName(string data);

    class Child
    {
        public event DelegateName delegateName;

        public void call()
        {
            delegateName("C# events");
        }
    }


    class Parent
    {
        public Parent()
        {
            Child c = new Child();
            c.delegateName += new DelegateName(print);


            c.call();
        }

        public void print(string name)
        {
            Console.WriteLine(" the name : " + name);
            Console.ReadKey();
        }
    }
}