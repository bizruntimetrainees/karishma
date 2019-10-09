using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddingProject
{
    class Hidding
    {
        public virtual void Show()
        {
            Console.WriteLine("show parent method is called");
        }
        public void Test()
        {
            Console.WriteLine(" parent test method is called");
        }
    }
    class Child : Hidding
    {
        public override void Show()
        {
            Console.WriteLine("show child method is called");
      }
        public void ParentShow()
        {
            base.Show();
        }
        public void ParentTest()
        {
            base.Test();
        }
        public new void Test()
      {
         Console.WriteLine("  child test method is called");
       }

        static void Main(string[] args)
        {
            Child c = new Child();
            c.ParentShow();
            c.ParentTest();
            c.Show();
            c.Test();
            Hidding h = c;
            h.Show();
            h.Test();
            Console.ReadLine();
        }
    }
}
