using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncThread
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("code 1");
            Console.WriteLine("code 2 " + Thread.CurrentThread.ManagedThreadId);
            
            Method1();
            Console.WriteLine("code 7");
            Console.WriteLine("code 8");
            Console.ReadKey();
        }
        static async void Method1()
        {
            Console.WriteLine("code 3");
            Console.WriteLine("code 4");
            await Task.Delay(10000);
            Console.WriteLine("code 5");
            Console.WriteLine("code 6 "+ Thread.CurrentThread.ManagedThreadId);
        }



        
    }
}
