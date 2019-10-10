using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("C#");
            q.Enqueue("Javascript");
            q.Enqueue("Ajax");
            q.Enqueue("Collections");
            Console.WriteLine(" elements in the Queue " + q.Count);
            Console.WriteLine("Does the Queue contain " + q.Contains("hi"));
            Console.WriteLine("1st element in list --> " + q.Peek());
            q.Dequeue();

            Console.WriteLine(q.Count);
            Console.WriteLine("1st element in list --> "+q.Peek());
            Console.ReadLine();
        }
    }
}
