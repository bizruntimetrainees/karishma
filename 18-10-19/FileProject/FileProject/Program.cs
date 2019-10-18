using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteForFile();
            ReadForFile();
        }


        public static void WriteForFile()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\source\repos\FileIO\file.txt");
            sw.WriteLine("hellow world");
            sw.Close();
           
        }
        public static void ReadForFile()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Administrator\source\repos\FileIO\file.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            Console.ReadKey();
           
        }
    }
}
