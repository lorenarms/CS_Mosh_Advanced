using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_16_BitwiseOperators
{
    class Driver
    {
        public static void Main()
        {
           
            int x = 5, y = 6;
            WriteLine("x = " + x + " y = " + y);
            SwapStandard(ref x, ref y);
            WriteLine("x = " + x + " y = " + y);

            CompareAnd(x, y);

            ReadKey();
        }

        public static void SwapStandard(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void CompareAnd(int x, int y)
        {
            WriteLine("x & y: " + (x & y));     // 4
            WriteLine("x | y: " + (x | y));     // 7
            WriteLine("x ^ y: " + (x ^ y));     // 3
            WriteLine("x << 2: " + (x << 2));   // 24
            WriteLine("y >> 2: " + (y >> 2));   // 1

        }


    }


}
