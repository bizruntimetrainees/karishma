using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    public delegate void MyDelegate(double W, double H);
    class Rectangle
    {
        public void GetArea(double Width,double Height)
        {
            Console.WriteLine("Area value: " + Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("perimeter value:" + 2*(Width + Height));
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            MyDelegate obj = new MyDelegate(r.GetArea);
            obj += new MyDelegate(r.GetPerimeter);
            obj(24.15, 3.13);
            Console.WriteLine();
           

            obj.Invoke(3.14, 6.78);
            Console.ReadKey();

        }
    }
}
