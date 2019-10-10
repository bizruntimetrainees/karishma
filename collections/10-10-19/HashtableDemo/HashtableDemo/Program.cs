using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableDemo
{
    class Hash
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("1", "C#");
            h.Add("2", "learn");
            h.Add("3", "Properly");

            ICollection keys = h.Keys;

            foreach (String k in keys)
            {
                Console.WriteLine(h[k]);
            }
            Console.ReadKey();
        }
    }
}