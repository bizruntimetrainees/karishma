using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefineDelegates
{
    public delegate double AddDelegate1(int i, float f, double d);
    public delegate void AddDelegate2(int i, float f, double d);
    public delegate bool CheckDelegate(string s);
    class Program
    {
        public static double AddNum1(int i,float f,double d)
        {
            return i + f + d;
        }
        public static void AddNum2(int i, float f, double d)
        {
            Console.WriteLine("value:  "+i * f * d);
        }
        public static bool Checking(string s)
        {
            if (s.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = AddNum1;
            double rslt = obj1.Invoke(2, 4.5f, 23.98);
            Console.WriteLine("value:  "+rslt);
            Console.WriteLine();
            Action<int, float, double> obj2 = AddNum2;
             obj2.Invoke(2, 76.7f,65.98);
            Console.WriteLine();
            Predicate<string> obj3 =Checking;
            bool status = obj3.Invoke("kareishma");
            Console.WriteLine(status);
            Console.ReadKey();
           

        }
    }
}
