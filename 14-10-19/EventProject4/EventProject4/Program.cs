using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventProject4
{
    public delegate void MyDelegate(int x, int y);
    
    class Program
    {
        public   event MyDelegate Event1;
        public  event MyDelegate Event2;

        public  void M1(int a,int b)
        {
            Console.WriteLine("M1 is called");
            Console.WriteLine(a + b);
        }
        public  void M2(int i,int j)
        {
            Console.WriteLine("M2 is called" );
            Console.WriteLine(i * j);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           p.Event1+= new MyDelegate(p.M1);
           p.Event2+= new MyDelegate(p.M2);
           p.Event1(10, 20);
            p.Event2(30,70);
            Console.ReadKey();


        }
    }
}
