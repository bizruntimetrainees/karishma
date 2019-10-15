using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousProject1
{
    public delegate int PrintDelegate(int value);
    public class Program
    {
        

        public static void Main()
        {
            int j;
           PrintDelegate p = delegate (int val) {
               return   val;
                Console.WriteLine("Inside Anonymous method  Value is :"+ val);
            };

            j=p(100);
            Console.WriteLine("value of:   "+j);
          j= p.Invoke(200);
            Console.WriteLine("value of:" +j);
            Console.ReadKey();
        }
    }
}
