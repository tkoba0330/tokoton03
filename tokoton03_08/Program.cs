using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            int j = (int)o;

            Console.WriteLine($"{i},{o},{j}");


            Console.ReadLine();
        }
    }
}
