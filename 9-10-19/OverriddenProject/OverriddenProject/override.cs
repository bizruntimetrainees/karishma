using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverriddenProject
{
    class Override
    {
        public void Show()
        {
            Console.WriteLine(" parent show method is called");
        }
        public virtual void Test()
        {
            Console.WriteLine(" Test method is called");
        }
    } 
    class Child : Override
    {
        public void Show(int i)
        {
            Console.WriteLine("child show method is called");
        }
        public override void Test()
        {
            Console.WriteLine(" child Test method is called");
        }
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Show();
            c.Show(10);
            c.Test();
            Console.ReadLine();

        }
    }
}
