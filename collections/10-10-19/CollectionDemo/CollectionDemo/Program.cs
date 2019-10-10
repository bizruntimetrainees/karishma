using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<int> a = new List<int>();
            for (int j = 1; j <=5; j++)
            {
                a.Add(j + 1);
            }

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}