using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // データの欠落が発生する可能性がある場合はコンパイルエラーになる
            // -> キャストすることにより強引に代入することができる
            // -> 代入先の制限を超える場合はデータが破壊（欠落）される
            long l = 1844674407370955161;
            int i = (int)l;
            short s = (short)i;
            sbyte b = (sbyte)s;

            Console.WriteLine($"{b},{s},{i},{l}");

            char[] str30 = "123456789012345678901234567890".ToCharArray();
            char[] str = new char[10];
            str = str30;

            Console.Write($"{new string(str30)},{new string(str)}");

            Console.ReadLine();
        }
    }
}
