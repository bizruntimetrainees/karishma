using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProject2
{
    public delegate  void AddDelegate(int a, int b);
    public delegate string PersonDelegate(string str);
    class Program
    {
        public void AddNum(int i,int j)
        {
            Console.WriteLine(i + j);
        }
        public static string PersonName(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNum);
            PersonDelegate pd = new PersonDelegate(Program.PersonName);
            ad.Invoke(100, 200);

            string str= pd.Invoke("microsoft");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
