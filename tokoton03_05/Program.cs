using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_05
{
    class Program
    {
        private string hello = "Hello!";

        static void Main(string[] args)
        {
            Program c = new Program();
            object o = (object)c;
            Program c2 = (Program)o;

            Console.WriteLine($"{c.hello},{c2.hello}");

            Console.ReadLine();
        }
    }
}
