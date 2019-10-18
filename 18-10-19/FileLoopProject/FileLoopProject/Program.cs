using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileLoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"C:\Users\Administrator\source\repos\FileIO\demo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i=1; i<=10;i++)
            {
                f.WriteByte((byte)i);
              }
            f.Position = 0;

            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine(f.ReadByte() +  " ");

            }
            f.Close();
            Console.ReadKey();
        }

    }
}

