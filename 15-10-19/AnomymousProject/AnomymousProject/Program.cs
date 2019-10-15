using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnomymousProject
{

    class Program
    {
        public delegate string GrettingsDelegate(string name);

        static void Main()
        {
            Program p = new Program();




            GrettingsDelegate obj = delegate (string name)
            {
                return "hello    " + name;
            };


            string str = obj.Invoke("scott");
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }

    }

