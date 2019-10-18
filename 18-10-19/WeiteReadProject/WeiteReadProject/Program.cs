using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvanceFileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\source\repos\FileIO\demoo.txt");

                string st = "this is program belongs to file io";
                sw.WriteLine(st);
                
                sw.Close();

                StreamReader sr = new StreamReader(@"C:\Users\Administrator\source\repos\FileIO\demoo.txt");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }
                sr.Close();
            }




            catch (Exception e)
            {
                Console.WriteLine("file could not read");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
