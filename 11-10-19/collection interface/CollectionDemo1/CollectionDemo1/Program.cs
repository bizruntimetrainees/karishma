using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        ArrayList a = new ArrayList() { 1, 3, 2.1f, 1, "one", "C#",false };

         IList l = new ArrayList() { 100, 200,"hi",null,true };
        a.RemoveAt(0);
        Console.WriteLine("element present : " + a.Contains(100));
        Console.WriteLine("element present : " + l.Contains(100));

    
        a.AddRange(l);

        for (int i = 0; i < a.Count; i++)
            Console.WriteLine(a[i]);
        Console.ReadKey();
    }
}