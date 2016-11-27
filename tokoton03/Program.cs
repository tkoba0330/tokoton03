using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte b = 123;
            short s = b;
            int i = s;
            long l = i;
            Console.WriteLine($"{b},{s},{i},{l}");

            Console.ReadLine();
        }
    }
}
