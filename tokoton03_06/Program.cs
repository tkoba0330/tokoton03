using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_06
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
            if (o is Class2)
            {
                Console.WriteLine(((Class2)o).Hello);
            }

            Console.ReadLine();

        }
    }
}
