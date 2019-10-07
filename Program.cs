using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle obj = new Rectangle();
            obj.setWidth(7);
            obj.setHeight(5);
            Console.WriteLine(obj.getArea());
            Console.ReadKey();*/


            /*Printdata p = new Printdata();
            p.print(4);
            p.print(44.5);
            p.print("String");
            Console.ReadKey();*/


            /*Private p = new Private();
            p.Acceptdetails();
            p.Display();
            Console.ReadKey();*/


            /*Internal i = new Internal();
            i.length = 3.5;
            i.width = 7.6;
            i.Display();
            Console.ReadKey();*/


            /*Public p = new Public();
            p.length = 4.9;
            p.width = 6.8;
            p.Display();
            Console.ReadKey();*/


            Rectangle1 r = new Rectangle1(20,30);
            double a = r.area();
            Console.WriteLine("Area: {0}", a);
            Console.ReadKey();
        }
        
    }
}
