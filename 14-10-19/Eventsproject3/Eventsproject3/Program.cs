using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventsproject3
{
    public delegate void M1Delegate();
    public delegate void M2Delegate(int i,int j);
    class Program
    {
        public void M1()
        {
            Console.WriteLine("m1 is called");
        }
        public void M2(int a,int b)
        {
           Console.WriteLine("m2 is called");
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            M1Delegate md = new M1Delegate(p.M1);
            M2Delegate msd = new M2Delegate(p.M2);
            //msd += new M2Delegate(p.M2);
            md.Invoke();
            msd.Invoke(10, 20);
            //Console.WriteLine(md);
            //Console.WriteLine(msd);
            Console.ReadKey();

        }
    }
}
