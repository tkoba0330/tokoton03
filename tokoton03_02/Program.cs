using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // データの欠落が発生する可能性がある場合はコンパイルエラーになる
            long l = 123;
            int i = l;
            short s = i;
            sbyte b = s;

            Console.WriteLine($"{b},{s},{i},{l}");
        }
    }
}
