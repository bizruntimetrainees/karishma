using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlodingProject
{
    class OverLoad
    {
        public void Test()
        {
            Console.WriteLine("method called");
        }
        public void Test1(int i)
        {
            Console.WriteLine("method1 called " + i);
        }
        public void Test2(string s)
        {
            Console.WriteLine("method2 called " + s);
        }
        public void Test3(int i,string s)
        {
            Console.WriteLine("method3 called " + i + " " + s);
        }
        public void Test4(string s,int i)
        {
            Console.WriteLine("method4 called "+s+" "+i);
        }
        static void Main(string[] args)
        {
            OverLoad o = new OverLoad();
            o.Test();
            o.Test1(10);
            o.Test2("hi");
            o.Test3(10,"hi");
            o.Test4("hi",10);
            Console.ReadLine();
        }
    }
}
