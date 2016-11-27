using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_09
{
    class MilliMetor
    {
        public double Length { get; set; }

        public static implicit operator CentiMeter(MilliMetor mm)
        {
            return new CentiMeter() { Length = mm.Length / 10 };
        }
    }

    class CentiMeter
    {
        public double Length { get; set; }
        public static implicit operator MilliMetor(CentiMeter cm)
        {
            return new MilliMetor() { Length = cm.Length * 10 };
        }
    }


    class Class1
    {
        static void Main(string[] args)
        {
            CentiMeter cm = new CentiMeter() { Length = 123 };
            MilliMetor mm = cm;

            Console.WriteLine($"{cm.Length}cm,{mm.Length}mm");

            MilliMetor mm2 = new MilliMetor { Length = 456 };
            CentiMeter cm2 = mm2;

            Console.WriteLine($"{cm2.Length}cm,{mm2.Length}mm");

            Console.ReadLine();
        }
    }
}
