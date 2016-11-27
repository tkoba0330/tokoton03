using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // データの欠落が発生する可能性がある場合はコンパイルエラーになる
            // -> キャストすることにより強引に代入することができる
            long l = 123;
            int i = (int)l;
            short s = (short)i;
            sbyte b = (sbyte)s;

            Console.WriteLine($"{b},{s},{i},{l}");

            Console.ReadLine();
        }
    }
}
