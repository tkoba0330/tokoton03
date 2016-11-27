using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_07
{
    class Class2
    {
        internal string Hello = "Hello!";
    }

    class Class1
    {
        static void Main(string[] args)
        {
            object o = new Class2();
            var c2 = o as Class2;
            if (c2 != null)
            {
                Console.WriteLine(c2.Hello);
            }

            Console.ReadLine();

        }
    }
}
