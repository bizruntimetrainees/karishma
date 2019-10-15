using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAnonymous
{
    public delegate string StringDelegate(string strr);
    public class Program
    {


        public static void Main()
        {
            string str;
           
            StringDelegate p = (st)=> {
                return "hello " + st;
               
            };
            
            str = p("scott");
            Console.WriteLine("Inside Anonymous method  string is:  "+str);
            Console.WriteLine();
            str = p.Invoke("karishma");
            Console.WriteLine("Inside Anonymous method  string is:  "+str);
            Console.ReadKey();
        }
    }
}


