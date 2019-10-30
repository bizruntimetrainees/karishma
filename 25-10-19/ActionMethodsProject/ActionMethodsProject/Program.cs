using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ActionMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
     
            //Emptable e = new Emptable();
            //e.Methods();
            //e.Create();
            Dropclass d = new Dropclass();
            d.Droptable();
            d.Parameterized();







        }
    }
}
