using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventProject1
{
    class Program
    {
        static AutoResetEvent obj = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            new Thread(Method).Start();
              Console.ReadLine();
            obj.Set();
            Console.ReadLine();
            obj.Set();
           
        }
        public static void Method()
        {
            Console.WriteLine("starting..1..");
            obj.WaitOne();
            Console.WriteLine("finishing..1...");
            Console.WriteLine("starting..2..");
            obj.WaitOne();
            Console.WriteLine("finishing..2..");
            Console.ReadKey();
        }
    }
}
