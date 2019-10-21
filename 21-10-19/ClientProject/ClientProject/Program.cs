using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Net;

using System.Threading.Tasks;

namespace ClientProject
{
    class Program
    {
        static Socket sck;

       

        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11700);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                Console.WriteLine("connection faild");
                Main(args);
            }
            Console.WriteLine("enter text");
            string text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);

            sck.Send(data);
            Console.WriteLine("data sent \r\n");
            Console.WriteLine("press key to continue");
            Console.ReadKey();
            sck.Close();
        }
    }
}
