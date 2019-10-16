using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            NewMethod();
            Console.WriteLine("start data input,enter user name");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static async void Method()
        {
            await Task.Delay(10000);
            Console.WriteLine("file1");

        }
        public static async void NewMethod()
        {
            await Task.Delay(10000);
            Console.WriteLine("file2");
        }
 
    }
}
