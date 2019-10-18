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
                StreamReader sr = new StreamReader(@"C:\Users\Administrator\source\repos\FileIO\filee.txt");
                  
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                    }
                sr.Close();
                }
            
                
            

            catch(Exception e)
            {
                Console.WriteLine("file could not read");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
